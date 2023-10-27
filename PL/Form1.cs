using Models;
using BLL.Controllers;
using System.Text.RegularExpressions;

namespace PL
{
    public partial class Form1 : Form
    {
        CategoryController categoryController;
        FlowController flowController;
        ValidationPL validation;
        public Form1()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            flowController = new FlowController();
            validation = new ValidationPL();
            populateAllCombobox();
            populateCategoriesLv();
            populateListView1();
        }

        public void ClearAllCombobox()
        {
            podcastCategoryCb.Items.Clear();
            filterOnCategoryCb.Items.Clear();
            comboBox1.Items.Clear();
        }

        public void populateAllCombobox()
        {
            foreach (Category category in categoryController.GetCategories())
            {
                podcastCategoryCb.Items.Add(category.Name);
                filterOnCategoryCb.Items.Add(category.Name);
                comboBox1.Items.Add(category.Name);
            }
        }

        public void populateCategoriesLv()
        {
            foreach (Category category in categoryController.GetCategories())
            {
                categoriesLv.Items.Add(category.Name);
            }
        }

        private void addCategoryBtn_Click_1(object sender, EventArgs e)
        {
            string categoryName = categoryNameTxt.Text;

            if (categoryName != "" && !validation.isCategoryNameTaken(categoryName))
            {
                categoryController.CreateCategory(categoryName);
                categoryNameTxt.Clear();
                ClearAllCombobox();
                populateAllCombobox();
                categoriesLv.Clear();
                populateCategoriesLv();
            }
            else
            {
                MessageBox.Show("Vänligen ange ett unikt kategorinamn");
            }
        }

        private void editCategoryBtn_Click_1(object sender, EventArgs e)
        {
            if (categoriesLv.SelectedItems.Count > 0)
            {
                int categoryIndex = categoriesLv.SelectedIndices[0];
                string newCategoryName = newCategoryNameTxt.Text;

                if (newCategoryName != "" && !validation.isCategoryNameTaken(newCategoryName))
                {
                    categoryController.UpdateCategoryName(categoryIndex, newCategoryName);
                    newCategoryNameTxt.Clear();
                    ClearAllCombobox();
                    populateAllCombobox();
                    categoriesLv.Clear();
                    populateCategoriesLv();
                }
                else
                {
                    MessageBox.Show("Vänligen ange ett nytt kategorinamn som är unikt");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en kategori att ändra i listan");
            }
        }

        private void removeCategoryBtn_Click(object sender, EventArgs e)
        {
            if(categoriesLv.SelectedItems.Count > 0)
            {
                int categoryIndex = categoriesLv.SelectedIndices[0];
                categoryController.DeleteCategory(categoryIndex);

                //Uppdaterar combobox och listview
                categoriesLv.Clear();
                populateCategoriesLv();
                podcastCategoryCb.SelectedIndex = -1;
                ClearAllCombobox();
                populateAllCombobox();
            }
            else
            {
                MessageBox.Show("Vänligen välj en kategori i listan");
            }
               
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            string rss = textBox1.Text;
            string name = "";
            if (!validation.isNull(textBox2))
            {
                name = textBox2.Text;
            }
            string categoryName = podcastCategoryCb.GetItemText(podcastCategoryCb.SelectedItem);
            if (!validation.CheckURL(rss) && validation.CheckEmptyTxt(categoryName))
            {
                MessageBox.Show("Ogiltig URL, testa igen med en annan! Måste välja en Kategori, Namn på Flödet måste vara unikt!");
            }
            else if (!validation.CheckURL(rss))
            {
                MessageBox.Show("Ogiltig URL, testa igen med en annan!");
            }
            else if(validation.CheckEmptyTxt(categoryName))
            {
                MessageBox.Show("Måste välja en kategori!");
            }
            else
            {
                Category category = categoryController.GetCategory(categoryName);
                if (!await flowController.CreateFlow(name, rss, category))
                {
                    MessageBox.Show("Denna URL är trasig!");
                }
                populateListView1();
            }

        }
        public void populateListView1()
        {
            listView1.Items.Clear();
            foreach (Flow flow in flowController.GetFlows())
            {
                string[] newRow = { $"{flow.Episodes.Count}", $"{flow.Name}", $"{flow.Title}", $"{flow.Category.Name}" };
                var listViewItem = new ListViewItem(newRow);
                listView1.Items.Add(listViewItem);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DisplayEpisodes();
            }
            else
            {
                listView2.Items.Clear();
                richTextBox1.Clear();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                DisplayDescription();
            }
        }

        private async void DisplayEpisodes()
        {
            string podcastFlowName = listView1.SelectedItems[0].SubItems[1].Text;
            Flow flow = flowController.getFlow(podcastFlowName);

            List<Episode> episodes = flow.Episodes;

            listView2.Items.Clear();
            foreach (Episode episode in episodes)
            {
                listView2.Items.Add(episode.Name);
            }
        }

        private void DisplayDescription()
        {
            string episodeName = listView2.SelectedItems[0].SubItems[0].Text;
            string podcastFlowName = listView1.SelectedItems[0].SubItems[1].Text;
            Flow flow = flowController.getFlow(podcastFlowName);
            List<Episode> episodes = flow.Episodes;

            richTextBox1.Clear();

            foreach (Episode episode in episodes)
            {
                if (episode.Name.Equals(episodeName))
                {

                    string regexDescription = Regex.Replace(episode.Description, "<.*?>", string.Empty);
                    richTextBox1.AppendText(regexDescription);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Updates name of flow 
            if (listView1.SelectedItems.Count > 0)
            {
                string podcastFlowName = listView1.SelectedItems[0].SubItems[1].Text;
                int flowIndex = listView1.SelectedIndices[0];
                Flow flow = flowController.getFlow(podcastFlowName);
                string newName = textBox3.Text;
                flowController.UpdateFlowName(flowIndex, flow, newName);
                populateListView1();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Updates the category of flow
            if (listView1.SelectedItems.Count > 0 && comboBox1.SelectedItem != null)
            {
                string podcastFlowName = listView1.SelectedItems[0].SubItems[1].Text;
                int flowIndex = listView1.SelectedIndices[0];
                Flow flow = flowController.getFlow(podcastFlowName);
                string newCategoryName = comboBox1.GetItemText(comboBox1.SelectedItem);
                Category newCategory = categoryController.GetCategory(newCategoryName);
                flowController.updateFlowCategory(flowIndex, flow, newCategory);
                populateListView1();
            }
            else
            {
                MessageBox.Show("Måste välja en kategori och ett flöde");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int flowIndex = listView1.SelectedIndices[0];
                flowController.DeleteFlow(flowIndex);
                populateListView1();
                listView2.Items.Clear();
                richTextBox1.Clear();
            }
        }

        private void filterOnCategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryFilter = filterOnCategoryCb.GetItemText(filterOnCategoryCb.SelectedItem);
            List<Flow> flowList = flowController.GetFlows();

            var queryExpression = from flow in flowList
                                  where flow.Category.Name.Equals(categoryFilter)
                                  select flow;

            listView1.Items.Clear();
            foreach (var flow in queryExpression)
            {
                string[] newRow = { $"{flow.Episodes.Count}", $"{flow.Name}", $"{flow.Title}", $"{flow.Category.Name}" };
                var listViewItem = new ListViewItem(newRow);
                listView1.Items.Add(listViewItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populateListView1();
        }
    }
}
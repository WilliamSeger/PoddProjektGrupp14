using Models;
using BLL.Controllers;

namespace PL
{
    public partial class Form1 : Form
    {
        CategoryController categoryController;
        FlowController flowController;
        public Form1()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            flowController = new FlowController();
            populateAllCombobox();
            populateCategoriesLv();
        }

        public void ClearAllCombobox()
        {
            podcastCategoryCb.Items.Clear();
            filterOnCategoryCb.Items.Clear();
        }

        public void populateAllCombobox()
        {
            foreach (Category category in categoryController.GetCategories())
            {
                podcastCategoryCb.Items.Add(category.Name);
                filterOnCategoryCb.Items.Add(category.Name);
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

            if (categoryName != "")
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
                MessageBox.Show("Vänligen ange ett kategorinamn");
            }
        }

        private void editCategoryBtn_Click_1(object sender, EventArgs e)
        {
            if (categoriesLv.SelectedItems.Count > 0)
            {
                int categoryIndex = categoriesLv.SelectedIndices[0];
                string newCategoryName = newCategoryNameTxt.Text;

                if (newCategoryName != "")
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
                    MessageBox.Show("Vänligen ange ett nytt kategorinamn");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en kategori att ändra i listan");
            }
        }

        private void removeCategoryBtn_Click(object sender, EventArgs e)
        {
            int categoryIndex = categoriesLv.SelectedIndices[0];
            categoryController.DeleteCategory(categoryIndex);

            //Uppdaterar combobox och listview
            categoriesLv.Clear();
            populateCategoriesLv();
            ClearAllCombobox();
            populateAllCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rss = textBox1.Text;
            string name = "";
            if (!textBox2.Equals(null))
            {
                name = textBox2.Text;
            }
            string categoryName = podcastCategoryCb.GetItemText(podcastCategoryCb.SelectedItem);
            Category category = categoryController.GetCategory(categoryName);
            flowController.CreateFlow(name, rss, category);
        }
    }
}
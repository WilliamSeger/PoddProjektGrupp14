using Models;
using BLL.Controllers;

namespace TestWinForm
{
    public partial class Form1 : Form
    {
        CategoryController categoryController;
        public Form1()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            populateAllCombobox();
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
    }
}
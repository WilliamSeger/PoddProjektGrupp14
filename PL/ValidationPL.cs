using BLL.Controllers;

namespace Models
{
    public class ValidationPL
    {
        FlowController flowController;
        CategoryController categoryController;

        public ValidationPL()
        {
            flowController = new FlowController();
            categoryController = new CategoryController();
        }
        public bool CheckURL(string url)

        {
            Uri uri;
            bool correctURL = Uri.TryCreate(url, UriKind.Absolute, out uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
            return correctURL;
        }

        public bool CheckEmptyTxt(string text)
        {
            return String.IsNullOrEmpty(text);
        }

        public bool isNull(object obj)
        {
            return obj == null;
        }

        public bool isCategoryNameTaken(string name)
        {
            Category category = categoryController.GetCategory(name);
            if (category != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool ItemsContainsAny(flow podcast)
        //{
        //    bool itemHasAny = false;
        //    try
        //    {
        //        if (!podcast.items.Any())
        //        {
        //            throw new UserException("Podden har felskriven eller ingen item summary / titel. Kunde ej prenumerera");
        //        }
        //        else
        //        {
        //            itemHasAny = true;
        //            return itemHasAny;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Fel!");
        //    }
        //    return itemHasAny;
        //}
    }
}

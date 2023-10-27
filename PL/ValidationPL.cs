using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
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
            string URLValidering = string.Empty;
            Encoding enc = Encoding.ASCII;
            WebClient obj = new WebClient();
            URLValidering = enc.GetString(obj.DownloadData(url));
            return URLValidering.Length != 0 ? true : false;
        }

        public bool CheckEmptyTxt(string text)
        {
            return String.IsNullOrEmpty(text);
        }

        public bool isNull(object obj)
        {
            return obj == null;
        }

        public bool isFlowNameTaken(string name)
        {
            Flow flow = flowController.getFlow(name);
            if (flow != null)
            {
                return true;

            }
            else
            {
                return false;
            }
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

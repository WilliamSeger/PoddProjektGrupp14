using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models
{
    public static class Validation
    {
    private static flowController podcontroll = new flowController();
    private static CategoryController catontroll = new CategoryController();

    public static bool CheckURL(string url)
        {
            string URLValidering = string.Empty;
            try
            {
                System.Text.Encoding enc = System.Text.Encoding.ASCII;
                WebClient obj = new WebClient();
                URLValidering = enc.GetString(obj.DownloadData(url));
            }
            catch (Exception e)
            {

                return false;
            }
            return URLValidering.Length != 0 ? true : false;
        }

        public static bool CheckEmptyTxt(string text)
    {
        bool isEmpty = String.IsNullOrEmpty(text);
        try
        {
            if (isEmpty)
            {
                throw new UserException("Ett obligatoriskt textfält är inte ifyllt.", "Kolla igenom fälten");
            }
        }
        catch (UserException ex)
        {
            MessageBox.Show(ex.Message, ex.Header);
        }
        return isEmpty;
    }

    public static bool ContainsWhiteSpace(string text)
    {
        bool hasWhiteSpace = text.Any(Char.IsWhiteSpace);
        try
        {
            if (hasWhiteSpace)
            {
                throw new UserException("Du får inte ha mellanslag i fälten", "Kolla igenom fälten");

            }
        }
        catch (UserException ex)
        {
            MessageBox.Show(ex.Message, ex.Header);
        }
        return hasWhiteSpace;
    }

    public static bool isNull(object obj)
    {
        bool isNull = true;
        try
        {
            if (obj == null)
            {
                isNull = true;
                throw new UserException("Objektet skapades inte");

            }
            else
            {
                isNull = false;
                return isNull;
            }
        }
        catch (UserException ex)
        {
            string msg = ex.Message;
            MessageBox.Show(msg);
        }
        return isNull;
    }

    public static bool isPodcastNameTaken(string name)
    {

        bool isTaken = true;
        try
        {
            Media pod = podcontroll.GetPodByName(name);
            if (pod != null)
            {
                isTaken = true;
                throw new UserException("Du har redan en podcast med detta namnet");

            }
            else
            {
                isTaken = false;
                return isTaken;
            }
        }
        catch (UserException ex)
        {
            MessageBox.Show(ex.Message, "Fel!");
        }
        return isTaken;
    }



    public static bool isCategoryNameTaken(string name)
    {
        bool isTaken = true;
        try
        {
            Category cat = catontroll.GetCategoryByName(name);
            if (cat != null)
            {
                isTaken = true;
                throw new UserException("Du har redan en Kategori med detta namnet");

            }
            else
            {
                isTaken = false;
                return isTaken;
            }
        }
        catch (UserException ex)
        {

            MessageBox.Show(ex.Message, "Fel!");
        }
        return isTaken;
    }

    public static bool ItemsContainsAny(flow podcast)
    {
        bool itemHasAny = false;
        try
        {
            if (!podcast.items.Any())
            {
                throw new UserException("Podden har felskriven eller ingen item summary / titel. Kunde ej prenumerera");
            }
            else
            {
                itemHasAny = true;
                return itemHasAny;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Fel!");
        }
        return itemHasAny;
    }
}
}

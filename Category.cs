using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Category
    {
        //Local variables for <Catergory> class
        private int categoryID;
        private string categoryName;
        private int noProducts;
        ArrayList categoryProducts;

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //<Catergory> class constructor
        public void category(int inCategoryID, string inCategoryName, int inNoProducts)
        {
            categoryID = inCategoryID;
            categoryName = inCategoryName;
            noProducts = inNoProducts;
            categoryProducts = new ArrayList();
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //getter methods for <Catergory> class
        public int getCategoryID()
        {
            return categoryID;
        }

        public string getCategoryName()
        {
            return categoryName;
        }

        public int getNoProduct()
        {
            return noProducts;
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //setter methods for <Catergory> class
        public void setCategoryID(int inCategoryID)
        {
            try
            {
                categoryID = inCategoryID; //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Category IDs)");
            }
        }

        public void setCategoryName(string inCategoryName)
        {
            categoryName = inCategoryName;
        }

        public void setNoProducts(int inNoProducts)
        {
            try
            {
                noProducts = Convert.ToInt32(inNoProducts); //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Branch IDs)");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //add product to category
        public void addProduct(Product tempProduct)
        {
            categoryProducts.Add(tempProduct);
        }
    }
}

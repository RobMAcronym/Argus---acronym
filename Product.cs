using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Product
    {
        private int productID;
	    private string productTitle;
	    private string productDetails;
	    private string productImageSource;
	    private float productPrice;
	    private int productStockLevel;


        public void product(int inProductID, string inProductTitle, string inProductDetails,
                                string inProductImageSource, float inProductPrice, int inProductStockLevel)
        {
            productID = inProductID;
	        productTitle = inProductTitle;
	        productDetails = inProductDetails;
	        productImageSource = inProductImageSource;
	        productPrice = inProductPrice;
            productStockLevel = inProductStockLevel;
        }
        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //getter methods
        public int getProductID()
        {
            return productID;
        }

        public string getProductTitle()
        {
            return productTitle;
        }

        public string getProductDetails()
        {
            return productDetails;
        }

        public string getProductImageSource()

        {
            return productImageSource;
        }

        public float getProductPrice()
        {
            return productPrice;
        }

        public int getProductStockLevel()
        {
            return productStockLevel;
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        public void setProductID(int inProductID)
        {
            try
            {
                productID = Convert.ToInt32(inProductID); //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Product IDs)");
            }
        }

        public void setProductTitle(string inProductTitle)
        {
            productTitle = inProductTitle;
        }

        public void setProductDetails(string inProductDetails)
        {
            productDetails = inProductDetails;
        }

        public void setProductImageSource(string inProductImageSource)
        {
            productImageSource = inProductImageSource;
        }

        public void setProductPrice(float inProductPrice)
        {
            try
            {
                productPrice = Convert.ToInt32(inProductPrice); //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Price)");
            }
        }

        public void setProductStockLevel(int inProductStockLevel)
        {
            try
            {
                productStockLevel = Convert.ToInt32(inProductStockLevel); //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Stock Level)");
            }
        }               
    }
}

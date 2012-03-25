using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        //StreamReader FileReader = new StreamReader(location + "argus-SMALL.txt");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //READ FILE            
            //local variables
            int i;

            //set up StreamReader
            StreamReader reader = new StreamReader("argus-BIG.txt");
            while (reader.ReadLine() != null)
            {
                //create array to hold data values
                string[] branchData = new string[11];

                //get 11 lines of branch data file
                for (i = 0; i < 11; i++)
                {
                    branchData[i] = reader.ReadLine();
                }
                
                //new instance of Branch Class
                Branch tempBranch = new Branch();

                //set branch values from branchData array
                tempBranch.setBranchID(branchData[0]);
                tempBranch.setBranchNickname(branchData[1]);
                tempBranch.setBranchAddressNo(branchData[2]);
                tempBranch.setBranchAddressStreet(branchData[3]);
                tempBranch.setBranchAddressCity(branchData[4]);
                tempBranch.setBranchAddressCounty(branchData[5]);
                tempBranch.setBranchAddressPostCode(branchData[6]);
                tempBranch.setNearestBranch1(branchData[7]);
                tempBranch.setNearestBranch2(branchData[8]);
                tempBranch.setNearestBranch3(branchData[9]);
                tempBranch.setNoCategories(Convert.ToInt32(branchData[10]));

                //add branch to main arrayList
                tempBranch.addBranchToMainArgus(tempBranch);


                for (i = 0; i < Convert.ToInt32(tempBranch.getNoCategories()); i++)
                {
                    //create array to hold data values
                    string[] categoryData = new string[3];

                    //get 3 lines of category data file
                    for (i = 0; i < 3; i++)
                    {
                        categoryData[i] = reader.ReadLine();
                    }

                    //new instance of Category Class
                    Category tempCategory = new Category();

                    //set values
                    tempCategory.setCategoryID(Convert.ToInt32(categoryData[0])); //ERROR! reading the line below it should be
                    tempCategory.setCategoryName(categoryData[1]);
                    tempCategory.setNoProducts(Convert.ToInt32(categoryData[2]));

                    //add category to Categories in branch arrayList
                    tempBranch.addCategoryToBranch(tempCategory);

                    for (i = 0; i < Convert.ToInt32(tempCategory.getNoProduct()); i++)
                    {
                        //create array to hold data values
                        string[] productData = new string[6];

                        //get 6 lines of category data file
                        for (i = 0; i < 6; i++)
                        {
                            productData[i] = reader.ReadLine();
                        }

                        //new instance of Product Class
                        Product tempProduct = new Product();

                        //add values to temp product
                        tempProduct.setProductID(Convert.ToInt32(productData[0]));
                        tempProduct.setProductTitle(productData[1]);
                        tempProduct.setProductDetails(productData[2]);
                        tempProduct.setProductImageSource(productData[3]);
                        tempProduct.setProductPrice(Convert.ToSingle(productData[4]));
                        tempProduct.setProductStockLevel(Convert.ToInt32(productData[5]));

                        //add product to productsincategory arraylist
                        tempCategory.addProduct(tempProduct);
                    }
                }
            }
        }

        public bool BranchSigCheck(string data)
        {
            bool branchcount = false;
            string[] check = new string[3];

            int checkcount = 0;

            foreach (char c in data)
            {
                check[checkcount] = Convert.ToString(c);
            }

            if ((check[0] == "1") && (check[1] == "0") && (check[2] == "0")) branchcount = true;
            else branchcount = false;

            return branchcount;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMainBranch MainBranch = new frmMainBranch();
            MainBranch.Show();
            this.Hide();
        }

        private void txtBranchID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Branch
    {
        //Local Variables of <branch> class
        private string branchID;
        private string branchNickname;
        private string branchAddressNo;
        private string branchAddressStreet;
        private string branchAddressCity;
        private string branchAddressCounty;
        private string branchAddressPostCode;
        private string nearestBranch1;
        private string nearestBranch2;
        private string nearestBranch3;
        //int[] nearestBranches;
        private int noCategories;
        ArrayList branchCategories;

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //<branch> Constructor
        public void branch(string inBranchID, string inBranchNickname, string inBranchAddressNo, 
                            string inBranchAddressStreet, string inBranchAddressCity, string inBranchAddressCounty,
                                string inBranchAddressPostCode, string inNearestBranch1,
                                    string inNearestBranch2, string inNearestBranch3, int inNoCategories) 
        {
            branchID = inBranchID;
            branchNickname = inBranchNickname;
            branchAddressNo = inBranchAddressNo;
            branchAddressStreet = inBranchAddressStreet;
            branchAddressCity = inBranchAddressCity;
            branchAddressCounty = inBranchAddressCounty;
            branchAddressPostCode = inBranchAddressPostCode;
            nearestBranch1 = inNearestBranch1;
            nearestBranch2 = inNearestBranch2;
            nearestBranch3 = inNearestBranch3;
            //setNearestBranches(nearestBranch1, nearestBranch2, nearestBranch3);            
            setNoCategories(inNoCategories);

            branchCategories = new ArrayList();
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //<branch> class getter methods
        public string getBranchID()
        {
            return branchID;
        }

        public string getBranchAddressNo()
        {
            return branchAddressNo;
        }

        public string getBranchAddressStreet()
        {
            return branchAddressStreet;
        }

        public string getBranchAddressCity()
        {
            return branchAddressCity;
        }

        public string getBranchAddressCounty()
        {
            return branchAddressCounty;
        }

        public string getBranchAddressPostCode()
        {
            return branchAddressPostCode;
        }

        //getter method for array of closest branch ids
        /*public int[] getNearestBranches()
        {
            return nearestBranches;
        }*/

        public string getNearestBranch1()
        {
            return nearestBranch1;
        }

        public string getNearestBranch2()
        {
            return nearestBranch2;
        }

        public string getNearestBranch3()
        {
            return nearestBranch3;
        }

        public int getNoCategories()
        {
            return noCategories;
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //<branch> class setter methods
        public void setBranchID(string inBranchID)
        {
            try
            {
                branchID = inBranchID; //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Branch IDs)");
            }
        }

        public void setBranchNickname(string inBranchNickname)
        {
            branchNickname = inBranchNickname;
        }

        public void setBranchAddressNo(string inBranchAddressNo)
        {
            branchAddressNo = inBranchAddressNo;
        }

        public void setBranchAddressStreet(string inBranchAddressStreet)
        {
            branchAddressStreet = inBranchAddressStreet;
        }

        public void setBranchAddressCity(string inBranchAddressCity)
        {
            branchAddressCity = inBranchAddressCity;
        }

        public void setBranchAddressCounty(string inBranchAddressCounty)
        {
            branchAddressCounty = inBranchAddressCounty;
        }

        public void setBranchAddressPostCode(string inBranchAddressPostCode)
        {
            branchAddressPostCode = inBranchAddressPostCode;
        }

        public void setNearestBranch1(string inNearestBranch1)
        {
            try
            {
                nearestBranch1 = inNearestBranch1; //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Branch IDs)");
            }
        }

        public void setNearestBranch2(string inNearestBranch2)
        {
            try
            {
                nearestBranch2 = inNearestBranch2; //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Branch IDs)");
            }
        }

        public void setNearestBranch3(string inNearestBranch3)
        {
            try
            {
                nearestBranch3 = inNearestBranch3; //convert local variable to global variable, and save it
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for Branch IDs)");
            }
        }

        //setter method for array of get nearest branch ids
        /*public void setNearestBranches(int[] inNearestBranches)
        {
            inNearestBranches[0] = 

        }*/

        public void setNoCategories(int inNoCategories)
        {
            try
            {
                noCategories = Convert.ToInt32(inNoCategories);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: " + e.Message + " please enter a valid integer (for number of categories)");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //Add branch to main array of branches
        public void addBranchToMainArgus(Branch tempBranch)
        {
            frmMainBranch mainArray = new frmMainBranch();
            mainArray.mainArgus.Add(tempBranch);
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        //Add category to branch
        public void addCategoryToBranch(Category tempCategory)
        {
            branchCategories.Add(tempCategory);
        }
    }
}

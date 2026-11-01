//Channel Caldwell
//Program 3
//Due: March 27, 2025
//CIS 199-50
//This program allows a user to select the consultant they want to use, business name and the contract length
//The program then outputs the contract cost by using the arrays to search and find the correct associated information
/*Analysis Questions:
 * 1) An off by one error in relation to arrays is when you forget that the first element in an array is 0. It's easy to accidentally 
 * create an off by one error by using <= instead of < in our loops.
 * 2) We make arrays because they allow you to store multiple values in a single variable and then you can call 
 * that specific value that you need. This allows us to access data in a more orginized way and keeps data for other values.
 * 3)An initializer list is the list of values provided for an array. 
 * 4)foreach is a read only statement so it would be used to extract values from an array. This loop is concise, quick, 
 * and you're not risking changing anything in the array.  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3Spring2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CostCalculatorLbl_Click(object sender, EventArgs e)
        {

        }

        private void CalcBttn_Click(object sender, EventArgs e)
        {
            double contractLength;//The input contact length
            bool found = false;//bool is set to false
            double price = 0;//will compute the final cost
            int selectedConsultant;//consultant that is selected in the combo box
            int selectedBusiness;//business that is selected in the combo box

            string[] consultantName = { "John Jones", "Sally Sue", "Billy Bob", "Betty Ballinger" };//consultant name array
            double[] consultantDiscountRate = { 0.30, 0.20, 0.12, 0.05 };//discount rate to go with the selected consultannt

            string[] businessName = { "John's Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" };//business name name array
            double[] contractPriceRate = { 500, 489, 412, 350, 325, 279 };//contract price to go with the selected business

            int[] contractRangeYears = { 0, 2, 5, 8 };//range of contract years showing the lower limit
            int[] additionalSavings = { 0, 30, 40, 50 };//additional savings for the range contract year selected

            if (ConsultantNameComboBox.SelectedIndex >= 0)//making sure a selection is made in the combo box 
            {
                selectedConsultant = ConsultantNameComboBox.SelectedIndex;//consultant that is selected from the combo box

                if (BusinessNameComboBox.SelectedIndex >= 0)//making sure a selection is made in the 2nd combo box 
                {
                    selectedBusiness = BusinessNameComboBox.SelectedIndex;//business that is selected from the combo box

                    if (double.TryParse(InputContractLengthTxt.Text, out contractLength) && (contractLength >= 0))//making sure a positive numebr is entered
                    {
                        for (int x = 0; x < consultantName.Length; ++x)//going through the array for the consultant picked until found
                        {

                            for (int i = 0; i < businessName.Length; ++i)////going through the array for the business picked until found
                            {
                                for (int y = 0; y < contractRangeYears.Length && !found; ++y)//going through the array for contact length input

                                {
                                    int index = contractRangeYears.Length - 1;//starting from the upper limit in the contract range and going down

                                      while (index >= 0 && contractLength < contractRangeYears[index])
                                        --index;
                                   
                                   
                                    if (selectedBusiness == i && selectedConsultant == x)//if the values are found in the arrays
                                    
                                      found = true;
                                     
                                    if (found)//if all values are found in the arrays

                                    {  price = contractPriceRate[i] - (consultantDiscountRate[x] * contractPriceRate[i]) - (additionalSavings[index]);//formula for the calculator pulling from the array the values input
                                     
                                       OutputContractCostLbl.Text = $"{price:C}";//output value in US dollars 
                                    }                                 
                                  }

                               }

                            }
                        }
                    else MessageBox.Show("Please enter a valid number for contract years!");//shows a message that the contract length entered is not valid
                 }
                else MessageBox.Show("Please select a valid business name!");//message box to select a valid business
              }
            else MessageBox.Show("Please select a valid consultant name!");//message box to select a valid consultant
        }

        private void OutputContractCostLbl_Click(object sender, EventArgs e)
        {

        }
    }
}


     
    


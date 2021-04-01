using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total; //This is the number that is updated throughout as the final price

        //============================================================================================================================================
        //NOTE TO ANYONE ELSE: I have added comments to the different sections so you know what they do and what the other parts of that section mean.
        //============================================================================================================================================

        private void checkBox6_CheckedChanged(object sender, EventArgs e) //TOMATOES OPTION
        {            
            if (checkBox6.Checked) //Is the tomato option ticked?
            {
                YourOrder.Items.Add("Tomatoes"); //Add Tomatoes to the order list
                total = total + 0.50; //Add the price from the tomatoes
                label9.Text = total.ToString(); //Update the label
                Console.WriteLine("Tomotoes option has been checked"); //Output to console.
            }

            else
            {
                YourOrder.Items.Remove("Tomatoes"); //Remove Tomatoes from the order list
                total = total - 0.50; //Deduct the price of the tomatoes
                label9.Text = total.ToString(); //Update the label
                Console.WriteLine("Tomotoes option has been unchecked"); //Output to console.
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) //HAM
        {
            if (checkBox5.Checked) //Is the ham option ticked?
            {
                YourOrder.Items.Add("Ham"); //Add Ham to the order list
                total = total + 0.50; 
                label9.Text = total.ToString();
                Console.WriteLine("Ham option has been checked");
            }

            else
            {
                YourOrder.Items.Remove("Ham");
                total = total - 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Ham option has been unchecked");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) //JALAPINO
        {
            if (checkBox4.Checked)
            {
                YourOrder.Items.Add("Jalapino");
                total = total + 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Jalapino option has been checked");
            }

            else
            {
                YourOrder.Items.Remove("Jalapino");
                total = total - 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Jalapino option has been unchecked");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) //EXTRA CHEESE
        {
            if (checkBox3.Checked)
            {
                YourOrder.Items.Add("Extra Cheese");
                total = total + 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Extra cheese option has been checked");
            }

            else
            {
                YourOrder.Items.Remove("Extra Cheese");
                total = total - 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Extra cheese option has been unchecked");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //PEPPERS
        {
            if (checkBox2.Checked)
            {
                YourOrder.Items.Add("Peppers");
                total = total + 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Peppers option has been checked");
            }

            else
            {
                YourOrder.Items.Remove("Peppers");
                total = total - 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Peppers option has been unchecked");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //MUSHROOMS
        {
            if (checkBox1.Checked)
            {
                YourOrder.Items.Add("Mushrooms");
                total = total + 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Mushrooms option has been checked");
            }

            else
            {
                YourOrder.Items.Remove("Mushrooms");
                total = total - 0.50;
                label9.Text = total.ToString();
                Console.WriteLine("Mushrooms option has been unchecked");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //TYPE OF PIZZA
        {
            bool wantsNeapolitan = false; //Default boolean value since they have not picked otherwise
            bool wantsChicago = false; //Default boolean value since they have not picked otherwise
            bool wantsCalifornia = false; //Default boolean value since they have not picked otherwise
            bool wantsGreek = false; //Default boolean value since they have not picked otherwise
            bool wantsSicilian = false; //Default boolean value since they have not picked otherwise
            bool wantsDetroit = false; //Default boolean value since they have not picked otherwise

            if (comboBox1.SelectedItem is "Neapolitan" == true) //Did the user select "Neapolitan" in the combobox?
            {
                
                label6.Text = "4.00"; //Update the Type of Pizza price box
                Console.WriteLine("Neapolitan option has been selected"); //Output to console
                YourOrder.Items.Remove("Detroit Type"); //Remove any other orders
                YourOrder.Items.Remove("Chicago Type"); //Remove any other orders
                YourOrder.Items.Remove("Greek Type"); //Remove any other orders
                YourOrder.Items.Remove("California Type"); //Remove any other orders
                YourOrder.Items.Remove("Sicilian Type"); //Remove any other orders

                YourOrder.Items.Add("Neapolitan Type"); //Add this type of pizza to the other

                wantsNeapolitan = true; //Set this type's pizza to true
                wantsChicago = false; //Ensure others are set to false
                wantsCalifornia = false; //Ensure others are set to false
                wantsGreek = false; //Ensure others are set to false
                wantsSicilian = false; //Ensure others are set to false
                wantsDetroit = false; //Ensure others are set to false
                Console.WriteLine("Neapolitan variable set to true"); //Output to console

            }          
            

            if (comboBox1.SelectedItem is "Chicago" == true)
            {
                
                label6.Text = "2.50";
                Console.WriteLine("Chicago option has been selected");
                YourOrder.Items.Remove("Detroit Type");
                YourOrder.Items.Remove("Neapolitan Type");
                YourOrder.Items.Remove("Greek Type");
                YourOrder.Items.Remove("California Type");
                YourOrder.Items.Remove("Sicilian Type");

                YourOrder.Items.Add("Chicago Type");

                wantsChicago = true;
                wantsNeapolitan = false;
                wantsCalifornia = false;
                wantsGreek = false;
                wantsSicilian = false;
                wantsDetroit = false;
                Console.WriteLine("Chicago variable set to true");

            }

            if (comboBox1.SelectedItem is "California")
            {
                label6.Text = "6.00";
                Console.WriteLine("California option has been selected");
                YourOrder.Items.Remove("Detroit Type");
                YourOrder.Items.Remove("Neapolitan Type");
                YourOrder.Items.Remove("Chicago Type");
                YourOrder.Items.Remove("Greek Type");
                YourOrder.Items.Remove("Sicilian Type");

                YourOrder.Items.Add("California Type");

                wantsCalifornia = true;
                Console.WriteLine("California variable set to true");
            }

            if (comboBox1.SelectedItem is "Greek")
            {
                label6.Text = "2.25";
                Console.WriteLine("Greek option has been selected");
                YourOrder.Items.Remove("Detroit Type");
                YourOrder.Items.Remove("Neapolitan Type");
                YourOrder.Items.Remove("Chicago Type");
                YourOrder.Items.Remove("California Type");
                YourOrder.Items.Remove("Sicilian Type");

                YourOrder.Items.Add("Greek Type");

                wantsGreek = true;
                Console.WriteLine("Greek variable set to true");
            }

            if (comboBox1.SelectedItem is "Sicilian")
            {
                label6.Text = "3.50";
                Console.WriteLine("Sicilian option has been selected");
                YourOrder.Items.Remove("Detroit Type");
                YourOrder.Items.Remove("Neapolitan Type");
                YourOrder.Items.Remove("Chicago Type");
                YourOrder.Items.Remove("Greek Type");
                YourOrder.Items.Remove("California Type");

                YourOrder.Items.Add("Sicilian Type");

                wantsSicilian = true;
                Console.WriteLine("Sicilian variable set to true");
            }

            if (comboBox1.SelectedItem is "Detroit")
            {
                label6.Text = "4.20";
                Console.WriteLine("Detroit option has been selected");
                YourOrder.Items.Remove("Neapolitan Type");
                YourOrder.Items.Remove("Chicago Type");
                YourOrder.Items.Remove("Greek Type");
                YourOrder.Items.Remove("California Type");
                YourOrder.Items.Remove("Sicilian Type");

                YourOrder.Items.Add("Detroit Type");

                wantsDetroit = true;
                Console.WriteLine("Detroit variable set to true");
            }


            if (wantsNeapolitan == true && comboBox1.SelectedItem is "Neapolitan" == true) //Neapolitan
            { //Is the option been selected and is the combobox selected?
                total = total + 4; //Add 4 to the total order
                label9.Text = total.ToString(); //Update the label
                Console.WriteLine("Neapolitan - Added 4 to the order"); //Output to console
            }

            else if (wantsNeapolitan == false && comboBox1.SelectedItem is "Neapolitan" == false)
            { //Otherwise if the option is false and the combobox is not selected then execute the following code
                total = total - 4; //Remove 4 from the total order
                label9.Text = total.ToString(); //Update the label
                Console.WriteLine("Neapolitan -Removed 4 from the order"); //Output to console
            }


            if (wantsChicago == true && comboBox1.SelectedItem is "Chicago" == true) //Chicago
            {
                total = total + 2.5;
                label9.Text = total.ToString();
                Console.WriteLine("Chicago - Added 2.5 to the order");
            }

            else if (wantsChicago == false && comboBox1.SelectedItem is "Chicago" == false)
            {
                total = total - 2.5;
                label9.Text = total.ToString();
                Console.WriteLine("Chicago - Removed 2.5 from the order");
            }


            if (wantsCalifornia == true) //California
            { //This still needs to be updated but will be done when a fix for the other two is found
                total = total + 6;
                label9.Text = total.ToString();
                Console.WriteLine("California - Added 6 to the order");
            }

            else
            {
                total = total - 6;
                label9.Text = total.ToString();
                Console.WriteLine("California - Removed 6 from the order");
            }


            if (wantsGreek == true) //Greek
            {
                total = total + 2.25;
                label9.Text = total.ToString();
                Console.WriteLine("Greek - Added 2.25 to the order");
            }

            else
            {
                total = total - 2.25;
                label9.Text = total.ToString();
                Console.WriteLine("Greek - Removed 2.25 from the order");
            }


            if (wantsSicilian == true) //Sicilian
            {
                total = total + 3.50;
                label9.Text = total.ToString();
                Console.WriteLine("Sicilian - Added 3.5 to the order");
            }

            else
            {
                total = total - 3.50;
                label9.Text = total.ToString();
                Console.WriteLine("Sicilian - Removed 3.5 from the order");
            }


            if (wantsDetroit == true) //Detroit
            {
                total = total + 4.20;
                label9.Text = total.ToString();
                Console.WriteLine("Detroit - Added 4.2 to the order");
            }

            else
            {
                total = total - 4.20;
                label9.Text = total.ToString();
                Console.WriteLine("Detroit - Removed 4.2 to the order");
            }

        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) //BASE OF PIZZA
        { //This code is exectuted when the combobox slected index is changed
            if (comboBox3.SelectedItem is "Thick") //If Thick pizza is selected then execute
            {
                label5.Text = "3.00"; //Update the base of pizza price label
                YourOrder.Items.Remove("Thin Pizza"); //Remove the other order from the list in case it is on there
                YourOrder.Items.Add("Thick Pizza"); //Add this base of pizza to the order list
                Console.WriteLine("Thick pizza added to order"); //Output to console
            }

            if (comboBox3.SelectedItem is "Thin")
            {
                label5.Text = "1.50";
                YourOrder.Items.Remove("Thick Pizza");
                YourOrder.Items.Add("Thin Pizza");
                Console.WriteLine("Thin pizza added to order");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //SIZE OF PIZZA
        { //This code will be executed when the size of pizza combo box is updated
            if (comboBox2.SelectedItem is "Large") //Did the user select the Large option?
            {
                label4.Text = "4.00"; //Update the size of pizza price label
                YourOrder.Items.Remove("Medium Pizza"); //Remove other orders
                YourOrder.Items.Remove("Small Pizza"); //Remove other orders
                YourOrder.Items.Add("Large Pizza"); //Add this size of pizza to the order
                Console.WriteLine("Large pizza added to order"); //Output to console
            }


            if (comboBox2.SelectedItem is "Medium")
            {
                label4.Text = "2.50";
                YourOrder.Items.Remove("Large Pizza");
                YourOrder.Items.Remove("Small Pizza");
                YourOrder.Items.Add("Medium Pizza");
                Console.WriteLine("Medium pizza added to order");
            }


            if (comboBox2.SelectedItem is "Small")
            {
                label4.Text = "1.20";
                YourOrder.Items.Remove("Medium Pizza");
                YourOrder.Items.Remove("Large Pizza");
                YourOrder.Items.Add("Small Pizza");
                Console.WriteLine("Small pizza added to order");
            }
        }

        private void label4_Click(object sender, EventArgs e) //SIZE OF PIZZA COST
        {
            
        }

        private void label5_Click(object sender, EventArgs e) //BASE OF PIZZA COST
        {

        }

        private void label6_Click(object sender, EventArgs e) //TYPE OF PIZZA COST
        {

        }

        

        private void YourOrder_SelectedIndexChanged(object sender, EventArgs e) //LIST OF ORDER
        {
            
            
        }


      
        private void label9_Click(object sender, EventArgs e) //TOTAL COST
        {
            
        }

       
    }
}

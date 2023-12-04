using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG521__FA3_Caitlin_Hermanus_20232198
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //User input textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Error Handling
            try
            {

            }
            catch (FormatException)
            {
                //saves to ErrorMessage File file
                File.Create(@"C:\Users\Caitlin\source\repos\PRG521__FA3_Caitlin_Hermanus_20232198\ErrorMessage.txt").Close();
                {
                    using (StreamWriter swError = File.AppendText(@"C:\Users\Caitlin\source\repos\PRG521__FA3_Caitlin_Hermanus_20232198\ErrorMessage.txt"))
                    {
                        swError.WriteLine(MessageBox.Show("Enter numbers only!"));
                        swError.WriteLine("Enter numbers only!");
                    }

                }
                
            }
           
        }

        //Submit button
        //fix file saving
        private void button1_Click(object sender, EventArgs e)
        {
            //Error Handling
            try
            {
                //calculating the tax
                double taxAmount = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(numericUpDown1.Value) / 100;
                double total = Convert.ToDouble(textBox1.Text) + taxAmount;

                //display the message
                MessageBox.Show($"Tax on ${textBox1.Text} at {numericUpDown1.Value}% is ${taxAmount} \n The total is ${total}");

                //saves to TaxCalucation file
                File.Create(@"C:\Users\Caitlin\source\repos\PRG521__FA3_Caitlin_Hermanus_20232198\TaxCalculation.txt").Close();
                {

                    using (StreamWriter swTotal = File.AppendText(@"C:\Users\Caitlin\source\repos\PRG521__FA3_Caitlin_Hermanus_20232198\TaxCalculation.txt"))

                        swTotal.WriteLine($"Tax on ${textBox1.Text} at {numericUpDown1.Value}% is ${taxAmount} \n The total is ${total}");
                }
            }
            catch (FormatException)
            {
                //saves to ErrorMessage file
                File.Create(@"C:\Users\Caitlin\source\repos\PRG521__FA3_Caitlin_Hermanus_20232198\ErrorMessage.txt").Close();
                {
                    using (StreamWriter swErrorTotal = File.AppendText(@"C:\Users\Caitlin\source\repos\PRG521__FA3_Caitlin_Hermanus_20232198\ErrorMessage.txt"))
                    {

                        swErrorTotal.WriteLine(MessageBox.Show("Error, file did not save"));
                        swErrorTotal.WriteLine("Error, file did not save");
                    }
                }
            }
        }

        //Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            //this clears the use input textbox
            textBox1.Clear();
        }

        //Exit button
        private void button3_Click(object sender, EventArgs e)
        {
            //this exits the whole system
            this.Close();
        }

        //Tax Option
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Error Handling
            try
            {
                numericUpDown1.Maximum = 50000;
                numericUpDown1.Minimum = 0;
            }
            catch (FormatException)
            {
                //saves to Errormessage file
                File.Create(@"C:\Users\Caitlin\source\repos\PRG521__FA3_Caitlin_Hermanus_20232198\ErrorMessage.txt").Close();
                using (StreamWriter swError = File.AppendText(@"C:\Users\Caitlin\source\repos\PRG521__FA3_Caitlin_Hermanus_20232198\ErrorMessage.txt"))
                {         
                    swError.WriteLine(MessageBox.Show("This connaot be converted to int"));
                    swError.WriteLine("This connaot be converted to int");
                }
            }
        }

        //Select Amount Label
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Tax Amount Label
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

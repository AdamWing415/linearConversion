using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linearConversion
{
    public partial class Form1 : Form
    {
        string state;
        public Form1()
        {
            InitializeComponent();
        }

        private void inchesButton_Click(object sender, EventArgs e)
        {
            //changes button color to show which option the user has selected
            inchesButton.BackColor = Color.Green;
            feetButton.BackColor = Color.DarkGray;
            yardButton.BackColor = Color.DarkGray;
            mileButton.BackColor = Color.DarkGray;

            //sets the state of the program to reflect the user's choice
            state = "inch";
            Refresh();

        }

        private void feetButton_Click(object sender, EventArgs e)
        {
            //changes button color to show which option the user has selected
            feetButton.BackColor = Color.Green;
            inchesButton.BackColor = Color.DarkGray;
            yardButton.BackColor = Color.DarkGray;
            mileButton.BackColor = Color.DarkGray;

            //sets the state of the program to reflect the user's choice
            state = "feet";
            Refresh();
        }

        private void yardButton_Click(object sender, EventArgs e)
        {   
            //changes button color to show which option the user has selected
            yardButton.BackColor = Color.Green;
            feetButton.BackColor = Color.DarkGray;
            inchesButton.BackColor = Color.DarkGray;
            mileButton.BackColor = Color.DarkGray;

            //sets the state of the program to reflect the user's choice
            state = "yard";
            Refresh();
        }

        private void mileButton_Click(object sender, EventArgs e)
        {
            //changes button color to show which option the user has selected
            mileButton.BackColor = Color.Green;
            feetButton.BackColor = Color.DarkGray;
            yardButton.BackColor = Color.DarkGray;
            inchesButton.BackColor = Color.DarkGray;

            //sets the state of the program to reflect the user's choice
            state = "mile";
            Refresh();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                //converts user input to a variable and initializes an answer variable
                int input = Convert.ToInt16(inputBox.Text);
                double answer;

                if (state == "inch") 
                {
                    //gets a return value and outputs it for inches to cm
                    answer = inchesToCm(input);
                    answerLabel.Text = $"{input} inches is equal to {answer.ToString("#.##")} cm";
                }

                else if (state == "feet") 
                {
                    //gets a return value and outputs it for feet to cm
                    answer = feetToCm(input);
                    answerLabel.Text = $"{input} feet is equal to {answer.ToString("#.##")} cm";
                }

                else if (state == "yard")
                {
                    //gets a return value and outputs it for yards to metres
                    answer = yardToMetre(input);
                    answerLabel.Text = $"{input} yards is equal to {answer.ToString("#.##")} m";
                }

                else if (state == "mile") 
                {
                    //gets a return value and outputs it for miles to km
                    answer = mileToKm(input);
                    answerLabel.Text = $"{input} miles is equal to {answer.ToString("#.##")} km";
                }

            }
            catch
            {
                //error message for if the user provides bad input
                answerLabel.Text = "Please input a valid numerical value.";
            }
        }

        /// <summary>
        /// converts inches to cm
        /// </summary>
        /// <param name="x"> carries user input in int form </param>
        /// <returns> double value of user input in centimetres </returns>
        public double inchesToCm (int x)
        {
            double converted = x * 2.54;
            return converted;
        }

        /// <summary>
        /// converts feet to cm
        /// </summary>
        /// <param name="x"> carries user input in int form </param>
        /// <returns> double value of user input in centimetres </returns>
        public double feetToCm(int x)
        {
            double converted = x * 30.48;
            return converted;
        }

        /// <summary>
        /// converts yards to metres
        /// </summary>
        /// <param name="x"> carries user input in int form </param>
        /// <returns> double value of user input in metres </returns>
        public double yardToMetre(int x)
        {
            double converted = x * 0.91;
            return converted;
        }

        /// <summary>
        /// converts miles to km
        /// </summary>
        /// <param name="x"> carries user input in int form </param>
        /// <returns> double value of user input in km </returns>
        public double mileToKm(int x)
        {
            double converted = x * 1.6;
            return converted;
        }
    }
}

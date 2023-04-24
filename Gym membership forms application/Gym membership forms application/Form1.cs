using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_membership_forms_application
{
    public partial class Form1 : Form
    {
        public bool Gender;
        public string tempString;
        public double Age;
        public double Weight;
        public double height;
        public string weightClass;
        public double KCal;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //getting all values in place
            if (!double.TryParse(textBox_Age.Text, out Age))
            {
                MessageBox.Show("Invalid age format");
                textBox_Age.Text = "";
                Age = 0;
                return;
            }
            if (Age < 101 && Age > 13)
            {
                if (!double.TryParse(textBox_Weight.Text, out Weight))
                {
                    MessageBox.Show("Invalid weight format");
                    textBox_Weight.Text = "";
                    Weight = 0;
                    return;
                }
                if (Weight > 29 && Weight < 251)
                {
                    if (!double.TryParse(textBox_Height.Text, out height))
                    {
                        MessageBox.Show("Invalid height format");
                        textBox_Height.Text = "";
                        height = 0;
                        return;
                    }
                    if (height >= 120 && height <= 210)
                    {
                        //BMR and BMI Calculations
                        double heightMetres = height / 100;
                        double BMI = Math.Round(Weight / (heightMetres * heightMetres),1);
                        if (BMI < 18.5)
                        {
                            weightClass = "Underweight";
                        }
                        else if (BMI >= 18.5 && BMI < 24.9)
                        {
                            weightClass = "Normal Weight";
                        }
                        else if (BMI > 25 && BMI < 29.9)
                        {
                            weightClass = "Overweight";
                        }
                        else if (BMI >= 30)
                        {
                            weightClass = "Obese";
                        }
                        label_Output_WC.Text = weightClass;
                        label_Output_TargetBMI.Text = "22";
                        label_Output_BMI.Text = Math.Round(BMI, 1).ToString();

                        if (radioButton_Female.Checked == true)
                        {
                            double BMR = 47.593 + (9.247 * Weight) + (3.098 * height) - (4.330 * Age);
                            label_Output_BMR.Text = Math.Round(BMR, 2).ToString();
                            if (radioButton_NoExcersise.Checked == true)
                            {
                                KCal = BMR * 1.2;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                            else if (radioButton_LightExersise.Checked == true)
                            {
                                KCal = BMR * 1.375;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                            else if (radioButton_ModerateExersise.Checked == true)
                            {
                                KCal = BMR * 1.55;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                            else if (radioButton_HeavyExersise.Checked == true)
                            {
                                KCal = BMR * 1.725;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                            else if (radioButton_VHeavyExersise.Checked == true)
                            {
                                KCal = BMR * 1.9;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                        }
                        if (radioButton_Male.Checked == true)
                        {
                            double BMR = 88.362 + (13.397 * Weight) + (4.799 * height) - (5.677 * Age);
                            label_Output_BMR.Text = Math.Round(BMR, 2).ToString();
                            if (radioButton_NoExcersise.Checked == true)
                            {
                                KCal = BMR * 1.2;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                            if (radioButton_LightExersise.Checked == true)
                            {
                                KCal = BMR * 1.375;
                                label_OutputKCal.Text = Math.Round(KCal).ToString();
                            }
                            if (radioButton_ModerateExersise.Checked == true)
                            {
                                KCal = BMR * 1.55;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                            if (radioButton_HeavyExersise.Checked == true)
                            {
                                KCal = BMR * 1.725;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                            if (radioButton_VHeavyExersise.Checked == true)
                            {
                                KCal = BMR * 1.9;
                                label_OutputKCal.Text = Math.Round(KCal, 0).ToString();
                            }
                        }
                    }
                    else
                    {
                        textBox_Height.Text = "";
                        if (height < 120)
                        {
                            MessageBox.Show("You are too short");
                            Weight = 0;
                            Age = 0;
                            height = 0;
                        }
                        else if (height > 210)
                        {
                            MessageBox.Show("You are too tall");
                            Weight = 0;
                            Age = 0;
                            height = 0;
                        }
                    }
                }
                else
                {
                    textBox_Weight.Text = "";
                    if (Weight < 30)
                    {
                        MessageBox.Show("You are too light");
                        Weight = 0;
                        Age = 0;
                    }
                    else if (Weight > 250)
                    {
                        MessageBox.Show("You are too heavy");
                        Weight = 0;
                        Age = 0;
                    }
                }
            }
            else
            {
                textBox_Age.Text = "";
                if (Age < 14)
                {
                    MessageBox.Show("Your age is too young.");
                    Age = 0;
                }
                else if (Age > 100)
                {
                    MessageBox.Show("You are much too old");
                    Age = 0;
                }
            }
        }
    }
}
//need to do range checks which work when inputting a letter along with numbers - feedback
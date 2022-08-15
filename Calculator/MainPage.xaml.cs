using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        string actionStr = "";
        public MainPage()
        {
            InitializeComponent();
        }

        private  void resultBtn_Clicked(object sender, EventArgs e)
        {
             ShowResult();
        }

        private void sevenBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("7");
        }

        private void eightBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("8");
        }

        private void nineBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("9");
        }

       
        private void fourBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("4");
        }

        private void fiveBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("5");
        }

        private void sixBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("6");
        }

        private void byBtn_Clicked(object sender, EventArgs e)
        {
            if (actionStr == "")
            {
                actionStr = "*";
                ActionPressed();
            }
            else
            {
                ActionPressed();
                actionStr = "*";
            }
        }

        private void oneBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("1");
        }

        private void twoBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("2");
        }

        private void divideBtn_Clicked(object sender, EventArgs e)
        {
            if (actionStr == "")
            {
                actionStr = "/";
                ActionPressed();
            }
            else
            {
                ActionPressed();
                actionStr = "/";
            }
        }

        private void threeBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("3");
        }

        private void minusBtn_Clicked(object sender, EventArgs e)
        {
            if (actionStr == "")
            {
                actionStr = "-";
                ActionPressed();
            }
            else
            {
                ActionPressed();
                actionStr = "-";
            }
        }

        private void clearBtn_Clicked(object sender, EventArgs e)
        {
            currentDigit.Text = "0";
            lastDigit.Text = "0";
        }

        private void zeroBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit("0");
        }

        private void dotBtn_Clicked(object sender, EventArgs e)
        {
            CheckDigit(".");
        }

        private  void plusBtn_Clicked(object sender, EventArgs e)
        {

            if (actionStr == "")
            {
                actionStr = "+";
                ActionPressed();
            }
            else
            {
                ActionPressed();
                actionStr = "+";
            }
            
        }

        private void CheckDigit(string newDigit)
        {
            if(currentDigit.Text == "0")
            {
                currentDigit.Text = newDigit;
            }
            else
            {
                currentDigit.Text += newDigit;
            }
        }

        private void ShowResult()
        {
            decimal firstNumber = Convert.ToDecimal(lastDigit.Text);
            decimal secondtNumber = Convert.ToDecimal(currentDigit.Text);
            decimal resul;

            switch (actionStr)
            {
                case "+":
                    resul = firstNumber + secondtNumber;
                    DispalyResult(resul);
                    break;
                case "-":
                    resul = firstNumber - secondtNumber;
                    DispalyResult(resul);
                    break;
                case "/":
                    if(secondtNumber == 0)
                    {
                        return;
                    }
                    resul = firstNumber / secondtNumber;
                    DispalyResult(resul);
                    break;
                case "*":
                    resul = firstNumber * secondtNumber;
                    DispalyResult(resul);
                    break;
                default:
                    break;
            }

            

        }

        private void DispalyResult(decimal resul)
        {
            lastDigit.Text = Convert.ToString(resul);
            currentDigit.Text = "0";
        }

        private void ActionPressed()
        {
            if(lastDigit.Text == "0")
            {
                lastDigit.Text = currentDigit.Text;
                currentDigit.Text = "0";
            }
            else
            {
                ShowResult();
            }
            
        }
    }
}

using System;
using System.Windows;


namespace WPF_Calc
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Calc(char sim, int num)
        {
            int firstNum;
            int secondNum;

            text6.Text = "=";

            if(text3.Text.Length > 0)
            {
                firstNum = Convert.ToInt32(text3.Text);
                text1.Text = firstNum.ToString();

            }

            if(text1.Text.Length == 0)
            {
                if (text4.Text.Length == 0)
                {
                    firstNum = num;
                    text1.Text = firstNum.ToString();
                    mainText.Text = "";
                }
                else if (text4.Text[0] == '-')
                {
                    firstNum = num * -1;
                    text1.Text = firstNum.ToString();
                    mainText.Text = "";
                    text4.Text.Remove(0);
                }
                else 
                {
                    mainText.Text = "";
                }

            }
            else
            {
                 firstNum = Convert.ToInt32(text1.Text);
                 secondNum = num;
                 text2.Text = secondNum.ToString();
                 checkSim(firstNum, secondNum);
                 mainText.Text = "";
                
            }
        }
        private void click_one(object sender, RoutedEventArgs e)
        {
            mainText.Text += "1";
        }

        private void click_two(object sender, RoutedEventArgs e)
        {
            mainText.Text += "2";
        }
        
        private void click_three(object sender, RoutedEventArgs e)
        {
            mainText.Text += "3";
        }

        private void click_four(object sender, RoutedEventArgs e)
        {
            mainText.Text += "4";
        }

        private void click_five(object sender, RoutedEventArgs e)
        {
            mainText.Text += "5";
        }

        private void click_six(object sender, RoutedEventArgs e)
        {
            mainText.Text += "6";
        }

        private void click_seven(object sender, RoutedEventArgs e)
        {
            mainText.Text += "7";
        }

        private void click_eghte(object sender, RoutedEventArgs e)
        {
            mainText.Text += "8";
        }

        private void click_nine( object sender, RoutedEventArgs e)
        {
            mainText.Text += "9";
        }
        private void click_zero(object sender, RoutedEventArgs e)
        {
            mainText.Text += "0";
        }

        private void click_plus(object sender, RoutedEventArgs e)
        { 
            char sim = '+';
            text5.Text = sim.ToString();
            if (mainText.Text.Length > 0)
            {
                int num = Convert.ToInt32(mainText.Text);
                Calc(sim, num);
            }
        }
        private void click_minus(object sender, RoutedEventArgs e)// добавить обработку отрицательных чисел
        {

            char sim = '-';
            text5.Text = sim.ToString();
            if (mainText.Text.Length == 0)
            {
                if (text4.Text != "-")
                {
                    text4.Text = "-";
                }
                else { text4.Text = ""; }
            }

            else 
            {
                int num = Convert.ToInt32(mainText.Text);
                Calc(sim, num); 
            }

        }

        private void click_division(object sender, RoutedEventArgs e)
        {
            char sim = '/';
            text5.Text = sim.ToString();
            if (mainText.Text.Length > 0)
            {
                int num = Convert.ToInt32(mainText.Text);
                Calc(sim, num);
            }
        }

        private void click_multiply(object sender, RoutedEventArgs e)
        {
            char sim = '*';
            text5.Text = sim.ToString();
            if (mainText.Text.Length > 0)
            {
                int num = Convert.ToInt32(mainText.Text);
                Calc(sim, num);
            }
        }

        private void click_equal(object sender, RoutedEventArgs e) // придумать обработку "равно"
        {
            if (mainText.Text.Length != 0 & text5.Text.Length != 0)
            {
                int num = Convert.ToInt32(mainText.Text);
                char sim = text5.Text[0];
                Calc(sim, num);
            }
            else
            {
                if (text2.Text.Length != 0)
                {
                    char sim = text5.Text[0];
                    int num = Convert.ToInt32(text2.Text);
                    Calc(sim, num);
                }
                else { }

            }
        }

        private void mainTextChanged(object sender, RoutedEventArgs e)
        {
            if (mainText.Text.Length > 0)
            {
                for (int i = 0; i <= mainText.Text.Length - 1; i++)
                {

                    if (i < 0)
                    { mainText.Text = "<0"; }
                    else 

                    

                    if (Char.IsDigit(mainText.Text[i]) != true) //| (mainText.Text[i].Equals('+') == true) | mainText.Text[i].Equals('-') | mainText.Text[i].Equals('*') | mainText.Text[i].Equals('\\')
                    {
                       mainText.Text = mainText.Text.Remove(i);
                    }
                }
            }
        }

        public void checkSim(int firstNum, int secondNum)
        {
            if(text5.Text[0] == '+')
            {
                text3.Text = (firstNum + secondNum).ToString();               
            }
            else 
            {
               if(text5.Text[0] == '-')
               {
                  text3.Text = (firstNum - secondNum).ToString();
               }
                else
                {
                    if(text5.Text[0] == '*')
                    {
                        text3.Text = (firstNum * secondNum).ToString();
                    }
                     else
                    {
                        if(text5.Text[0] == '/')
                            {
                            double dividend = firstNum; // Делимое
                            double divisor = secondNum; // Делитель
                            double quotient = dividend / divisor;   //Частное
                            text3.Text = quotient.ToString();
                            }
                    }
                }

                  }


        }

    }
}

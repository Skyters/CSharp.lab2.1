namespace CSharp.lab2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            enteringNumber.Text = Properties.Settings.Default.number.ToString();
        }

        public class Logic()
        {
            public static string Result(int number)
            {
                int rub = number / 100;
                int kop = number % 100;

                string rubWord;

                if (rub % 10 == 1 && rub % 100 != 11)
                {
                    rubWord = "рубль";
                }
                else if (rub % 10 >= 2 && rub % 10 <= 4)
                {
                    rubWord = "рубля";

                }
                else
                {
                    rubWord = "рублей";
                }

                string result = rub + " " + rubWord;

                if (kop > 0)
                {
                    string wordKop;

                    if (kop % 10 == 1 && kop % 100 != 11)
                    {
                        wordKop = "копейка";
                    }

                    else if (kop % 10 >= 2 && kop % 10 <= 4)
                    {
                        wordKop = "копейки";
                    }
                    else
                    {
                        wordKop = "копеек";
                    }

                    result += " " + kop + " " + wordKop;
                }
                else
                {
                    result += " " + "0 копеек";
                }

                return result;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int number;
            
            try
            {
                number = int.Parse(this.enteringNumber.Text);
                if (number > 9999)
                {
                    MessageBox.Show("Введите корректное число");
                    return;
                }
            }
            catch (FormatException) 
            {
                return;
            }
            
            Properties.Settings.Default.number = number;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.Result(number));
        }
    }
}

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

namespace EnumSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            //TossResult tossResult=TossResult.NA;

            //if (comboBox1.Text=="Tail")
            //{
            //     tossResult = Tossing(Coin.Tail);
            //}
            //else if (comboBox1.Text == "Head")
            //{
            //     tossResult = Tossing(Coin.Head);
            //}
            //this.Text = tossResult.ToString();

            //try
            //{
            //    int a = Convert.ToInt32(txtNumber.Text);
            //    this.Text = a.ToString();
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Invalid data enterd");

            //}
            //catch (OverflowException)
            //{
            //    MessageBox.Show("Long data enterd");

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Somethis went wrong");

            //}

            //try
            //{
            //    this.Text = File.ReadAllText(@"C:\Users\Akhil\Desktop\MyData.txt");
            //}
            //catch (FileNotFoundException)
            //{

            //    MessageBox.Show("File not found");
            //}
           
        }


        public TossResult Tossing(Coin coin)
        {
            Random random = new Random();
            random.Next(1, 2);
            int rndNumber= random.Next(1, 3);

            if (rndNumber==(int)coin)
            {
                return TossResult.Win;
            }
            else
            {
                return TossResult.Lose;
            }
        }

        public int Add()
        {
            return 1 + 5;
        }
    }
}

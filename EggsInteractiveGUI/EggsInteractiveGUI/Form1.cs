using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
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

        private void button1_Click(object sender, EventArgs e)
        {

            String[] numOfEggsInput = {textBox1.Text, textBox2.Text , textBox3.Text , textBox4.Text , textBox5.Text };
            int[] numOfEggs = new int[5];
            int sumOfEggs = 0; 
            for(int i = 0; i < numOfEggs.Length; i++)
            {
                numOfEggs[i] = Convert.ToInt32(numOfEggsInput[i]);
                sumOfEggs += numOfEggs[i];

            }

            

           
           
          


            int dozens = sumOfEggs / 12;
            int remainders = sumOfEggs % 12;
            String answer = sumOfEggs + " Eggs , which is: " + dozens + " dozens" + " and " + remainders + " eggs";
            

            label2.Text = "Total of: " + answer; 
            

          



        }
    }
}

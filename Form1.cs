
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiceRoller.Properties;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //BUTTON1

        private void button1_MouseDown(object sender, EventArgs e)
        {
            RollResult(1,3);
            button1.BackgroundImage = Resources._2_click;
        }
        private void button1_MouseUp(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources._2_hover;
        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources._2_hover;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources._2;

        }

        //BUTTON2

        private void button2_MouseDown(object sender, EventArgs e)
        {
            RollResult(1, 5);
            button2.BackgroundImage = Resources._4_click;
        }
        private void button2_MouseUp(object sender, EventArgs e)
        {
            button2.BackgroundImage = Resources._4_hover;
        }


        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Resources._4_hover;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources._4;

        }


        //BUTTON3

        private void button3_MouseDown(object sender, EventArgs e)
        {
            RollResult(1, 7);
            button3.BackgroundImage = Resources._6_click;
        }
        private void button3_MouseUp(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources._6_hover;
        }


        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources._6_hover;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Resources._6;

        }


        //BUTTON4

        private void button4_MouseDown(object sender, EventArgs e)
        {
            RollResult(1, 9);
            button4.BackgroundImage = Resources._8_click;
        }
        private void button4_MouseUp(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources._8_hover;
        }


        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources._8_hover;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources._8;

        }


        //BUTTON5

        private void button5_MouseDown(object sender, EventArgs e)
        {
            RollResult(1, 11);
            button5.BackgroundImage = Resources._10_click;
        }
        private void button5_MouseUp(object sender, EventArgs e)
        {
            button5.BackgroundImage = Resources._10_hover;
        }


        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = Resources._10_hover;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Resources._10;

        }

        //BUTTON6

        private void button6_MouseDown(object sender, EventArgs e)
        {
            RollResult(1, 13);
            button6.BackgroundImage = Resources._12_click;
        }
        private void button6_MouseUp(object sender, EventArgs e)
        {
            button6.BackgroundImage = Resources._12_hover;
        }


        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackgroundImage = Resources._12_hover;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = Resources._12;

        }

        //BUTTON7

        private void button7_MouseDown(object sender, EventArgs e)
        {
            RollResult(1, 21);
            button7.BackgroundImage = Resources._20_click;
        }
        private void button7_MouseUp(object sender, EventArgs e)
        {
            button7.BackgroundImage = Resources._20_hover;
        }


        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = Resources._20_hover;

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = Resources._20;

        }


        Random rnd = new Random();

        void RollResult(int min, int max)
        {
            int result = rnd.Next(min, max);
            lbl_result.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

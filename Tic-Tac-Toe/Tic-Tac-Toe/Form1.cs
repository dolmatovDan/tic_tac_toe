using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private Button[] arr;
        public Form1()
        {
            InitializeComponent();
            arr = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void click(Button btn)
        {
            btn.BackgroundImage = Properties.Resources.x2;
        }
        private void pc_click()
        {
            Random rnd = new Random();
            int numb = rnd.Next(0, 8);
            while (arr[numb].BackgroundImage == Properties.Resources.x2 || arr[numb].BackgroundImage == Properties.Resources.o)
            {
                numb = rnd.Next(0, 8);
            }
            arr[numb].BackgroundImage = Properties.Resources.o;
        }
        private void check()
        {
            int x = 0;
            string res = "";
            for (int i = 0; i < 2; i++)
            {
                if(arr[i * 3].BackgroundImage == Properties.Resources.x2 && arr[i * 3 + 1].BackgroundImage == Properties.Resources.x2 && arr[i * 3 + 2].BackgroundImage == Properties.Resources.x2)
                {
                    res = "Yes";
                }
            }
            //
            for (int i = 0; i < 2; i++)
            {
                if (arr[x].BackgroundImage == Properties.Resources.x2 && arr[i * 3 + x].BackgroundImage == Properties.Resources.x2 && arr[i * 3 + x].BackgroundImage == Properties.Resources.x2)
                {
                    res = "Yes";
                }
                x++;
            }
            //
            if (arr[0].BackgroundImage == Properties.Resources.x2 && arr[4].BackgroundImage == Properties.Resources.x2 && arr[8].BackgroundImage == Properties.Resources.x2)
            {
                res = "Yes";
            }
            else if (arr[2].BackgroundImage == Properties.Resources.x2 && arr[4].BackgroundImage == Properties.Resources.x2 && arr[6].BackgroundImage == Properties.Resources.x2)
            {
                res = "Yes";
            }
            //
            ////
            //////
            ///

            x = 0;
            for (int i = 0; i < 2; i++)
            {
                if (arr[i * 3].BackgroundImage == Properties.Resources.o && arr[i * 3 + 1].BackgroundImage == Properties.Resources.o && arr[i * 3 + 2].BackgroundImage == Properties.Resources.o)
                {
                    res = "No";
                }
            }
            //
            for (int i = 0; i < 2; i++)
            {
                if (arr[x].BackgroundImage == Properties.Resources.o && arr[i * 3 + x].BackgroundImage == Properties.Resources.o && arr[i * 3 + x].BackgroundImage == Properties.Resources.o)
                {
                    res = "No";
                }
                x++;
            }
            //
            if (arr[0].BackgroundImage == Properties.Resources.o && arr[4].BackgroundImage == Properties.Resources.o && arr[8].BackgroundImage == Properties.Resources.o)
            {
                res = "No";
            }
            else if (arr[2].BackgroundImage == Properties.Resources.o && arr[4].BackgroundImage == Properties.Resources.o && arr[6].BackgroundImage == Properties.Resources.o)
            {
                res = "No"; ;
            }
            if (res == "Yes")
            {
                label1.Text = "Ты выйграл!!!";
            }
            else if (res == "Yes")
            {
                label1.Text = "Ты проиграл(((";
            }
            else
            {
                label1.Text = "_____________";
            }
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (arr[0].BackgroundImage != Properties.Resources.x2 && arr[0].BackgroundImage != Properties.Resources.o)
            {
                click(arr[0]);
                check();
                pc_click();
                check();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arr[1].BackgroundImage != Properties.Resources.x2 && arr[1].BackgroundImage != Properties.Resources.o)
            {
                click(arr[1]);
                check();
                pc_click();
                check();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arr[2].BackgroundImage != Properties.Resources.x2 && arr[2].BackgroundImage != Properties.Resources.o)
            {
                click(arr[0]);
                check();
                pc_click();
                check();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arr[3].BackgroundImage != Properties.Resources.x2 && arr[3].BackgroundImage != Properties.Resources.o)
            {
                click(arr[3]);
                check();
                pc_click();
                check();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (arr[4].BackgroundImage != Properties.Resources.x2 && arr[4].BackgroundImage != Properties.Resources.o)
            {
                click(arr[4]);
                check();
                pc_click();
                check();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (arr[5].BackgroundImage != Properties.Resources.x2 && arr[5].BackgroundImage != Properties.Resources.o)
            {
                click(arr[5]);
                check();
                pc_click();
                check();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (arr[6].BackgroundImage != Properties.Resources.x2 && arr[6].BackgroundImage != Properties.Resources.o)
            {
                click(arr[6]);
                check();
                pc_click();
                check();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (arr[7].BackgroundImage != Properties.Resources.x2 && arr[7].BackgroundImage != Properties.Resources.o)
            {
                click(arr[7]);
                check();
                pc_click();
                check();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (arr[8].BackgroundImage != Properties.Resources.x2 && arr[8].BackgroundImage != Properties.Resources.o)
            {
                click(arr[8]);
                check();
                pc_click();
                check();
            }
        }
    }
}

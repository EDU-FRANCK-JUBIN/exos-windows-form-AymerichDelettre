using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApplication
{
    public partial class Form1 : Form
    {
        string queue1;
        string queue2;
        string opeText;
        bool ope;

        public Form1()
        {
            InitializeComponent();
            ope = false;
            queue1 = "";
            queue2 = "";
        }

        private void HandleOpe(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            opeText = btn.Text;
            lblHistory.Text += btn.Text;
            ope = true;
        }

        private void HandleCalcul(object sender, EventArgs e)
        {
            double result = 0;
            if (!String.IsNullOrEmpty(queue1) && !String.IsNullOrEmpty(queue2))
            {
                switch(opeText)
                {
                    case "+":
                        result = double.Parse(queue1) + double.Parse(queue2);
                        break;
                    case "-":
                        result = double.Parse(queue1) - double.Parse(queue2);
                        break;
                    case "*":
                        result = double.Parse(queue1) * double.Parse(queue2);
                        break;
                    case "/":
                        result = double.Parse(queue1) / double.Parse(queue2);
                        break;
                }
                lblResult.Text = result.ToString();
            }
        }

        private void handleUtils(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch(btn.Text)
            {
                case "CE":
                    if(!ope)
                    {
                        lblHistory.Text = lblHistory.Text.Substring(0, queue1.Length);
                        queue1 = "";
                    }
                    else
                    {
                        lblHistory.Text = lblHistory.Text.Substring(queue1.Length-1,queue2.Length);
                        queue2 = "";
                    }
                    break;
                case "C":
                    queue1 = "";
                    queue2 = "";
                    opeText = "";
                    ope = false;
                    lblResult.Text = "";
                    lblHistory.Text = "";
                    break;
            }
        }

            private void handleClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(!ope)
            {
                queue1 += btn.Text;
            }
            else
            {
                queue2 += btn.Text;
            }
            lblHistory.Text += btn.Text;
                
        }
    }
}

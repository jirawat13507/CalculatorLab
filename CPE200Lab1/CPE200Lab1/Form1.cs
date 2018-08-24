using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string num1 ;
        string num2 ;        
        float num3 ;
        
        int stage = 1;
        int stat = 0;
        int Plus ;
        int Minus;
        int Multiply ;
        int Divide;
        int d = 0;

        private void btnX_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (stage == 2)
            {
                lblDisplay.Text = "";
               
                d = 0;
                stage = 1;
            }
              
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text = lblDisplay.Text + btn.Text;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            lblDisplay.Text = "0";
            num2 = "0";
            

        }
        private void btnoperatre_Click(object sender, EventArgs e)
        {

            


        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Plus == 1)
            {

                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) + float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Plus = 0;

            }
            else if (Minus == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) - float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Minus = 0;
            }
            else if (Multiply == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) * float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Multiply = 0;
            }
            else if (Divide == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) / float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Divide = 0;
            }
           
            if (stage == 1)
            {
                num1 = lblDisplay.Text;              
                stage = 2;
                Plus = 1;
                stat = 0;
                
            }
            
            
            

            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Plus == 1)
            {

                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) + float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Plus = 0;

            }
            else if (Minus == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) - float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Minus = 0;
            }
            else if (Multiply == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) * float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Multiply = 0;
            }
            else if (Divide == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) / float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Divide = 0;
            }
           
            if (stage == 1)
            {
                num1 = lblDisplay.Text;
                stage = 2;
                Minus = 1;
                stat = 0;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (Plus == 1)
            {

                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) + float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Plus = 0;

            }
            else if (Minus == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) - float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Minus = 0;
            }
            else if (Multiply == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) * float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Multiply = 0;
            }
            else if (Divide == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) / float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Divide = 0;
            }
           
            if (stage == 1)
            {
                num1 = lblDisplay.Text;
                stage = 2;
                Multiply = 1;
                stat = 0;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (Plus == 1)
            {

                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) + float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Plus = 0;

            }
            else if (Minus == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) - float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Minus = 0;
            }
            else if (Multiply == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) * float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Multiply = 0;
            }
            else if (Divide == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) / float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Divide = 0;
            }
           
            if (stage == 1)
            {
                num1 = lblDisplay.Text;
                stage = 2;
                Divide = 1;
                stat = 0;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {   if (Plus == 1)
            {

                if (stat == 0) num2 = lblDisplay.Text;                
                num3 = float.Parse(num1) + float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Plus = 0;

            }
            else if(Minus == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) - float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Minus = 0;
            }
            else if (Multiply == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) * float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Multiply = 0;
            }
            else if(Divide == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;
                num3 = float.Parse(num1) / float.Parse(num2);
                num1 = Convert.ToString(num3);
                lblDisplay.Text = num1;
                stage = 1;
                stat = 1;
                Divide = 0;
            }

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            
            if (d == 0)
            {
                lblDisplay.Text = lblDisplay.Text + ".";
                d = 1;
            }

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (Plus == 1)
            {

                if (stat == 0) num2 = lblDisplay.Text;                
                num2 = Convert.ToString(float.Parse(num1) * float.Parse(num2) / 100);                
                lblDisplay.Text = num2;
                stage = 1;
                stat = 1;

            }
            else if (Minus == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;                
                num2 = Convert.ToString(float.Parse(num1) * float.Parse(num2) / 100);                
                lblDisplay.Text = num2;
                stage = 1;
                stat = 1;
            }
            else if (Multiply == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;               
                num2 = Convert.ToString(float.Parse(num2) / 100);                
                lblDisplay.Text = num2;
                stage = 1;
                stat = 1;
            }
            else if (Divide == 1)
            {
                if (stat == 0) num2 = lblDisplay.Text;               
                num2 = Convert.ToString(float.Parse(num2) / 100);                
                lblDisplay.Text = num2;
                stage = 1;
                stat = 1;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
              
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //lblDisplay;
        }
    }
}

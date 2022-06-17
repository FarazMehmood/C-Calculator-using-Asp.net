using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    string operand1="";
    string operand2="";
    decimal result;
    protected void Page_Load(object sender, EventArgs e)
    {
        lblerror.Text = "";

    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        if(Label1.Text=="0")
        {
            Label1.Text = "7";
        }

        else
        {
            Label1.Text = Label1.Text + "7";
        }

        form1.Attributes["class"] = "buttonn";

    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "8";
        }

        else
        {
            Label1.Text = Label1.Text + "8";
        }
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "9";
        }

        else
        {
            Label1.Text = Label1.Text + "9";
        }
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "4";
        }

        else
        {
            Label1.Text = Label1.Text + "4";
        }
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "5";
        }

        else
        {
            Label1.Text = Label1.Text + "5";
        }
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "6";
        }

        else
        {
            Label1.Text = Label1.Text + "6";
        }
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "3";
        }

        else
        {
            Label1.Text = Label1.Text + "3";
        }
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "2";
        }

        else
        {
            Label1.Text = Label1.Text + "2";
        }
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "1";
        }

        else
        {
            Label1.Text = Label1.Text + "1";
        }
    }

    protected void btn0_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "0";
        }

        else
        {
            Label1.Text = Label1.Text + "0";
        }
    }


    protected void btndecimal_Click(object sender, EventArgs e)
    {
        if(Label1.Text.Contains("."))
        {
            lblerror.Text = "Cant Include DECIMAL 2nd time in Same Value";
            return;
        }

        else if (Label1.Text.IndexOf(".") < 1 )
        {
            Label1.Text = Label1.Text + ".";
        }

        else
        {
            Label1.Text = Label1.Text + ".";
        }
    }

    protected void btnmod_Click(object sender, EventArgs e)
    {
        if (Label1.Text == "0")
        {
            Label1.Text = "%";
        }

        else
        {
            Label1.Text = Label1.Text + "%";
        }
    }

    protected void btnclear_Click(object sender, EventArgs e)
    {
        Label1.Text = btn0.Text;
        btn0.Enabled = true;
        btn1.Enabled = true;
        btn2.Enabled = true;
        btn3.Enabled = true;
        btn4.Enabled = true;
        btn6.Enabled = true;
        btn5.Enabled = true;
        btn7.Enabled = true;
        btn8.Enabled = true;
        btn9.Enabled = true;
        btnbackspace.Enabled = true;
        btndivide.Enabled = true;
        btnminus.Enabled = true;
        btnmultiply.Enabled = true;
        btnplus.Enabled = true;
        btnmod.Enabled = true;
        btndecimal.Enabled = true;

    }

    protected void btnplus_Click(object sender, EventArgs e)
    {

        if (Label1.Text.EndsWith("+") || Label1.Text.EndsWith("-") || Label1.Text.EndsWith("*") || Label1.Text.EndsWith("/") || Label1.Text.EndsWith("%"))
        {
            lblerror.Text = "cannot enter two operands side by side";
            return;
        }

        else
        {
            Label1.Text = Label1.Text + btnplus.Text;
        }

    }

    protected void btnminus_Click(object sender, EventArgs e)
    {
        if (Label1.Text.EndsWith("+") || Label1.Text.EndsWith("-") || Label1.Text.EndsWith("*") || Label1.Text.EndsWith("/") || Label1.Text.EndsWith("%"))
        {
            lblerror.Text = "cannot enter two operands side by side";
            return;
        }

        else
        {
            Label1.Text = Label1.Text + btnminus.Text;
        }
    }

    protected void btnmultiply_Click(object sender, EventArgs e)
    {
        if (Label1.Text.EndsWith("+") || Label1.Text.EndsWith("-") || Label1.Text.EndsWith("*") || Label1.Text.EndsWith("/") || Label1.Text.EndsWith("%"))
        {
            lblerror.Text = "cannot enter two operands side by side";
            return;
        }

        else
        {
            Label1.Text = Label1.Text + btnmultiply.Text;
        }
    }

    protected void btndivide_Click(object sender, EventArgs e)
    {
        if (Label1.Text.EndsWith("+") || Label1.Text.EndsWith("-") || Label1.Text.EndsWith("*") || Label1.Text.EndsWith("/") || Label1.Text.EndsWith("%"))
        {
            lblerror.Text = "cannot enter two operands side by side";
            return;
        }

        else
        {
            Label1.Text = Label1.Text + btndivide.Text;
        }
    }

    protected void btndone_Click(object sender, EventArgs e)
    {
        btntest1.Text = Label1.Text;
        btn0.Enabled = false;
        btn1.Enabled= false;
        btn2.Enabled= false;
        btn3.Enabled = false;
        btn4.Enabled= false;
        btn6.Enabled= false;
        btn5.Enabled = false;
        btn7.Enabled= false;
        btn8.Enabled= false;
        btn9.Enabled= false;
        btnbackspace.Enabled = false;
        btndivide.Enabled= false;
        btnminus.Enabled= false;
        btnmultiply.Enabled= false;
        btnplus.Enabled= false;
        btnmod.Enabled= false;
        btndecimal.Enabled= false;



        if (Label1.Text.EndsWith("+") || Label1.Text.EndsWith("-") || Label1.Text.EndsWith("*") || Label1.Text.EndsWith("*") || Label1.Text.EndsWith("%"))
        {
            lblerror.Text = "Invalid Operation!! , Unsufficient Operands";
            return;
        }

        if (Label1.Text.Contains("+"))
        {
            
            char[] seperator = { '+' };
            string[] str = Label1.Text.Split(seperator);

            foreach (string x in str)
            {
                if (operand1.Length==0)
                {
                    operand1 = x;
                }

                operand2 = x;

            }

            decimal v = Convert.ToDecimal(operand1) + Convert.ToDecimal(operand2);
            result = v;
            Label1.Text = Convert.ToString(result);
          
        }

        if (Label1.Text.Contains("-"))
        {

            char[] seperator = { '-' };
            string[] str = Label1.Text.Split(seperator);

            foreach (string x in str)
            {
                if (operand1.Length == 0)
                {
                    operand1 = x;
                    
                }

                operand2 = x;

            }

            result = Convert.ToDecimal(operand1) - Convert.ToDecimal(operand2);
            Label1.Text = Convert.ToString(result);
           
        }

        if (Label1.Text.Contains("*"))
        {

            char[] seperator = { '*' };
            string[] str = Label1.Text.Split(seperator);

            foreach (string x in str)
            {
                if (operand1.Length == 0)
                {
                    operand1 = x;
                }

                operand2 = x;

            }

            result = Convert.ToDecimal(operand1) * Convert.ToDecimal(operand2);
            Label1.Text = Convert.ToString(result);
            
        }

        if (Label1.Text.Contains("/"))
        {

            char[] seperator = { '/' };
            string[] str = Label1.Text.Split(seperator);

            foreach (string x in str)
            {
                if (operand1.Length == 0)
                {
                    operand1 = x;
                }

                operand2 = x;

            }

            result = Convert.ToDecimal(operand1) / Convert.ToDecimal(operand2);
            Label1.Text = Convert.ToString(result);

        }

        if (Label1.Text.Contains("%"))
        {

            char[] seperator = { '%' };
            string[] str = Label1.Text.Split(seperator);

            foreach (string x in str)
            {
                if (operand1.Length == 0)
                {
                    operand1 = x;
                }

                operand2 = x;

            }

            result = Convert.ToDecimal(operand1) % Convert.ToDecimal(operand2);
            Label1.Text = Convert.ToString(result);

        }
        btntest2.Text = Label1.Text;
    }

    protected void btnup_Click(object sender, EventArgs e)
    {
        Label1.Text = btntest1.Text;
    }

    protected void btndown_Click(object sender, EventArgs e)
    {
        Label1.Text = btntest2.Text;
    }

    protected void btnbackspace_Click(object sender, EventArgs e)
    {
     
       if (Label1.Text.Length > 0 && Label1.Text != "0")
        {
            Label1.Text = Label1.Text.Remove(Label1.Text.Length - 1);

            if(Label1.Text.Length==0)
            {
                Label1.Text = "0";
            }
            return;
        }
        
    }

    protected void btnred_Click1(object sender, EventArgs e)
    {
        form1.Style.Add("background-color", "red");
    }

    protected void btngreen_Click(object sender, EventArgs e)
    {
        form1.Style.Add("background-color", "green");
    }

    protected void btnblue_Click(object sender, EventArgs e)
    {
        form1.Style.Add("background-color", "blue");
    }

    protected void btnrevert_Click(object sender, EventArgs e)
    {
        form1.Style.Add("background-color", "lightgrey");
    }
}
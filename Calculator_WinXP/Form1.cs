using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinXP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
        }
        bool pointBool = false;
        string operator1 = "";
        bool operator1Bool = false;
        double a = 0;
        bool aBool = false;
        double b = 0;
        bool bBool = false;
        bool error = false;
        double c = 0;
        bool lastClickOnBinary = false;
        bool lastClickOnEqual = false;
        bool lastClickOnUnary = false;
        bool MBool = false;
        double M = 0;
        bool memoryError = false;

        private void Click_OnNumber(object sender, EventArgs e)
        {
            if (!error)
            {
                Button number = (Button)sender;

                /*            if (bBool)
                            {
                                textBox1.Text = "0,";
                                bChange = true;
                                bBool = false;
                            }
                            if (operator1Bool&&!bChange)
                            {
                                textBox1.Text = "0,";
                                bChange = true;
                            }
                            if (aBool&&!bBool) boolFirstInclude = true;*/

                /*            if (bBool)
                            {
                                textBox1.Text = "0,";
                            }*/

                if (lastClickOnBinary || lastClickOnUnary)
                {
                    textBox1.Text = "0,";
                    if (bBool && !lastClickOnEqual)
                    {
                        bBool = false;
                    }
                }
                if (lastClickOnEqual)
                {
                    textBox1.Text = "0,";
                    aBool = false;
                }
                lastClickOnBinary = false;
                lastClickOnEqual = false;
                lastClickOnUnary = false;
                if (textBox1.Text.IndexOf('E') == -1)
                {
                    if (((textBox1.Text.Length - textBox1.Text.IndexOf(',') < 11) && pointBool && (textBox1.Text.IndexOf(',') < 12)) || ((textBox1.Text.Length < 12) && !pointBool))
                    {
                        if ((textBox1.Text[0] != '0') && !pointBool)
                        {
                            string s = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                            textBox1.Text = s + number.Text + ",";
                        }
                        else
                        {
                            if (pointBool)
                            {
                                textBox1.Text = textBox1.Text + number.Text;
                            }
                            else if (textBox1.Text[0] == '0')
                            {
                                textBox1.Text = number.Text + ",";
                            }
                        }
                    }
                }
            }
        }

        private void signСhange_Click(object sender, EventArgs e)
        {
            if (!error)
            {
/*                if (lastClickOnBinary)
                {
                    textBox1.Text = "0,";
                    if (bBool && !lastClickOnEqual)
                    {
                        bBool = false;
                    }
                }*/
                if (bBool && lastClickOnUnary)
                {
                    bBool = false;
                }
                lastClickOnBinary = false;
                lastClickOnEqual = false;
                lastClickOnUnary = false;

                if (textBox1.Text != "0,")
                {
                    if (textBox1.Text[0] != '-')
                    {
                        textBox1.Text = "-" + textBox1.Text;
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text.Remove(0, 1);
                    }
                }
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                if (lastClickOnBinary || lastClickOnUnary||(textBox1.Text.IndexOf('E')!=-1))
                {
                    textBox1.Text = "0,";
                    if (bBool && !lastClickOnEqual)
                    {
                        bBool = false;
                    }
                }
                lastClickOnBinary = false;
                lastClickOnEqual = false;
                lastClickOnUnary = false;

                if (!pointBool) //==false
                {
                    pointBool = true;
                }
            }
        }

        private void binaryOperator(object sender, EventArgs e)
        {
            if (!error)
            {
                lastClickOnEqual = false;
                lastClickOnUnary = false;
                if (!aBool || lastClickOnBinary)
                {
                    Button buttonOperation = (Button)sender;
                    operator1 = buttonOperation.Text;
                    operator1Bool = true;
                    a = Convert.ToDouble(textBox1.Text);
                    aBool = true;
                    pointBool = false;
                    lastClickOnBinary = true;
                }
                else
                {
                    equal_Click(equal, e);
                    lastClickOnEqual = false;
                    if (!error)
                    {
                        Button buttonOperation = (Button)sender;
                        operator1 = buttonOperation.Text;
                        operator1Bool = true;
                        a = Convert.ToDouble(textBox1.Text);
                        aBool = true;
                        pointBool = false;
                        lastClickOnBinary = true;
                    }
                }
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                if (operator1Bool)
                {
                    if (!bBool)
                        b = Convert.ToDouble(textBox1.Text);
                    switch (operator1)
                    {
                        case "/":
                            if (b != 0)
                                c = a / b;
                            else
                                error = true;
                            break;
                        case "*":
                            c = a * b;
                            break;
                        case "-":
                            c = a - b;
                            break;
                        case "+":
                            c = a + b;
                            break;
                    }
                    if (c.ToString() == "∞")
                    {
                        error = true;
                        textBox1.Text = "Переполнение";
                    }
                    else if (!error)
                    {
                        if (c.ToString().IndexOf(',') == -1)
                            textBox1.Text = c.ToString() + ",";
                        else
                            textBox1.Text = c.ToString();
                        a = c;
                        c = 0;
                        bBool = true;
                        pointBool = false;
                        lastClickOnBinary = true;
                        lastClickOnEqual = true;
                        lastClickOnUnary = false;
                    }
                    else
                    {
                        textBox1.Text = "Нельзя делить на ноль";
                    }
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UnaryOperator(object sender, EventArgs e)
        {
            if (!error)
            {
                Button but1 = (Button)sender;
                lastClickOnBinary = false;
                lastClickOnEqual = false;
                if (aBool) bBool = false;
                b = Convert.ToDouble(textBox1.Text);

                switch (but1.Text)
                {
                    case "1/x":
                        if (b != 0)
                            b = 1 / b;
                        else
                            error = true;
                        break;
                    case "sqrt":
                        if (b >= 0)
                            b = Math.Sqrt(b);
                        else
                            error = true;
                        break;
                    case "x^2":
                        b = b * b;
                        break;
                    case "%":
                        if (!aBool)
                        {
                            textBox1.Text = "0,";
                        }
                        else
                        {
                            switch (operator1)
                            {
                                case "*":
                                    b = b / 100;
                                    break;
                                case "/":
                                    b = b / 100;
                                    break;
                                case "+":
                                    b = a * b / 100;
                                    break;
                                case "-":
                                    b = a * b / 100;
                                    break;
                            }
                        }
                        break;
                }
                if (b.ToString() == "∞")
                {
                    error = true;
                    textBox1.Text = "Переполнение";
                }
                else if (!error)
                {
                    if (b.ToString().IndexOf(',') == -1)
                        textBox1.Text = b.ToString() + ",";
                    else
                        textBox1.Text = b.ToString();

                    pointBool = false;
                    lastClickOnUnary = true;
                }
                else
                {
                    if (but1.Text == "1/x") textBox1.Text = "Нельзя делить на ноль";
                    else textBox1.Text = "Корень из отрицательного числа";
                }
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            pointBool = false;
            operator1 = "";
            operator1Bool = false;
            a = 0;
            aBool = false;
            b = 0;
            bBool = false;
            error = false;
            c = 0;
            lastClickOnBinary = false;
            lastClickOnEqual = false;
            lastClickOnUnary = false;
            textBox1.Text = "0,";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                pointBool = false;
                lastClickOnBinary = false;
                lastClickOnEqual = false;
                lastClickOnUnary = false;
                textBox1.Text = "0,";
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                if (!pointBool&&((textBox1.Text.Length==2)|| (textBox1.Text.Length == 3) && (textBox1.Text.IndexOf('-')==0))) 
                {
                    textBox1.Text = "0,";
                }
                else if (lastClickOnUnary || lastClickOnEqual || (textBox1.Text.IndexOf('e') != -1))
                {
                    pointBool = false;
                    textBox1.Text = "0,";
                }
                else
                {
                    if (pointBool && textBox1.Text.IndexOf(',')== textBox1.Text.Length-1)
                    {
                        pointBool = false;
                    }
                    else
                    {
                        if (textBox1.Text.IndexOf('-') == 0 && textBox1.Text.IndexOf(',') == 2)
                        {
                            textBox1.Text = "0,";
                        }
                        else if(pointBool)
                        {
                            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                        }
                        else
                        {
                            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 2, 2) + ",";
                        }
                    }
                }
            }
            lastClickOnBinary = false;
            lastClickOnEqual = false;
            lastClickOnUnary = false;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Button but1 = (Button)sender;
                lastClickOnBinary = false;
                lastClickOnEqual = false;
                if (aBool) bBool = false;
                b = Convert.ToDouble(textBox1.Text);

                if (!aBool)
                {
                    b = 0;
                }
                else
                {
                    switch (operator1)
                    {
                        case "*":
                            b = b / 100;
                            break;
                        case "/":
                            b = b / 100;
                            break;
                        case "+":
                            b = a * b / 100;
                            break;
                        case "-":
                            b = a * b / 100;
                            break;
                    }
                }
                if (b.ToString() == "∞")
                {
                    error = true;
                    textBox1.Text = "Переполнение";
                }
                else if (!error)
                {
                    if (b.ToString().IndexOf(',') == -1)
                        textBox1.Text = b.ToString() + ",";
                    else
                        textBox1.Text = b.ToString();

                    pointBool = false;
                    lastClickOnUnary = true;
                }
            }
        }

        private void Click_BigM(object sender, EventArgs e)
        {
            if (!error)
            {
                Button but1 = (Button)sender;

                switch (but1.Text)
                {
                    case "MC":
                        M = 0;
                        MBool = false;
                        showBigM.Text = "";
                        memoryError = false;
                        break;
                    case "MR":
                        if (!memoryError)
                        {

                            if (lastClickOnBinary || lastClickOnUnary)
                            {
                                textBox1.Text = "0,";
                                if (bBool && !lastClickOnEqual)
                                {
                                    bBool = false;
                                }
                            }


                            if ((M.ToString().IndexOf(',') == -1) && (M.ToString().IndexOf('e') == -1))
                            {
                                textBox1.Text = M.ToString() + ",";
                            }
                            else
                            {
                                textBox1.Text = M.ToString();
                            }
                        }
                        break;
                    case "MS":
                        if (!memoryError)
                        {
                            M = Convert.ToDouble(textBox1.Text);
                            MBool = true;
                            showBigM.Text = "M = " + M.ToString();
                        }
                        break;
                    case "M+":
                        {
                            if (!memoryError)
                            {
                                M = M + Convert.ToDouble(textBox1.Text);
                                MBool = true;
                                showBigM.Text = "M = " + M.ToString();
                                if (M.ToString() == "∞") memoryError = true;
                            }
                        }
                        break;
                }
                lastClickOnBinary = false;
                lastClickOnEqual = false;
                lastClickOnUnary = true;
                if (memoryError)
                {
                    showBigM.Text = "Память переполнена";
                }
            }  
        }
    }
}
//проверка "е" в текстбоксе и проверка еррора
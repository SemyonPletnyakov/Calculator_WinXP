
namespace Calculator_WinXP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backspace = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.signСhange = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.power2 = new System.Windows.Forms.Button();
            this.showBigM = new System.Windows.Forms.Label();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMplus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0,";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(13, 40);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(75, 23);
            this.backspace.TabIndex = 1;
            this.backspace.Text = "Backspace";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(94, 40);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(75, 23);
            this.buttonCE.TabIndex = 2;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(176, 40);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 23);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(13, 70);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(75, 23);
            this.number7.TabIndex = 4;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(94, 70);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(75, 23);
            this.number8.TabIndex = 5;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(175, 70);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(75, 23);
            this.number9.TabIndex = 6;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(257, 70);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.binaryOperator);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(339, 70);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 23);
            this.sqrt.TabIndex = 8;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.UnaryOperator);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(12, 100);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(75, 23);
            this.number4.TabIndex = 9;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(93, 100);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(75, 23);
            this.number5.TabIndex = 10;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(174, 100);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(75, 23);
            this.number6.TabIndex = 11;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(256, 100);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 12;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.binaryOperator);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(338, 100);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(75, 23);
            this.percent.TabIndex = 13;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(12, 130);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(75, 23);
            this.number1.TabIndex = 14;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(92, 130);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(75, 23);
            this.number2.TabIndex = 15;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(173, 130);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(75, 23);
            this.number3.TabIndex = 16;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(255, 130);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(75, 23);
            this.substraction.TabIndex = 17;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.binaryOperator);
            // 
            // reverse
            // 
            this.reverse.Location = new System.Drawing.Point(338, 130);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(75, 23);
            this.reverse.TabIndex = 18;
            this.reverse.Text = "1/x";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.UnaryOperator);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(11, 160);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(75, 23);
            this.number0.TabIndex = 19;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.Click_OnNumber);
            // 
            // signСhange
            // 
            this.signСhange.Location = new System.Drawing.Point(91, 160);
            this.signСhange.Name = "signСhange";
            this.signСhange.Size = new System.Drawing.Size(75, 23);
            this.signСhange.TabIndex = 20;
            this.signСhange.Text = "+/-";
            this.signСhange.UseVisualStyleBackColor = true;
            this.signСhange.Click += new System.EventHandler(this.signСhange_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(172, 160);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 23);
            this.point.TabIndex = 21;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(254, 160);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 22;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.binaryOperator);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(337, 160);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 23);
            this.equal.TabIndex = 23;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // power2
            // 
            this.power2.Location = new System.Drawing.Point(339, 41);
            this.power2.Name = "power2";
            this.power2.Size = new System.Drawing.Size(75, 23);
            this.power2.TabIndex = 25;
            this.power2.Text = "x^2";
            this.power2.UseVisualStyleBackColor = true;
            this.power2.Click += new System.EventHandler(this.UnaryOperator);
            // 
            // showBigM
            // 
            this.showBigM.AutoSize = true;
            this.showBigM.Location = new System.Drawing.Point(434, 45);
            this.showBigM.Name = "showBigM";
            this.showBigM.Size = new System.Drawing.Size(0, 13);
            this.showBigM.TabIndex = 26;
            // 
            // buttonMC
            // 
            this.buttonMC.Location = new System.Drawing.Point(437, 70);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(75, 23);
            this.buttonMC.TabIndex = 27;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.Click_BigM);
            // 
            // buttonMR
            // 
            this.buttonMR.Location = new System.Drawing.Point(437, 100);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(75, 23);
            this.buttonMR.TabIndex = 28;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.Click_BigM);
            // 
            // buttonMS
            // 
            this.buttonMS.Location = new System.Drawing.Point(437, 130);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(75, 23);
            this.buttonMS.TabIndex = 29;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = true;
            this.buttonMS.Click += new System.EventHandler(this.Click_BigM);
            // 
            // buttonMplus
            // 
            this.buttonMplus.Location = new System.Drawing.Point(437, 160);
            this.buttonMplus.Name = "buttonMplus";
            this.buttonMplus.Size = new System.Drawing.Size(75, 23);
            this.buttonMplus.TabIndex = 30;
            this.buttonMplus.Text = "M+";
            this.buttonMplus.UseVisualStyleBackColor = true;
            this.buttonMplus.Click += new System.EventHandler(this.Click_BigM);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMplus);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.showBigM);
            this.Controls.Add(this.power2);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.point);
            this.Controls.Add(this.signСhange);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.division);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button signСhange;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button power2;
        private System.Windows.Forms.Label showBigM;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMplus;
    }
}


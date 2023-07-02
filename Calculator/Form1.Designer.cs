namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.CalculatorTitle = new System.Windows.Forms.Label();
            this.EnterFirst = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.EnterSecond = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.resultNotVar = new System.Windows.Forms.Label();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculatorTitle
            // 
            this.CalculatorTitle.AutoSize = true;
            this.CalculatorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorTitle.Location = new System.Drawing.Point(12, 9);
            this.CalculatorTitle.Name = "CalculatorTitle";
            this.CalculatorTitle.Size = new System.Drawing.Size(250, 55);
            this.CalculatorTitle.TabIndex = 0;
            this.CalculatorTitle.Text = "Calculator";
            // 
            // EnterFirst
            // 
            this.EnterFirst.AutoSize = true;
            this.EnterFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterFirst.Location = new System.Drawing.Point(18, 87);
            this.EnterFirst.Name = "EnterFirst";
            this.EnterFirst.Size = new System.Drawing.Size(182, 24);
            this.EnterFirst.TabIndex = 1;
            this.EnterFirst.Text = "Enter first number.";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirst.Location = new System.Drawing.Point(243, 80);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(100, 31);
            this.textBoxFirst.TabIndex = 2;
            this.textBoxFirst.TextChanged += new System.EventHandler(this.textBoxFirst_TextChanged);
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecond.Location = new System.Drawing.Point(243, 117);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(100, 31);
            this.textBoxSecond.TabIndex = 4;
           // this.textBoxSecond.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EnterSecond
            // 
            this.EnterSecond.AutoSize = true;
            this.EnterSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterSecond.Location = new System.Drawing.Point(18, 124);
            this.EnterSecond.Name = "EnterSecond";
            this.EnterSecond.Size = new System.Drawing.Size(219, 24);
            this.EnterSecond.TabIndex = 3;
            this.EnterSecond.Text = "Enter second number.";
            this.EnterSecond.Click += new System.EventHandler(this.label1_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(22, 163);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 29);
            this.add.TabIndex = 5;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // resultNotVar
            // 
            this.resultNotVar.AutoSize = true;
            this.resultNotVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultNotVar.Location = new System.Drawing.Point(157, 199);
            this.resultNotVar.Name = "resultNotVar";
            this.resultNotVar.Size = new System.Drawing.Size(81, 29);
            this.resultNotVar.TabIndex = 6;
            this.resultNotVar.Text = "Result";
            this.resultNotVar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(115, 163);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(85, 29);
            this.subtract.TabIndex = 7;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(214, 163);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 29);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(311, 163);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 29);
            this.divide.TabIndex = 9;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(452, 662);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.resultNotVar);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.EnterSecond);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.EnterFirst);
            this.Controls.Add(this.CalculatorTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalculatorTitle;
        private System.Windows.Forms.Label EnterFirst;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Label EnterSecond;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label resultNotVar;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
    }
}


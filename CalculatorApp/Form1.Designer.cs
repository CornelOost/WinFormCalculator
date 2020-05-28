namespace CalculatorApp
{
    partial class CalculatorForm
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
            this.NumSeven = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.NumEight = new System.Windows.Forms.Button();
            this.NumNine = new System.Windows.Forms.Button();
            this.AddOperator = new System.Windows.Forms.Button();
            this.ClearOperator = new System.Windows.Forms.Button();
            this.NumFour = new System.Windows.Forms.Button();
            this.NumFive = new System.Windows.Forms.Button();
            this.NumSix = new System.Windows.Forms.Button();
            this.SubtractOperator = new System.Windows.Forms.Button();
            this.ClearEntryOperator = new System.Windows.Forms.Button();
            this.NumOne = new System.Windows.Forms.Button();
            this.NumTwo = new System.Windows.Forms.Button();
            this.NumThree = new System.Windows.Forms.Button();
            this.MultiplyOperator = new System.Windows.Forms.Button();
            this.DivideOperator = new System.Windows.Forms.Button();
            this.NumZero = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.EqualsOperator = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumSeven
            // 
            this.NumSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSeven.Location = new System.Drawing.Point(12, 101);
            this.NumSeven.Name = "NumSeven";
            this.NumSeven.Size = new System.Drawing.Size(45, 45);
            this.NumSeven.TabIndex = 0;
            this.NumSeven.Text = "7";
            this.NumSeven.UseVisualStyleBackColor = true;
            this.NumSeven.Click += new System.EventHandler(this.buttonClicked);
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(12, 41);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.ReadOnly = true;
            this.InputBox.Size = new System.Drawing.Size(249, 54);
            this.InputBox.TabIndex = 1;
            this.InputBox.Text = "0";
            this.InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumEight
            // 
            this.NumEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEight.Location = new System.Drawing.Point(63, 101);
            this.NumEight.Name = "NumEight";
            this.NumEight.Size = new System.Drawing.Size(45, 45);
            this.NumEight.TabIndex = 0;
            this.NumEight.Text = "8";
            this.NumEight.UseVisualStyleBackColor = true;
            this.NumEight.Click += new System.EventHandler(this.buttonClicked);
            // 
            // NumNine
            // 
            this.NumNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumNine.Location = new System.Drawing.Point(114, 101);
            this.NumNine.Name = "NumNine";
            this.NumNine.Size = new System.Drawing.Size(45, 45);
            this.NumNine.TabIndex = 0;
            this.NumNine.Text = "9";
            this.NumNine.UseVisualStyleBackColor = true;
            this.NumNine.Click += new System.EventHandler(this.buttonClicked);
            // 
            // AddOperator
            // 
            this.AddOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOperator.Location = new System.Drawing.Point(165, 101);
            this.AddOperator.Name = "AddOperator";
            this.AddOperator.Size = new System.Drawing.Size(45, 45);
            this.AddOperator.TabIndex = 0;
            this.AddOperator.Text = "+";
            this.AddOperator.UseVisualStyleBackColor = true;
            this.AddOperator.Click += new System.EventHandler(this.operatorClicked);
            // 
            // ClearOperator
            // 
            this.ClearOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearOperator.Location = new System.Drawing.Point(216, 101);
            this.ClearOperator.Name = "ClearOperator";
            this.ClearOperator.Size = new System.Drawing.Size(45, 45);
            this.ClearOperator.TabIndex = 0;
            this.ClearOperator.Text = "C";
            this.ClearOperator.UseVisualStyleBackColor = true;
            this.ClearOperator.Click += new System.EventHandler(this.ClearOperator_Click);
            // 
            // NumFour
            // 
            this.NumFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumFour.Location = new System.Drawing.Point(12, 152);
            this.NumFour.Name = "NumFour";
            this.NumFour.Size = new System.Drawing.Size(45, 45);
            this.NumFour.TabIndex = 0;
            this.NumFour.Text = "4";
            this.NumFour.UseVisualStyleBackColor = true;
            this.NumFour.Click += new System.EventHandler(this.buttonClicked);
            // 
            // NumFive
            // 
            this.NumFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumFive.Location = new System.Drawing.Point(63, 152);
            this.NumFive.Name = "NumFive";
            this.NumFive.Size = new System.Drawing.Size(45, 45);
            this.NumFive.TabIndex = 0;
            this.NumFive.Text = "5";
            this.NumFive.UseVisualStyleBackColor = true;
            this.NumFive.Click += new System.EventHandler(this.buttonClicked);
            // 
            // NumSix
            // 
            this.NumSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSix.Location = new System.Drawing.Point(114, 152);
            this.NumSix.Name = "NumSix";
            this.NumSix.Size = new System.Drawing.Size(45, 45);
            this.NumSix.TabIndex = 0;
            this.NumSix.Text = "6";
            this.NumSix.UseVisualStyleBackColor = true;
            this.NumSix.Click += new System.EventHandler(this.buttonClicked);
            // 
            // SubtractOperator
            // 
            this.SubtractOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractOperator.Location = new System.Drawing.Point(165, 152);
            this.SubtractOperator.Name = "SubtractOperator";
            this.SubtractOperator.Size = new System.Drawing.Size(45, 45);
            this.SubtractOperator.TabIndex = 0;
            this.SubtractOperator.Text = "-";
            this.SubtractOperator.UseVisualStyleBackColor = true;
            this.SubtractOperator.Click += new System.EventHandler(this.operatorClicked);
            // 
            // ClearEntryOperator
            // 
            this.ClearEntryOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntryOperator.Location = new System.Drawing.Point(216, 152);
            this.ClearEntryOperator.Name = "ClearEntryOperator";
            this.ClearEntryOperator.Size = new System.Drawing.Size(45, 45);
            this.ClearEntryOperator.TabIndex = 0;
            this.ClearEntryOperator.Text = "CE";
            this.ClearEntryOperator.UseVisualStyleBackColor = true;
            this.ClearEntryOperator.Click += new System.EventHandler(this.ClearEntryOperator_Click);
            // 
            // NumOne
            // 
            this.NumOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOne.Location = new System.Drawing.Point(12, 203);
            this.NumOne.Name = "NumOne";
            this.NumOne.Size = new System.Drawing.Size(45, 45);
            this.NumOne.TabIndex = 0;
            this.NumOne.Text = "1";
            this.NumOne.UseVisualStyleBackColor = true;
            this.NumOne.Click += new System.EventHandler(this.buttonClicked);
            // 
            // NumTwo
            // 
            this.NumTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTwo.Location = new System.Drawing.Point(63, 203);
            this.NumTwo.Name = "NumTwo";
            this.NumTwo.Size = new System.Drawing.Size(45, 45);
            this.NumTwo.TabIndex = 0;
            this.NumTwo.Text = "2";
            this.NumTwo.UseVisualStyleBackColor = true;
            this.NumTwo.Click += new System.EventHandler(this.buttonClicked);
            // 
            // NumThree
            // 
            this.NumThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumThree.Location = new System.Drawing.Point(114, 203);
            this.NumThree.Name = "NumThree";
            this.NumThree.Size = new System.Drawing.Size(45, 45);
            this.NumThree.TabIndex = 0;
            this.NumThree.Text = "3";
            this.NumThree.UseVisualStyleBackColor = true;
            this.NumThree.Click += new System.EventHandler(this.buttonClicked);
            // 
            // MultiplyOperator
            // 
            this.MultiplyOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyOperator.Location = new System.Drawing.Point(165, 203);
            this.MultiplyOperator.Name = "MultiplyOperator";
            this.MultiplyOperator.Size = new System.Drawing.Size(45, 45);
            this.MultiplyOperator.TabIndex = 0;
            this.MultiplyOperator.Text = "*";
            this.MultiplyOperator.UseVisualStyleBackColor = true;
            this.MultiplyOperator.Click += new System.EventHandler(this.operatorClicked);
            // 
            // DivideOperator
            // 
            this.DivideOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideOperator.Location = new System.Drawing.Point(165, 254);
            this.DivideOperator.Name = "DivideOperator";
            this.DivideOperator.Size = new System.Drawing.Size(45, 45);
            this.DivideOperator.TabIndex = 0;
            this.DivideOperator.Text = "/";
            this.DivideOperator.UseVisualStyleBackColor = true;
            this.DivideOperator.Click += new System.EventHandler(this.operatorClicked);
            // 
            // NumZero
            // 
            this.NumZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumZero.Location = new System.Drawing.Point(12, 254);
            this.NumZero.Name = "NumZero";
            this.NumZero.Size = new System.Drawing.Size(96, 45);
            this.NumZero.TabIndex = 0;
            this.NumZero.Text = "0";
            this.NumZero.UseVisualStyleBackColor = true;
            this.NumZero.Click += new System.EventHandler(this.buttonClicked);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(114, 254);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(45, 45);
            this.button17.TabIndex = 0;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.decimalClicked);
            // 
            // EqualsOperator
            // 
            this.EqualsOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsOperator.Location = new System.Drawing.Point(216, 203);
            this.EqualsOperator.Name = "EqualsOperator";
            this.EqualsOperator.Size = new System.Drawing.Size(45, 96);
            this.EqualsOperator.TabIndex = 0;
            this.EqualsOperator.Text = "=";
            this.EqualsOperator.UseVisualStyleBackColor = true;
            this.EqualsOperator.Click += new System.EventHandler(this.EqualsOperator_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(249, 23);
            this.DisplayBox.TabIndex = 2;
            this.DisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 314);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.EqualsOperator);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.NumZero);
            this.Controls.Add(this.DivideOperator);
            this.Controls.Add(this.MultiplyOperator);
            this.Controls.Add(this.NumThree);
            this.Controls.Add(this.NumTwo);
            this.Controls.Add(this.NumOne);
            this.Controls.Add(this.ClearEntryOperator);
            this.Controls.Add(this.SubtractOperator);
            this.Controls.Add(this.NumSix);
            this.Controls.Add(this.NumFive);
            this.Controls.Add(this.NumFour);
            this.Controls.Add(this.ClearOperator);
            this.Controls.Add(this.AddOperator);
            this.Controls.Add(this.NumNine);
            this.Controls.Add(this.NumEight);
            this.Controls.Add(this.NumSeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumSeven;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button NumEight;
        private System.Windows.Forms.Button NumNine;
        private System.Windows.Forms.Button AddOperator;
        private System.Windows.Forms.Button ClearOperator;
        private System.Windows.Forms.Button NumFour;
        private System.Windows.Forms.Button NumFive;
        private System.Windows.Forms.Button NumSix;
        private System.Windows.Forms.Button SubtractOperator;
        private System.Windows.Forms.Button ClearEntryOperator;
        private System.Windows.Forms.Button NumOne;
        private System.Windows.Forms.Button NumTwo;
        private System.Windows.Forms.Button NumThree;
        private System.Windows.Forms.Button MultiplyOperator;
        private System.Windows.Forms.Button DivideOperator;
        private System.Windows.Forms.Button NumZero;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button EqualsOperator;
        private System.Windows.Forms.TextBox DisplayBox;
    }
}


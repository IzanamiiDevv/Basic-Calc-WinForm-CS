namespace Calculator
{
    partial class Window
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
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Operator = new System.Windows.Forms.ComboBox();
            this.Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(12, 164);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(100, 20);
            this.Input1.TabIndex = 0;
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(206, 164);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(100, 20);
            this.Input2.TabIndex = 1;
            // 
            // Operator
            // 
            this.Operator.DisplayMember = "Disp";
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "Additon",
            "Subtraction",
            "Multiplication",
            "Division",
            "Modulus"});
            this.Operator.Location = new System.Drawing.Point(118, 164);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(83, 21);
            this.Operator.TabIndex = 2;
            this.Operator.Text = "Operators";
            this.Operator.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.BackColor = System.Drawing.Color.White;
            this.Display.ForeColor = System.Drawing.Color.Black;
            this.Display.Location = new System.Drawing.Point(115, 128);
            this.Display.Name = "Display";
            this.Display.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Display.Size = new System.Drawing.Size(69, 23);
            this.Display.TabIndex = 3;
            this.Display.Text = "Result: 0";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(318, 423);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Name = "Window";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.Label Display;
    }
}


namespace Abstract
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            txtBaseTriangle = new TextBox();
            txtHeightTriangle = new TextBox();
            txtBaseRectangle = new TextBox();
            txtHeightRectangle = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtAreaRectangle = new TextBox();
            txtAreaTriangle = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(163, 33);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Triangle";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(171, 65);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(31, 15);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Base";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(171, 97);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(39, 15);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Altura";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(163, 230);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(59, 15);
            linkLabel4.TabIndex = 3;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Rectangle";
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new Point(171, 263);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(31, 15);
            linkLabel5.TabIndex = 4;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Base";
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.Location = new Point(172, 287);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(39, 15);
            linkLabel6.TabIndex = 5;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Altura";
            // 
            // txtBaseTriangle
            // 
            txtBaseTriangle.Location = new Point(225, 65);
            txtBaseTriangle.Name = "txtBaseTriangle";
            txtBaseTriangle.Size = new Size(100, 23);
            txtBaseTriangle.TabIndex = 6;
            // 
            // txtHeightTriangle
            // 
            txtHeightTriangle.Location = new Point(225, 94);
            txtHeightTriangle.Name = "txtHeightTriangle";
            txtHeightTriangle.Size = new Size(100, 23);
            txtHeightTriangle.TabIndex = 7;
            // 
            // txtBaseRectangle
            // 
            txtBaseRectangle.Location = new Point(225, 255);
            txtBaseRectangle.Name = "txtBaseRectangle";
            txtBaseRectangle.Size = new Size(100, 23);
            txtBaseRectangle.TabIndex = 8;
            // 
            // txtHeightRectangle
            // 
            txtHeightRectangle.Location = new Point(225, 284);
            txtHeightRectangle.Name = "txtHeightRectangle";
            txtHeightRectangle.Size = new Size(100, 23);
            txtHeightRectangle.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(239, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateArea_Click;
            // 
            // button2
            // 
            button2.Location = new Point(239, 356);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtAreaRectangle
            // 
            txtAreaRectangle.Location = new Point(225, 313);
            txtAreaRectangle.Name = "txtAreaRectangle";
            txtAreaRectangle.Size = new Size(100, 23);
            txtAreaRectangle.TabIndex = 12;
            // 
            // txtAreaTriangle
            // 
            txtAreaTriangle.Location = new Point(225, 123);
            txtAreaTriangle.Name = "txtAreaTriangle";
            txtAreaTriangle.Size = new Size(100, 23);
            txtAreaTriangle.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAreaTriangle);
            Controls.Add(txtAreaRectangle);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtHeightRectangle);
            Controls.Add(txtBaseRectangle);
            Controls.Add(txtHeightTriangle);
            Controls.Add(txtBaseTriangle);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
        private TextBox txtBaseTriangle;
        private TextBox txtHeightTriangle;
        private TextBox txtBaseRectangle;
        private TextBox txtHeightRectangle;
        private Button button1;
        private Button button2;
        private TextBox txtAreaRectangle;
        private TextBox txtAreaTriangle;
    }
}

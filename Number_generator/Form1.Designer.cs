namespace Number_generator
{
    partial class RandomNumberGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomNumberGenerator));
            SaveRes = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            randNum = new Button();
            SuspendLayout();
            // 
            // SaveRes
            // 
            SaveRes.BackColor = SystemColors.ActiveCaptionText;
            SaveRes.FlatAppearance.BorderColor = Color.White;
            SaveRes.ForeColor = SystemColors.ButtonFace;
            SaveRes.Location = new Point(500, 220);
            SaveRes.Margin = new Padding(5, 4, 5, 4);
            SaveRes.Name = "SaveRes";
            SaveRes.Size = new Size(216, 36);
            SaveRes.TabIndex = 2;
            SaveRes.Text = "Save result";
            SaveRes.UseVisualStyleBackColor = false;
            SaveRes.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(807, 277);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(332, 134);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 5;
            label2.Text = "Result:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.ForeColor = SystemColors.MenuBar;
            textBox1.Location = new Point(413, 86);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 29);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaptionText;
            textBox2.ForeColor = SystemColors.InactiveBorder;
            textBox2.Location = new Point(413, 131);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 29);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(305, 89);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 9;
            label4.Text = "Minimum:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(305, 41);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 10;
            label5.Text = "Maximum:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InfoText;
            textBox3.ForeColor = SystemColors.MenuBar;
            textBox3.Location = new Point(413, 38);
            textBox3.Margin = new Padding(5, 4, 5, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 29);
            textBox3.TabIndex = 11;
            // 
            // randNum
            // 
            randNum.BackColor = Color.Black;
            randNum.ForeColor = SystemColors.ButtonFace;
            randNum.Location = new Point(260, 220);
            randNum.Margin = new Padding(5, 4, 5, 4);
            randNum.Name = "randNum";
            randNum.Size = new Size(216, 36);
            randNum.TabIndex = 3;
            randNum.Text = "Random Number";
            randNum.UseVisualStyleBackColor = false;
            randNum.Click += button4_Click;
            // 
            // RandomNumberGenerator
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(956, 279);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(randNum);
            Controls.Add(SaveRes);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "RandomNumberGenerator";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveRes;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Button randNum;
    }
}
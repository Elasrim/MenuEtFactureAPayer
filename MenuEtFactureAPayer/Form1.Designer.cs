namespace MenuEtFactureAPayer
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
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            clb_Chaude = new CheckedListBox();
            clb_Patessrier = new CheckedListBox();
            clb_Jus = new CheckedListBox();
            panel2 = new Panel();
            rb_visa = new RadioButton();
            rb_Espece = new RadioButton();
            rb_Cheque = new RadioButton();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            LvMenu = new ListView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 55);
            label1.Name = "label1";
            label1.Size = new Size(97, 40);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(clb_Chaude);
            panel1.Controls.Add(clb_Patessrier);
            panel1.Controls.Add(clb_Jus);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 1129);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(909, 1023);
            button3.Name = "button3";
            button3.Size = new Size(196, 68);
            button3.TabIndex = 8;
            button3.Text = "Nouveau";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(697, 1023);
            button2.Name = "button2";
            button2.Size = new Size(196, 68);
            button2.TabIndex = 7;
            button2.Text = "Commender";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // clb_Chaude
            // 
            clb_Chaude.FormattingEnabled = true;
            clb_Chaude.Items.AddRange(new object[] { "The", "Cafe Noire", "Cafe au lait", "Normal", "Leger" });
            clb_Chaude.Location = new Point(61, 133);
            clb_Chaude.Name = "clb_Chaude";
            clb_Chaude.Size = new Size(530, 864);
            clb_Chaude.TabIndex = 3;
            // 
            // clb_Patessrier
            // 
            clb_Patessrier.FormattingEnabled = true;
            clb_Patessrier.Items.AddRange(new object[] { "Petite paine", "Pain", "cheneck", "Segare", "Creame" });
            clb_Patessrier.Location = new Point(628, 130);
            clb_Patessrier.Name = "clb_Patessrier";
            clb_Patessrier.Size = new Size(477, 391);
            clb_Patessrier.TabIndex = 2;
            // 
            // clb_Jus
            // 
            clb_Jus.FormattingEnabled = true;
            clb_Jus.Items.AddRange(new object[] { "Orange", "Avocat", "Banane", "Pomme" });
            clb_Jus.Location = new Point(628, 613);
            clb_Jus.Name = "clb_Jus";
            clb_Jus.Size = new Size(477, 391);
            clb_Jus.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(rb_visa);
            panel2.Controls.Add(rb_Espece);
            panel2.Controls.Add(rb_Cheque);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LvMenu);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1174, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 1129);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // rb_visa
            // 
            rb_visa.AutoSize = true;
            rb_visa.Location = new Point(50, 1014);
            rb_visa.Name = "rb_visa";
            rb_visa.Size = new Size(104, 44);
            rb_visa.TabIndex = 9;
            rb_visa.TabStop = true;
            rb_visa.Text = "Visa";
            rb_visa.UseVisualStyleBackColor = true;
            // 
            // rb_Espece
            // 
            rb_Espece.AutoSize = true;
            rb_Espece.Location = new Point(50, 943);
            rb_Espece.Name = "rb_Espece";
            rb_Espece.Size = new Size(140, 44);
            rb_Espece.TabIndex = 8;
            rb_Espece.TabStop = true;
            rb_Espece.Text = "Espece";
            rb_Espece.UseVisualStyleBackColor = true;
            // 
            // rb_Cheque
            // 
            rb_Cheque.AutoSize = true;
            rb_Cheque.Location = new Point(50, 874);
            rb_Cheque.Name = "rb_Cheque";
            rb_Cheque.Size = new Size(151, 44);
            rb_Cheque.TabIndex = 7;
            rb_Cheque.TabStop = true;
            rb_Cheque.Text = "Cheque";
            rb_Cheque.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(421, 943);
            button1.Name = "button1";
            button1.Size = new Size(150, 124);
            button1.TabIndex = 6;
            button1.Text = "Payer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 797);
            label3.Name = "label3";
            label3.Size = new Size(276, 40);
            label3.TabIndex = 5;
            label3.Text = "Mode de Paiement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 55);
            label2.Name = "label2";
            label2.Size = new Size(84, 40);
            label2.TabIndex = 4;
            label2.Text = "Total";
            // 
            // LvMenu
            // 
            LvMenu.Location = new Point(36, 130);
            LvMenu.Name = "LvMenu";
            LvMenu.Size = new Size(535, 632);
            LvMenu.TabIndex = 0;
            LvMenu.UseCompatibleStateImageBehavior = false;
            LvMenu.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 1129);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private CheckedListBox clb_Chaude;
        private CheckedListBox clb_Patessrier;
        private CheckedListBox clb_Jus;
        private Panel panel2;
        private RadioButton rb_visa;
        private RadioButton rb_Espece;
        private RadioButton rb_Cheque;
        private Button button1;
        private Label label3;
        private Label label2;
        private ListView LvMenu;
    }
}
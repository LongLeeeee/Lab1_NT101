namespace Lab1_Vigenère
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
            tabControl1 = new TabControl();
            tab_encrypt = new TabPage();
            panel2 = new Panel();
            tb_cyphertext_encrypt = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            btn_encrypt = new Button();
            tb_plaintext_encrypt = new TextBox();
            tb_key_encrypt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            label5 = new Label();
            tb_key_decrypt = new TextBox();
            tb_cyphertext_decrypt = new TextBox();
            btn_decrypt = new Button();
            panel4 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            tb_plaintext_decrypt = new TextBox();
            tabControl1.SuspendLayout();
            tab_encrypt.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_encrypt);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 477);
            tabControl1.TabIndex = 0;
            // 
            // tab_encrypt
            // 
            tab_encrypt.Controls.Add(panel2);
            tab_encrypt.Controls.Add(panel1);
            tab_encrypt.Location = new Point(4, 24);
            tab_encrypt.Name = "tab_encrypt";
            tab_encrypt.Padding = new Padding(3);
            tab_encrypt.Size = new Size(792, 449);
            tab_encrypt.TabIndex = 0;
            tab_encrypt.Text = "Encrypt";
            tab_encrypt.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(tb_cyphertext_encrypt);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(403, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 443);
            panel2.TabIndex = 5;
            // 
            // tb_cyphertext_encrypt
            // 
            tb_cyphertext_encrypt.BackColor = SystemColors.Window;
            tb_cyphertext_encrypt.Dock = DockStyle.Fill;
            tb_cyphertext_encrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_cyphertext_encrypt.ForeColor = SystemColors.WindowText;
            tb_cyphertext_encrypt.Location = new Point(0, 30);
            tb_cyphertext_encrypt.Multiline = true;
            tb_cyphertext_encrypt.Name = "tb_cyphertext_encrypt";
            tb_cyphertext_encrypt.ReadOnly = true;
            tb_cyphertext_encrypt.ScrollBars = ScrollBars.Vertical;
            tb_cyphertext_encrypt.Size = new Size(386, 413);
            tb_cyphertext_encrypt.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 30);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 5);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 2;
            label3.Text = "Cyphertext";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_encrypt);
            panel1.Controls.Add(tb_plaintext_encrypt);
            panel1.Controls.Add(tb_key_encrypt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 443);
            panel1.TabIndex = 4;
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_encrypt.Location = new Point(32, 383);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(109, 46);
            btn_encrypt.TabIndex = 5;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click_1;
            // 
            // tb_plaintext_encrypt
            // 
            tb_plaintext_encrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_plaintext_encrypt.Location = new Point(32, 148);
            tb_plaintext_encrypt.Multiline = true;
            tb_plaintext_encrypt.Name = "tb_plaintext_encrypt";
            tb_plaintext_encrypt.ScrollBars = ScrollBars.Vertical;
            tb_plaintext_encrypt.Size = new Size(346, 222);
            tb_plaintext_encrypt.TabIndex = 3;
            // 
            // tb_key_encrypt
            // 
            tb_key_encrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_key_encrypt.Location = new Point(32, 55);
            tb_key_encrypt.Multiline = true;
            tb_key_encrypt.Name = "tb_key_encrypt";
            tb_key_encrypt.ScrollBars = ScrollBars.Vertical;
            tb_key_encrypt.Size = new Size(346, 41);
            tb_key_encrypt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 124);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter Plaintext";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter Key";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 449);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 31);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 0;
            label4.Text = "Enter Key";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 124);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 1;
            label5.Text = "Enter Plaintext";
            // 
            // tb_key_decrypt
            // 
            tb_key_decrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_key_decrypt.Location = new Point(32, 55);
            tb_key_decrypt.Multiline = true;
            tb_key_decrypt.Name = "tb_key_decrypt";
            tb_key_decrypt.ScrollBars = ScrollBars.Vertical;
            tb_key_decrypt.Size = new Size(346, 41);
            tb_key_decrypt.TabIndex = 2;
            // 
            // tb_cyphertext_decrypt
            // 
            tb_cyphertext_decrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_cyphertext_decrypt.Location = new Point(32, 148);
            tb_cyphertext_decrypt.Multiline = true;
            tb_cyphertext_decrypt.Name = "tb_cyphertext_decrypt";
            tb_cyphertext_decrypt.ScrollBars = ScrollBars.Vertical;
            tb_cyphertext_decrypt.Size = new Size(346, 222);
            tb_cyphertext_decrypt.TabIndex = 3;
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_decrypt.Location = new Point(32, 383);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(109, 46);
            btn_decrypt.TabIndex = 5;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_decrypt);
            panel4.Controls.Add(tb_cyphertext_decrypt);
            panel4.Controls.Add(tb_key_decrypt);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 443);
            panel4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(153, 5);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 2;
            label6.Text = "Plaintext";
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(386, 30);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(tb_plaintext_decrypt);
            panel6.Controls.Add(panel5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(403, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 443);
            panel6.TabIndex = 8;
            // 
            // tb_plaintext_decrypt
            // 
            tb_plaintext_decrypt.Dock = DockStyle.Fill;
            tb_plaintext_decrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_plaintext_decrypt.Location = new Point(0, 30);
            tb_plaintext_decrypt.Multiline = true;
            tb_plaintext_decrypt.Name = "tb_plaintext_decrypt";
            tb_plaintext_decrypt.ScrollBars = ScrollBars.Vertical;
            tb_plaintext_decrypt.Size = new Size(386, 413);
            tb_plaintext_decrypt.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tab_encrypt.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab_encrypt;
        private TextBox tb_cyphertext_encrypt;
        private TabPage tabPage2;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Button btn_encrypt;
        private TextBox tb_plaintext_encrypt;
        private TextBox tb_key_encrypt;
        private Label label2;
        private Label label1;
        private Panel panel6;
        private TextBox tb_plaintext_decrypt;
        private Panel panel5;
        private Label label6;
        private Panel panel4;
        private Button btn_decrypt;
        private TextBox tb_cyphertext_decrypt;
        private TextBox tb_key_decrypt;
        private Label label5;
        private Label label4;
    }
}

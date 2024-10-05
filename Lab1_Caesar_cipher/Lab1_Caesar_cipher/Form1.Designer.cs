namespace Lab1_Caesar_cipher
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
            tab1 = new TabControl();
            tab_encrypt = new TabPage();
            rtb_en_result = new TextBox();
            panel1 = new Panel();
            btn_encrypt = new Button();
            label2 = new Label();
            label1 = new Label();
            tb_plaintext = new TextBox();
            tb_key = new TextBox();
            tab_decrypt = new TabPage();
            rtb_decrypt = new TextBox();
            panel2 = new Panel();
            btn_decrypt_without_key = new Button();
            tb_cypher_text = new TextBox();
            btn_decrypt = new Button();
            label3 = new Label();
            lb = new Label();
            tb_key_de = new TextBox();
            tab1.SuspendLayout();
            tab_encrypt.SuspendLayout();
            panel1.SuspendLayout();
            tab_decrypt.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tab1
            // 
            tab1.Controls.Add(tab_encrypt);
            tab1.Controls.Add(tab_decrypt);
            tab1.Dock = DockStyle.Fill;
            tab1.Location = new Point(0, 0);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(949, 563);
            tab1.TabIndex = 0;
            // 
            // tab_encrypt
            // 
            tab_encrypt.Controls.Add(rtb_en_result);
            tab_encrypt.Controls.Add(panel1);
            tab_encrypt.Location = new Point(4, 24);
            tab_encrypt.Name = "tab_encrypt";
            tab_encrypt.Padding = new Padding(3);
            tab_encrypt.Size = new Size(941, 535);
            tab_encrypt.TabIndex = 0;
            tab_encrypt.Text = "Encrypt";
            tab_encrypt.UseVisualStyleBackColor = true;
            // 
            // rtb_en_result
            // 
            rtb_en_result.Dock = DockStyle.Fill;
            rtb_en_result.Location = new Point(463, 3);
            rtb_en_result.Multiline = true;
            rtb_en_result.Name = "rtb_en_result";
            rtb_en_result.ReadOnly = true;
            rtb_en_result.ScrollBars = ScrollBars.Vertical;
            rtb_en_result.Size = new Size(475, 529);
            rtb_en_result.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_encrypt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_plaintext);
            panel1.Controls.Add(tb_key);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 529);
            panel1.TabIndex = 9;
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_encrypt.Location = new Point(352, 58);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(94, 33);
            btn_encrypt.TabIndex = 14;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 109);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 13;
            label2.Text = "Enter plaintext";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 12;
            label1.Text = "Enter key (Interger type)";
            // 
            // tb_plaintext
            // 
            tb_plaintext.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_plaintext.Location = new Point(15, 133);
            tb_plaintext.Multiline = true;
            tb_plaintext.Name = "tb_plaintext";
            tb_plaintext.Size = new Size(431, 361);
            tb_plaintext.TabIndex = 11;
            // 
            // tb_key
            // 
            tb_key.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_key.Location = new Point(15, 58);
            tb_key.Name = "tb_key";
            tb_key.Size = new Size(307, 33);
            tb_key.TabIndex = 10;
            // 
            // tab_decrypt
            // 
            tab_decrypt.Controls.Add(rtb_decrypt);
            tab_decrypt.Controls.Add(panel2);
            tab_decrypt.Location = new Point(4, 24);
            tab_decrypt.Name = "tab_decrypt";
            tab_decrypt.Padding = new Padding(3);
            tab_decrypt.Size = new Size(941, 535);
            tab_decrypt.TabIndex = 1;
            tab_decrypt.Text = "Decrypt";
            tab_decrypt.UseVisualStyleBackColor = true;
            // 
            // rtb_decrypt
            // 
            rtb_decrypt.Dock = DockStyle.Fill;
            rtb_decrypt.Location = new Point(492, 3);
            rtb_decrypt.Multiline = true;
            rtb_decrypt.Name = "rtb_decrypt";
            rtb_decrypt.ReadOnly = true;
            rtb_decrypt.ScrollBars = ScrollBars.Vertical;
            rtb_decrypt.Size = new Size(446, 529);
            rtb_decrypt.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_decrypt_without_key);
            panel2.Controls.Add(tb_cypher_text);
            panel2.Controls.Add(btn_decrypt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lb);
            panel2.Controls.Add(tb_key_de);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 529);
            panel2.TabIndex = 15;
            // 
            // btn_decrypt_without_key
            // 
            btn_decrypt_without_key.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_decrypt_without_key.Location = new Point(206, 37);
            btn_decrypt_without_key.Name = "btn_decrypt_without_key";
            btn_decrypt_without_key.Size = new Size(159, 33);
            btn_decrypt_without_key.TabIndex = 23;
            btn_decrypt_without_key.Text = "Decrypt without key";
            btn_decrypt_without_key.UseVisualStyleBackColor = true;
            btn_decrypt_without_key.Click += btn_decrypt_without_key_Click_1;
            // 
            // tb_cypher_text
            // 
            tb_cypher_text.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_cypher_text.Location = new Point(22, 111);
            tb_cypher_text.Multiline = true;
            tb_cypher_text.Name = "tb_cypher_text";
            tb_cypher_text.Size = new Size(445, 405);
            tb_cypher_text.TabIndex = 22;
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_decrypt.Location = new Point(379, 37);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(88, 33);
            btn_decrypt.TabIndex = 21;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 87);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 20;
            label3.Text = "Enter Cyphertext";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb.Location = new Point(22, 13);
            lb.Name = "lb";
            lb.Size = new Size(177, 21);
            lb.TabIndex = 19;
            lb.Text = "Enter key (Interger type)";
            // 
            // tb_key_de
            // 
            tb_key_de.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_key_de.Location = new Point(23, 37);
            tb_key_de.Name = "tb_key_de";
            tb_key_de.Size = new Size(177, 33);
            tb_key_de.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 563);
            Controls.Add(tab1);
            Name = "Form1";
            Text = "Form1";
            tab1.ResumeLayout(false);
            tab_encrypt.ResumeLayout(false);
            tab_encrypt.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tab_decrypt.ResumeLayout(false);
            tab_decrypt.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab1;
        private TabPage tab_encrypt;
        private TabPage tab_decrypt;
        private TextBox cypher_text;
        private Panel panel2;
        private Button btn_decrypt_without_key;
        private TextBox tb_cypher_text;
        private Button btn_decrypt;
        private Label label3;
        private Label lb;
        private TextBox tb_key_de;
        private Panel panel1;
        private Button btn_encrypt;
        private Label label2;
        private Label label1;
        private TextBox tb_plaintext;
        private TextBox tb_key;
        private TextBox rtb_en_result;
        private TextBox rtb_decrypt;
    }
}

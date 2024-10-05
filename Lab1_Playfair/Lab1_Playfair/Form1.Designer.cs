namespace Lab1_Playfair
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
            Encrypt = new TabPage();
            tb_cyphertext = new TextBox();
            panel7 = new Panel();
            label6 = new Label();
            tb_plaintext = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            btn_create_matrix = new Button();
            label2 = new Label();
            btn_encrypt = new Button();
            panel3 = new Panel();
            mt_en5 = new TextBox();
            mt_en4 = new TextBox();
            mt_en3 = new TextBox();
            mt_en2 = new TextBox();
            mt_en1 = new TextBox();
            mt_en25 = new TextBox();
            mt_en24 = new TextBox();
            mt_en23 = new TextBox();
            mt_en22 = new TextBox();
            mt_en21 = new TextBox();
            mt_en20 = new TextBox();
            mt_en19 = new TextBox();
            mt_en18 = new TextBox();
            mt_en17 = new TextBox();
            mt_en16 = new TextBox();
            mt_en15 = new TextBox();
            mt_en14 = new TextBox();
            mt_en13 = new TextBox();
            mt_en12 = new TextBox();
            mt_en11 = new TextBox();
            mt_en10 = new TextBox();
            mt_en9 = new TextBox();
            mt_en8 = new TextBox();
            mt_en7 = new TextBox();
            mt_en6 = new TextBox();
            label1 = new Label();
            tb_key = new TextBox();
            Decrypt = new TabPage();
            tb_plaintext1 = new TextBox();
            panel8 = new Panel();
            label8 = new Label();
            tb_cypher_text = new TextBox();
            panel6 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            btn_createMatrix = new Button();
            btn_decrypt = new Button();
            panel5 = new Panel();
            mt5 = new TextBox();
            mt4 = new TextBox();
            mt3 = new TextBox();
            mt2 = new TextBox();
            mt1 = new TextBox();
            mt25 = new TextBox();
            mt24 = new TextBox();
            mt23 = new TextBox();
            mt22 = new TextBox();
            mt21 = new TextBox();
            mt20 = new TextBox();
            mt19 = new TextBox();
            mt18 = new TextBox();
            mt17 = new TextBox();
            mt16 = new TextBox();
            mt15 = new TextBox();
            mt14 = new TextBox();
            mt13 = new TextBox();
            mt12 = new TextBox();
            mt11 = new TextBox();
            mt10 = new TextBox();
            mt9 = new TextBox();
            mt8 = new TextBox();
            mt7 = new TextBox();
            mt6 = new TextBox();
            tb_key_decrypt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            Encrypt.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            Decrypt.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Encrypt);
            tabControl1.Controls.Add(Decrypt);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 472);
            tabControl1.TabIndex = 0;
            // 
            // Encrypt
            // 
            Encrypt.Controls.Add(tb_cyphertext);
            Encrypt.Controls.Add(panel7);
            Encrypt.Controls.Add(tb_plaintext);
            Encrypt.Controls.Add(panel2);
            Encrypt.Controls.Add(panel1);
            Encrypt.Location = new Point(4, 24);
            Encrypt.Name = "Encrypt";
            Encrypt.Padding = new Padding(3);
            Encrypt.Size = new Size(790, 444);
            Encrypt.TabIndex = 0;
            Encrypt.Text = "Encrypt";
            Encrypt.UseVisualStyleBackColor = true;
            // 
            // tb_cyphertext
            // 
            tb_cyphertext.Dock = DockStyle.Fill;
            tb_cyphertext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_cyphertext.Location = new Point(335, 245);
            tb_cyphertext.Multiline = true;
            tb_cyphertext.Name = "tb_cyphertext";
            tb_cyphertext.ReadOnly = true;
            tb_cyphertext.ScrollBars = ScrollBars.Vertical;
            tb_cyphertext.Size = new Size(452, 196);
            tb_cyphertext.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(335, 217);
            panel7.Name = "panel7";
            panel7.Size = new Size(452, 28);
            panel7.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(195, 2);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 5;
            label6.Text = "Cyphertext";
            // 
            // tb_plaintext
            // 
            tb_plaintext.Dock = DockStyle.Top;
            tb_plaintext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_plaintext.Location = new Point(335, 32);
            tb_plaintext.Multiline = true;
            tb_plaintext.Name = "tb_plaintext";
            tb_plaintext.ScrollBars = ScrollBars.Vertical;
            tb_plaintext.Size = new Size(452, 185);
            tb_plaintext.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(335, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 29);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(190, 4);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 4;
            label5.Text = "Enter Plaintext";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_create_matrix);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_encrypt);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_key);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 438);
            panel1.TabIndex = 3;
            // 
            // btn_create_matrix
            // 
            btn_create_matrix.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_create_matrix.Location = new Point(21, 377);
            btn_create_matrix.Name = "btn_create_matrix";
            btn_create_matrix.Size = new Size(139, 43);
            btn_create_matrix.TabIndex = 7;
            btn_create_matrix.Text = "Create Matrix";
            btn_create_matrix.UseVisualStyleBackColor = true;
            btn_create_matrix.Click += btn_create_matrix_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 116);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 6;
            label2.Text = "5x5 Matrix";
            // 
            // btn_encrypt
            // 
            btn_encrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_encrypt.Location = new Point(171, 377);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(104, 43);
            btn_encrypt.TabIndex = 5;
            btn_encrypt.Text = "Encrypt";
            btn_encrypt.UseVisualStyleBackColor = true;
            btn_encrypt.Click += btn_encrypt_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(mt_en5);
            panel3.Controls.Add(mt_en4);
            panel3.Controls.Add(mt_en3);
            panel3.Controls.Add(mt_en2);
            panel3.Controls.Add(mt_en1);
            panel3.Controls.Add(mt_en25);
            panel3.Controls.Add(mt_en24);
            panel3.Controls.Add(mt_en23);
            panel3.Controls.Add(mt_en22);
            panel3.Controls.Add(mt_en21);
            panel3.Controls.Add(mt_en20);
            panel3.Controls.Add(mt_en19);
            panel3.Controls.Add(mt_en18);
            panel3.Controls.Add(mt_en17);
            panel3.Controls.Add(mt_en16);
            panel3.Controls.Add(mt_en15);
            panel3.Controls.Add(mt_en14);
            panel3.Controls.Add(mt_en13);
            panel3.Controls.Add(mt_en12);
            panel3.Controls.Add(mt_en11);
            panel3.Controls.Add(mt_en10);
            panel3.Controls.Add(mt_en9);
            panel3.Controls.Add(mt_en8);
            panel3.Controls.Add(mt_en7);
            panel3.Controls.Add(mt_en6);
            panel3.Location = new Point(21, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 214);
            panel3.TabIndex = 4;
            // 
            // mt_en5
            // 
            mt_en5.BackColor = SystemColors.Window;
            mt_en5.Location = new Point(200, 11);
            mt_en5.Name = "mt_en5";
            mt_en5.ReadOnly = true;
            mt_en5.Size = new Size(23, 23);
            mt_en5.TabIndex = 77;
            // 
            // mt_en4
            // 
            mt_en4.BackColor = SystemColors.Window;
            mt_en4.Location = new Point(159, 11);
            mt_en4.Name = "mt_en4";
            mt_en4.ReadOnly = true;
            mt_en4.Size = new Size(23, 23);
            mt_en4.TabIndex = 76;
            // 
            // mt_en3
            // 
            mt_en3.BackColor = SystemColors.Window;
            mt_en3.Location = new Point(116, 11);
            mt_en3.Name = "mt_en3";
            mt_en3.ReadOnly = true;
            mt_en3.Size = new Size(23, 23);
            mt_en3.TabIndex = 75;
            // 
            // mt_en2
            // 
            mt_en2.BackColor = SystemColors.Window;
            mt_en2.Location = new Point(73, 11);
            mt_en2.Name = "mt_en2";
            mt_en2.ReadOnly = true;
            mt_en2.Size = new Size(23, 23);
            mt_en2.TabIndex = 74;
            // 
            // mt_en1
            // 
            mt_en1.AcceptsReturn = true;
            mt_en1.BackColor = SystemColors.Window;
            mt_en1.Location = new Point(30, 11);
            mt_en1.Name = "mt_en1";
            mt_en1.ReadOnly = true;
            mt_en1.Size = new Size(23, 23);
            mt_en1.TabIndex = 73;
            // 
            // mt_en25
            // 
            mt_en25.BackColor = SystemColors.Window;
            mt_en25.Location = new Point(200, 180);
            mt_en25.Name = "mt_en25";
            mt_en25.ReadOnly = true;
            mt_en25.Size = new Size(23, 23);
            mt_en25.TabIndex = 72;
            // 
            // mt_en24
            // 
            mt_en24.BackColor = SystemColors.Window;
            mt_en24.Location = new Point(159, 180);
            mt_en24.Name = "mt_en24";
            mt_en24.ReadOnly = true;
            mt_en24.Size = new Size(23, 23);
            mt_en24.TabIndex = 71;
            // 
            // mt_en23
            // 
            mt_en23.BackColor = SystemColors.Window;
            mt_en23.Location = new Point(116, 180);
            mt_en23.Name = "mt_en23";
            mt_en23.ReadOnly = true;
            mt_en23.Size = new Size(23, 23);
            mt_en23.TabIndex = 70;
            // 
            // mt_en22
            // 
            mt_en22.BackColor = SystemColors.Window;
            mt_en22.Location = new Point(73, 180);
            mt_en22.Name = "mt_en22";
            mt_en22.ReadOnly = true;
            mt_en22.Size = new Size(23, 23);
            mt_en22.TabIndex = 69;
            // 
            // mt_en21
            // 
            mt_en21.BackColor = SystemColors.Window;
            mt_en21.Location = new Point(30, 180);
            mt_en21.Name = "mt_en21";
            mt_en21.ReadOnly = true;
            mt_en21.Size = new Size(23, 23);
            mt_en21.TabIndex = 68;
            // 
            // mt_en20
            // 
            mt_en20.BackColor = SystemColors.Window;
            mt_en20.Location = new Point(201, 139);
            mt_en20.Name = "mt_en20";
            mt_en20.ReadOnly = true;
            mt_en20.Size = new Size(23, 23);
            mt_en20.TabIndex = 67;
            // 
            // mt_en19
            // 
            mt_en19.BackColor = SystemColors.Window;
            mt_en19.Location = new Point(160, 139);
            mt_en19.Name = "mt_en19";
            mt_en19.ReadOnly = true;
            mt_en19.Size = new Size(23, 23);
            mt_en19.TabIndex = 66;
            // 
            // mt_en18
            // 
            mt_en18.BackColor = SystemColors.Window;
            mt_en18.Location = new Point(117, 139);
            mt_en18.Name = "mt_en18";
            mt_en18.ReadOnly = true;
            mt_en18.Size = new Size(23, 23);
            mt_en18.TabIndex = 65;
            // 
            // mt_en17
            // 
            mt_en17.BackColor = SystemColors.Window;
            mt_en17.Location = new Point(74, 139);
            mt_en17.Name = "mt_en17";
            mt_en17.ReadOnly = true;
            mt_en17.Size = new Size(23, 23);
            mt_en17.TabIndex = 64;
            // 
            // mt_en16
            // 
            mt_en16.BackColor = SystemColors.Window;
            mt_en16.Location = new Point(31, 139);
            mt_en16.Name = "mt_en16";
            mt_en16.ReadOnly = true;
            mt_en16.Size = new Size(23, 23);
            mt_en16.TabIndex = 63;
            // 
            // mt_en15
            // 
            mt_en15.BackColor = SystemColors.Window;
            mt_en15.Location = new Point(201, 95);
            mt_en15.Name = "mt_en15";
            mt_en15.ReadOnly = true;
            mt_en15.Size = new Size(23, 23);
            mt_en15.TabIndex = 62;
            // 
            // mt_en14
            // 
            mt_en14.BackColor = SystemColors.Window;
            mt_en14.Location = new Point(160, 95);
            mt_en14.Name = "mt_en14";
            mt_en14.ReadOnly = true;
            mt_en14.Size = new Size(23, 23);
            mt_en14.TabIndex = 61;
            // 
            // mt_en13
            // 
            mt_en13.BackColor = SystemColors.Window;
            mt_en13.Location = new Point(117, 95);
            mt_en13.Name = "mt_en13";
            mt_en13.ReadOnly = true;
            mt_en13.Size = new Size(23, 23);
            mt_en13.TabIndex = 60;
            // 
            // mt_en12
            // 
            mt_en12.BackColor = SystemColors.Window;
            mt_en12.Location = new Point(74, 95);
            mt_en12.Name = "mt_en12";
            mt_en12.ReadOnly = true;
            mt_en12.Size = new Size(23, 23);
            mt_en12.TabIndex = 59;
            // 
            // mt_en11
            // 
            mt_en11.BackColor = SystemColors.Window;
            mt_en11.Location = new Point(31, 95);
            mt_en11.Name = "mt_en11";
            mt_en11.ReadOnly = true;
            mt_en11.Size = new Size(23, 23);
            mt_en11.TabIndex = 58;
            // 
            // mt_en10
            // 
            mt_en10.BackColor = SystemColors.Window;
            mt_en10.Location = new Point(201, 51);
            mt_en10.Name = "mt_en10";
            mt_en10.ReadOnly = true;
            mt_en10.Size = new Size(23, 23);
            mt_en10.TabIndex = 57;
            // 
            // mt_en9
            // 
            mt_en9.BackColor = SystemColors.Window;
            mt_en9.Location = new Point(160, 51);
            mt_en9.Name = "mt_en9";
            mt_en9.ReadOnly = true;
            mt_en9.Size = new Size(23, 23);
            mt_en9.TabIndex = 56;
            // 
            // mt_en8
            // 
            mt_en8.BackColor = SystemColors.Window;
            mt_en8.Location = new Point(117, 51);
            mt_en8.Name = "mt_en8";
            mt_en8.ReadOnly = true;
            mt_en8.Size = new Size(23, 23);
            mt_en8.TabIndex = 55;
            // 
            // mt_en7
            // 
            mt_en7.BackColor = SystemColors.Window;
            mt_en7.Location = new Point(74, 51);
            mt_en7.Name = "mt_en7";
            mt_en7.ReadOnly = true;
            mt_en7.Size = new Size(23, 23);
            mt_en7.TabIndex = 54;
            // 
            // mt_en6
            // 
            mt_en6.BackColor = SystemColors.Window;
            mt_en6.Location = new Point(31, 51);
            mt_en6.Name = "mt_en6";
            mt_en6.ReadOnly = true;
            mt_en6.Size = new Size(23, 23);
            mt_en6.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 3;
            label1.Text = "Enter key";
            // 
            // tb_key
            // 
            tb_key.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_key.Location = new Point(21, 53);
            tb_key.Multiline = true;
            tb_key.Name = "tb_key";
            tb_key.ScrollBars = ScrollBars.Vertical;
            tb_key.Size = new Size(267, 34);
            tb_key.TabIndex = 2;
            // 
            // Decrypt
            // 
            Decrypt.Controls.Add(tb_plaintext1);
            Decrypt.Controls.Add(panel8);
            Decrypt.Controls.Add(tb_cypher_text);
            Decrypt.Controls.Add(panel6);
            Decrypt.Controls.Add(panel4);
            Decrypt.Location = new Point(4, 24);
            Decrypt.Name = "Decrypt";
            Decrypt.Padding = new Padding(3);
            Decrypt.Size = new Size(790, 444);
            Decrypt.TabIndex = 1;
            Decrypt.Text = "Decrypt";
            Decrypt.UseVisualStyleBackColor = true;
            // 
            // tb_plaintext1
            // 
            tb_plaintext1.Dock = DockStyle.Fill;
            tb_plaintext1.Location = new Point(335, 242);
            tb_plaintext1.Multiline = true;
            tb_plaintext1.Name = "tb_plaintext1";
            tb_plaintext1.ReadOnly = true;
            tb_plaintext1.ScrollBars = ScrollBars.Vertical;
            tb_plaintext1.Size = new Size(452, 199);
            tb_plaintext1.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(label8);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(335, 217);
            panel8.Name = "panel8";
            panel8.Size = new Size(452, 25);
            panel8.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(212, 1);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 1;
            label8.Text = "Plaintext";
            // 
            // tb_cypher_text
            // 
            tb_cypher_text.Dock = DockStyle.Top;
            tb_cypher_text.Location = new Point(335, 31);
            tb_cypher_text.Multiline = true;
            tb_cypher_text.Name = "tb_cypher_text";
            tb_cypher_text.ScrollBars = ScrollBars.Vertical;
            tb_cypher_text.Size = new Size(452, 186);
            tb_cypher_text.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(335, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(452, 28);
            panel6.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(189, 3);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 1;
            label7.Text = "Enter Cyphertext";
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_createMatrix);
            panel4.Controls.Add(btn_decrypt);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(tb_key_decrypt);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 438);
            panel4.TabIndex = 0;
            // 
            // btn_createMatrix
            // 
            btn_createMatrix.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_createMatrix.Location = new Point(14, 379);
            btn_createMatrix.Name = "btn_createMatrix";
            btn_createMatrix.Size = new Size(137, 39);
            btn_createMatrix.TabIndex = 5;
            btn_createMatrix.Text = "Create Matrix";
            btn_createMatrix.UseVisualStyleBackColor = true;
            btn_createMatrix.Click += button1_Click;
            // 
            // btn_decrypt
            // 
            btn_decrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_decrypt.Location = new Point(171, 379);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(94, 39);
            btn_decrypt.TabIndex = 4;
            btn_decrypt.Text = "Decrypt";
            btn_decrypt.UseVisualStyleBackColor = true;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(mt5);
            panel5.Controls.Add(mt4);
            panel5.Controls.Add(mt3);
            panel5.Controls.Add(mt2);
            panel5.Controls.Add(mt1);
            panel5.Controls.Add(mt25);
            panel5.Controls.Add(mt24);
            panel5.Controls.Add(mt23);
            panel5.Controls.Add(mt22);
            panel5.Controls.Add(mt21);
            panel5.Controls.Add(mt20);
            panel5.Controls.Add(mt19);
            panel5.Controls.Add(mt18);
            panel5.Controls.Add(mt17);
            panel5.Controls.Add(mt16);
            panel5.Controls.Add(mt15);
            panel5.Controls.Add(mt14);
            panel5.Controls.Add(mt13);
            panel5.Controls.Add(mt12);
            panel5.Controls.Add(mt11);
            panel5.Controls.Add(mt10);
            panel5.Controls.Add(mt9);
            panel5.Controls.Add(mt8);
            panel5.Controls.Add(mt7);
            panel5.Controls.Add(mt6);
            panel5.Location = new Point(16, 140);
            panel5.Name = "panel5";
            panel5.Size = new Size(249, 215);
            panel5.TabIndex = 3;
            // 
            // mt5
            // 
            mt5.BackColor = SystemColors.Window;
            mt5.Location = new Point(196, 11);
            mt5.Name = "mt5";
            mt5.ReadOnly = true;
            mt5.Size = new Size(23, 23);
            mt5.TabIndex = 52;
            // 
            // mt4
            // 
            mt4.BackColor = SystemColors.Window;
            mt4.Location = new Point(155, 11);
            mt4.Name = "mt4";
            mt4.ReadOnly = true;
            mt4.Size = new Size(23, 23);
            mt4.TabIndex = 51;
            // 
            // mt3
            // 
            mt3.BackColor = SystemColors.Window;
            mt3.Location = new Point(112, 11);
            mt3.Name = "mt3";
            mt3.ReadOnly = true;
            mt3.Size = new Size(23, 23);
            mt3.TabIndex = 50;
            // 
            // mt2
            // 
            mt2.BackColor = SystemColors.Window;
            mt2.Location = new Point(69, 11);
            mt2.Name = "mt2";
            mt2.ReadOnly = true;
            mt2.Size = new Size(23, 23);
            mt2.TabIndex = 49;
            // 
            // mt1
            // 
            mt1.AcceptsReturn = true;
            mt1.BackColor = SystemColors.Window;
            mt1.Location = new Point(26, 11);
            mt1.Name = "mt1";
            mt1.ReadOnly = true;
            mt1.Size = new Size(23, 23);
            mt1.TabIndex = 48;
            // 
            // mt25
            // 
            mt25.BackColor = SystemColors.Window;
            mt25.Location = new Point(196, 180);
            mt25.Name = "mt25";
            mt25.ReadOnly = true;
            mt25.Size = new Size(23, 23);
            mt25.TabIndex = 47;
            // 
            // mt24
            // 
            mt24.BackColor = SystemColors.Window;
            mt24.Location = new Point(155, 180);
            mt24.Name = "mt24";
            mt24.ReadOnly = true;
            mt24.Size = new Size(23, 23);
            mt24.TabIndex = 46;
            // 
            // mt23
            // 
            mt23.BackColor = SystemColors.Window;
            mt23.Location = new Point(112, 180);
            mt23.Name = "mt23";
            mt23.ReadOnly = true;
            mt23.Size = new Size(23, 23);
            mt23.TabIndex = 45;
            // 
            // mt22
            // 
            mt22.BackColor = SystemColors.Window;
            mt22.Location = new Point(69, 180);
            mt22.Name = "mt22";
            mt22.ReadOnly = true;
            mt22.Size = new Size(23, 23);
            mt22.TabIndex = 44;
            // 
            // mt21
            // 
            mt21.BackColor = SystemColors.Window;
            mt21.Location = new Point(26, 180);
            mt21.Name = "mt21";
            mt21.ReadOnly = true;
            mt21.Size = new Size(23, 23);
            mt21.TabIndex = 43;
            // 
            // mt20
            // 
            mt20.BackColor = SystemColors.Window;
            mt20.Location = new Point(197, 139);
            mt20.Name = "mt20";
            mt20.ReadOnly = true;
            mt20.Size = new Size(23, 23);
            mt20.TabIndex = 42;
            // 
            // mt19
            // 
            mt19.BackColor = SystemColors.Window;
            mt19.Location = new Point(156, 139);
            mt19.Name = "mt19";
            mt19.ReadOnly = true;
            mt19.Size = new Size(23, 23);
            mt19.TabIndex = 41;
            // 
            // mt18
            // 
            mt18.BackColor = SystemColors.Window;
            mt18.Location = new Point(113, 139);
            mt18.Name = "mt18";
            mt18.ReadOnly = true;
            mt18.Size = new Size(23, 23);
            mt18.TabIndex = 40;
            // 
            // mt17
            // 
            mt17.BackColor = SystemColors.Window;
            mt17.Location = new Point(70, 139);
            mt17.Name = "mt17";
            mt17.ReadOnly = true;
            mt17.Size = new Size(23, 23);
            mt17.TabIndex = 39;
            // 
            // mt16
            // 
            mt16.BackColor = SystemColors.Window;
            mt16.Location = new Point(27, 139);
            mt16.Name = "mt16";
            mt16.ReadOnly = true;
            mt16.Size = new Size(23, 23);
            mt16.TabIndex = 38;
            // 
            // mt15
            // 
            mt15.BackColor = SystemColors.Window;
            mt15.Location = new Point(197, 95);
            mt15.Name = "mt15";
            mt15.ReadOnly = true;
            mt15.Size = new Size(23, 23);
            mt15.TabIndex = 37;
            // 
            // mt14
            // 
            mt14.BackColor = SystemColors.Window;
            mt14.Location = new Point(156, 95);
            mt14.Name = "mt14";
            mt14.ReadOnly = true;
            mt14.Size = new Size(23, 23);
            mt14.TabIndex = 36;
            // 
            // mt13
            // 
            mt13.BackColor = SystemColors.Window;
            mt13.Location = new Point(113, 95);
            mt13.Name = "mt13";
            mt13.ReadOnly = true;
            mt13.Size = new Size(23, 23);
            mt13.TabIndex = 35;
            // 
            // mt12
            // 
            mt12.BackColor = SystemColors.Window;
            mt12.Location = new Point(70, 95);
            mt12.Name = "mt12";
            mt12.ReadOnly = true;
            mt12.Size = new Size(23, 23);
            mt12.TabIndex = 34;
            // 
            // mt11
            // 
            mt11.BackColor = SystemColors.Window;
            mt11.Location = new Point(27, 95);
            mt11.Name = "mt11";
            mt11.ReadOnly = true;
            mt11.Size = new Size(23, 23);
            mt11.TabIndex = 33;
            // 
            // mt10
            // 
            mt10.BackColor = SystemColors.Window;
            mt10.Location = new Point(197, 51);
            mt10.Name = "mt10";
            mt10.ReadOnly = true;
            mt10.Size = new Size(23, 23);
            mt10.TabIndex = 32;
            // 
            // mt9
            // 
            mt9.BackColor = SystemColors.Window;
            mt9.Location = new Point(156, 51);
            mt9.Name = "mt9";
            mt9.ReadOnly = true;
            mt9.Size = new Size(23, 23);
            mt9.TabIndex = 31;
            // 
            // mt8
            // 
            mt8.BackColor = SystemColors.Window;
            mt8.Location = new Point(113, 51);
            mt8.Name = "mt8";
            mt8.ReadOnly = true;
            mt8.Size = new Size(23, 23);
            mt8.TabIndex = 30;
            // 
            // mt7
            // 
            mt7.BackColor = SystemColors.Window;
            mt7.Location = new Point(70, 51);
            mt7.Name = "mt7";
            mt7.ReadOnly = true;
            mt7.Size = new Size(23, 23);
            mt7.TabIndex = 29;
            // 
            // mt6
            // 
            mt6.BackColor = SystemColors.Window;
            mt6.Location = new Point(27, 51);
            mt6.Name = "mt6";
            mt6.ReadOnly = true;
            mt6.Size = new Size(23, 23);
            mt6.TabIndex = 28;
            // 
            // tb_key_decrypt
            // 
            tb_key_decrypt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_key_decrypt.Location = new Point(16, 48);
            tb_key_decrypt.Multiline = true;
            tb_key_decrypt.Name = "tb_key_decrypt";
            tb_key_decrypt.ScrollBars = ScrollBars.Vertical;
            tb_key_decrypt.Size = new Size(283, 35);
            tb_key_decrypt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 116);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 1;
            label4.Text = "5x5 Matrix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 24);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 0;
            label3.Text = "Enter key";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 472);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Encrypt.ResumeLayout(false);
            Encrypt.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Decrypt.ResumeLayout(false);
            Decrypt.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Encrypt;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Button btn_encrypt;
        private Panel panel3;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox27;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label1;
        private TextBox tb_key;
        private TabPage Decrypt;
        private Panel panel4;
        private Label label3;
        private Button btn_decrypt;
        private Panel panel5;
        private TextBox mt5;
        private TextBox mt4;
        private TextBox mt3;
        private TextBox mt2;
        private TextBox mt1;
        private TextBox mt25;
        private TextBox mt24;
        private TextBox mt23;
        private TextBox mt22;
        private TextBox mt21;
        private TextBox mt20;
        private TextBox mt19;
        private TextBox mt18;
        private TextBox mt17;
        private TextBox mt16;
        private TextBox mt15;
        private TextBox mt14;
        private TextBox mt13;
        private TextBox mt12;
        private TextBox mt11;
        private TextBox mt10;
        private TextBox mt9;
        private TextBox mt8;
        private TextBox mt7;
        private TextBox mt6;
        private TextBox tb_key_decrypt;
        private Label label4;
        private Panel panel6;
        private TextBox mt_en5;
        private TextBox mt_en4;
        private TextBox mt_en3;
        private TextBox mt_en2;
        private TextBox mt_en1;
        private TextBox mt_en25;
        private TextBox mt_en24;
        private TextBox mt_en23;
        private TextBox mt_en22;
        private TextBox mt_en21;
        private TextBox mt_en20;
        private TextBox mt_en19;
        private TextBox mt_en18;
        private TextBox mt_en17;
        private TextBox mt_en16;
        private TextBox mt_en15;
        private TextBox mt_en14;
        private TextBox mt_en13;
        private TextBox mt_en12;
        private TextBox mt_en11;
        private TextBox mt_en10;
        private TextBox mt_en9;
        private TextBox mt_en8;
        private TextBox mt_en7;
        private TextBox mt_en6;
        private TextBox tb_cyphertext;
        private Panel panel7;
        private Label label6;
        private TextBox tb_plaintext;
        private Label label5;
        private TextBox tb_plaintext1;
        private Panel panel8;
        private Label label8;
        private TextBox tb_cypher_text;
        private Label label7;
        private Button btn_createMatrix;
        private Button btn_create_matrix;
    }
}

namespace LAB01_BAI6
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.textBoxMatrix00 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix01 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix02 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix12 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix11 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix10 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix20 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix21 = new System.Windows.Forms.TextBox();
            this.textBoxMatrix22 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber00 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber01 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber02 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber12 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber11 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber10 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber20 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber21 = new System.Windows.Forms.TextBox();
            this.textBoxMatrixNumber22 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.comboBoxMatrixSize = new System.Windows.Forms.ComboBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Location = new System.Drawing.Point(185, 54);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(774, 98);
            this.input.TabIndex = 1;
            // 
            // textBoxMatrix00
            // 
            this.textBoxMatrix00.Location = new System.Drawing.Point(390, 211);
            this.textBoxMatrix00.Multiline = true;
            this.textBoxMatrix00.Name = "textBoxMatrix00";
            this.textBoxMatrix00.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix00.TabIndex = 2;
            // 
            // textBoxMatrix01
            // 
            this.textBoxMatrix01.Location = new System.Drawing.Point(429, 211);
            this.textBoxMatrix01.Multiline = true;
            this.textBoxMatrix01.Name = "textBoxMatrix01";
            this.textBoxMatrix01.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix01.TabIndex = 2;
            // 
            // textBoxMatrix02
            // 
            this.textBoxMatrix02.Location = new System.Drawing.Point(468, 211);
            this.textBoxMatrix02.Multiline = true;
            this.textBoxMatrix02.Name = "textBoxMatrix02";
            this.textBoxMatrix02.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix02.TabIndex = 2;
            this.textBoxMatrix02.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxMatrix12
            // 
            this.textBoxMatrix12.Location = new System.Drawing.Point(468, 250);
            this.textBoxMatrix12.Multiline = true;
            this.textBoxMatrix12.Name = "textBoxMatrix12";
            this.textBoxMatrix12.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix12.TabIndex = 2;
            // 
            // textBoxMatrix11
            // 
            this.textBoxMatrix11.Location = new System.Drawing.Point(429, 250);
            this.textBoxMatrix11.Multiline = true;
            this.textBoxMatrix11.Name = "textBoxMatrix11";
            this.textBoxMatrix11.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix11.TabIndex = 2;
            // 
            // textBoxMatrix10
            // 
            this.textBoxMatrix10.Location = new System.Drawing.Point(390, 250);
            this.textBoxMatrix10.Multiline = true;
            this.textBoxMatrix10.Name = "textBoxMatrix10";
            this.textBoxMatrix10.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix10.TabIndex = 2;
            // 
            // textBoxMatrix20
            // 
            this.textBoxMatrix20.Location = new System.Drawing.Point(390, 289);
            this.textBoxMatrix20.Multiline = true;
            this.textBoxMatrix20.Name = "textBoxMatrix20";
            this.textBoxMatrix20.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix20.TabIndex = 2;
            // 
            // textBoxMatrix21
            // 
            this.textBoxMatrix21.Location = new System.Drawing.Point(429, 289);
            this.textBoxMatrix21.Multiline = true;
            this.textBoxMatrix21.Name = "textBoxMatrix21";
            this.textBoxMatrix21.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix21.TabIndex = 2;
            // 
            // textBoxMatrix22
            // 
            this.textBoxMatrix22.Location = new System.Drawing.Point(468, 289);
            this.textBoxMatrix22.Multiline = true;
            this.textBoxMatrix22.Name = "textBoxMatrix22";
            this.textBoxMatrix22.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrix22.TabIndex = 2;
            // 
            // textBoxMatrixNumber00
            // 
            this.textBoxMatrixNumber00.Location = new System.Drawing.Point(594, 211);
            this.textBoxMatrixNumber00.Multiline = true;
            this.textBoxMatrixNumber00.Name = "textBoxMatrixNumber00";
            this.textBoxMatrixNumber00.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber00.TabIndex = 2;
            // 
            // textBoxMatrixNumber01
            // 
            this.textBoxMatrixNumber01.Location = new System.Drawing.Point(633, 211);
            this.textBoxMatrixNumber01.Multiline = true;
            this.textBoxMatrixNumber01.Name = "textBoxMatrixNumber01";
            this.textBoxMatrixNumber01.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber01.TabIndex = 2;
            // 
            // textBoxMatrixNumber02
            // 
            this.textBoxMatrixNumber02.Location = new System.Drawing.Point(672, 211);
            this.textBoxMatrixNumber02.Multiline = true;
            this.textBoxMatrixNumber02.Name = "textBoxMatrixNumber02";
            this.textBoxMatrixNumber02.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber02.TabIndex = 2;
            this.textBoxMatrixNumber02.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxMatrixNumber12
            // 
            this.textBoxMatrixNumber12.Location = new System.Drawing.Point(672, 250);
            this.textBoxMatrixNumber12.Multiline = true;
            this.textBoxMatrixNumber12.Name = "textBoxMatrixNumber12";
            this.textBoxMatrixNumber12.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber12.TabIndex = 2;
            // 
            // textBoxMatrixNumber11
            // 
            this.textBoxMatrixNumber11.Location = new System.Drawing.Point(633, 250);
            this.textBoxMatrixNumber11.Multiline = true;
            this.textBoxMatrixNumber11.Name = "textBoxMatrixNumber11";
            this.textBoxMatrixNumber11.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber11.TabIndex = 2;
            // 
            // textBoxMatrixNumber10
            // 
            this.textBoxMatrixNumber10.Location = new System.Drawing.Point(594, 250);
            this.textBoxMatrixNumber10.Multiline = true;
            this.textBoxMatrixNumber10.Name = "textBoxMatrixNumber10";
            this.textBoxMatrixNumber10.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber10.TabIndex = 2;
            // 
            // textBoxMatrixNumber20
            // 
            this.textBoxMatrixNumber20.Location = new System.Drawing.Point(594, 289);
            this.textBoxMatrixNumber20.Multiline = true;
            this.textBoxMatrixNumber20.Name = "textBoxMatrixNumber20";
            this.textBoxMatrixNumber20.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber20.TabIndex = 2;
            // 
            // textBoxMatrixNumber21
            // 
            this.textBoxMatrixNumber21.Location = new System.Drawing.Point(633, 289);
            this.textBoxMatrixNumber21.Multiline = true;
            this.textBoxMatrixNumber21.Name = "textBoxMatrixNumber21";
            this.textBoxMatrixNumber21.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber21.TabIndex = 2;
            // 
            // textBoxMatrixNumber22
            // 
            this.textBoxMatrixNumber22.Location = new System.Drawing.Point(672, 289);
            this.textBoxMatrixNumber22.Multiline = true;
            this.textBoxMatrixNumber22.Name = "textBoxMatrixNumber22";
            this.textBoxMatrixNumber22.Size = new System.Drawing.Size(33, 33);
            this.textBoxMatrixNumber22.TabIndex = 2;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(369, 355);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(157, 22);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Alphabet characters";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(594, 355);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(126, 22);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Number values";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Location = new System.Drawing.Point(195, 472);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(764, 118);
            this.output.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(397, 406);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(104, 48);
            this.encrypt.TabIndex = 9;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // comboBoxMatrixSize
            // 
            this.comboBoxMatrixSize.FormattingEnabled = true;
            this.comboBoxMatrixSize.Location = new System.Drawing.Point(838, 191);
            this.comboBoxMatrixSize.Name = "comboBoxMatrixSize";
            this.comboBoxMatrixSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMatrixSize.TabIndex = 10;
            this.comboBoxMatrixSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatrixSize_SelectedIndexChanged);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(616, 406);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(89, 48);
            this.decrypt.TabIndex = 11;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 668);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.comboBoxMatrixSize);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.output);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.textBoxMatrixNumber22);
            this.Controls.Add(this.textBoxMatrix22);
            this.Controls.Add(this.textBoxMatrixNumber21);
            this.Controls.Add(this.textBoxMatrix21);
            this.Controls.Add(this.textBoxMatrixNumber20);
            this.Controls.Add(this.textBoxMatrixNumber10);
            this.Controls.Add(this.textBoxMatrix20);
            this.Controls.Add(this.textBoxMatrixNumber11);
            this.Controls.Add(this.textBoxMatrix10);
            this.Controls.Add(this.textBoxMatrixNumber12);
            this.Controls.Add(this.textBoxMatrix11);
            this.Controls.Add(this.textBoxMatrix12);
            this.Controls.Add(this.textBoxMatrixNumber02);
            this.Controls.Add(this.textBoxMatrixNumber01);
            this.Controls.Add(this.textBoxMatrix02);
            this.Controls.Add(this.textBoxMatrixNumber00);
            this.Controls.Add(this.textBoxMatrix01);
            this.Controls.Add(this.textBoxMatrix00);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox textBoxMatrix00;
        private System.Windows.Forms.TextBox textBoxMatrix01;
        private System.Windows.Forms.TextBox textBoxMatrix02;
        private System.Windows.Forms.TextBox textBoxMatrix12;
        private System.Windows.Forms.TextBox textBoxMatrix10;
        private System.Windows.Forms.TextBox textBoxMatrix20;
        private System.Windows.Forms.TextBox textBoxMatrix21;
        private System.Windows.Forms.TextBox textBoxMatrix22;
        private System.Windows.Forms.TextBox textBoxMatrixNumber00;
        private System.Windows.Forms.TextBox textBoxMatrixNumber01;
        private System.Windows.Forms.TextBox textBoxMatrixNumber02;
        private System.Windows.Forms.TextBox textBoxMatrixNumber12;
        private System.Windows.Forms.TextBox textBoxMatrixNumber11;
        private System.Windows.Forms.TextBox textBoxMatrixNumber10;
        private System.Windows.Forms.TextBox textBoxMatrixNumber20;
        private System.Windows.Forms.TextBox textBoxMatrixNumber21;
        private System.Windows.Forms.TextBox textBoxMatrixNumber22;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.ComboBox comboBoxMatrixSize;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox textBoxMatrix11;
    }
}


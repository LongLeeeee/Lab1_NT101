namespace LAB01_BAI4
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
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.KEY = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.check5x5 = new System.Windows.Forms.CheckBox();
            this.check6x6 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Location = new System.Drawing.Point(401, 12);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(624, 252);
            this.input.TabIndex = 0;
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(401, 301);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(624, 314);
            this.output.TabIndex = 1;
            // 
            // KEY
            // 
            this.KEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KEY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KEY.Location = new System.Drawing.Point(39, 115);
            this.KEY.Multiline = true;
            this.KEY.Name = "KEY";
            this.KEY.Size = new System.Drawing.Size(325, 46);
            this.KEY.TabIndex = 2;
            // 
            // decrypt
            // 
            this.decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrypt.Location = new System.Drawing.Point(39, 250);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(325, 57);
            this.decrypt.TabIndex = 3;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Playfair key";
            // 
            // check5x5
            // 
            this.check5x5.AutoSize = true;
            this.check5x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check5x5.Location = new System.Drawing.Point(39, 192);
            this.check5x5.Name = "check5x5";
            this.check5x5.Size = new System.Drawing.Size(84, 20);
            this.check5x5.TabIndex = 6;
            this.check5x5.Text = "5x5 matrix";
            this.check5x5.UseVisualStyleBackColor = true;
            this.check5x5.CheckedChanged += new System.EventHandler(this.check5x5_CheckedChanged);
            // 
            // check6x6
            // 
            this.check6x6.AutoSize = true;
            this.check6x6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check6x6.Location = new System.Drawing.Point(157, 192);
            this.check6x6.Name = "check6x6";
            this.check6x6.Size = new System.Drawing.Size(84, 20);
            this.check6x6.TabIndex = 7;
            this.check6x6.Text = "6x6 matrix";
            this.check6x6.UseVisualStyleBackColor = true;
            this.check6x6.CheckedChanged += new System.EventHandler(this.check6x6_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check6x6);
            this.Controls.Add(this.check5x5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.KEY);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox KEY;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check5x5;
        private System.Windows.Forms.CheckBox check6x6;
        private System.Windows.Forms.Button button1;
    }
}


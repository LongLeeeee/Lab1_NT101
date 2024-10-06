using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1_CAU2
{
    public partial class Form1 : Form
    {

      
        private char[] upperalphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private char[] loweralphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private char[,] vigenereTableUppercase = new char[26, 26];
        private char[,] vigenereTableLowercase = new char[26, 26];


        public Form1() 
        {
            InitializeComponent();
            //taobanvigenereTable();
        }
        
       /* private void taobanvigenereTable()
        {

            // i là số thứ tự của ký tự hàng ngang
            //j là số thứ tụ của ký tự hàng dọc
            // ví dụ i = 2 :B
            //j = 3 
            // => E là thứ tự thứ 5 của hàng ngang 
            for(int i = 0; i < 26; i++)
            {
                for (int j = 0; j<26;j++) 
                {
                    vigenereTable[i,j] = alpahbet[(i+j)%26];

                }
            }
        }*/
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*string b = "";
            string a = shiftnumber.Text;
            int c = 0;
            label4.Text = a;
            if (a == "")
            {
                to_value.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else
            {
                c = int.Parse(a);
                for (int i = 0; i < 26; i++)
                {
                    b += vigenereTable[c, i];

                }
                to_value.Text = b;
            }*/
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private string Decrytion( string ciphertext, int shift)
        {

            string plaint = "";
            
            foreach(char c in ciphertext)
            {
                if (char.IsUpper(c))
                {
                    /*int origianlIndex = Array.IndexOf(alpahbet, c);
                    int origianlIndex = Array.IndexOf(alpahbet, c);
                    plaint += vigenereTable[0, newindex];*/ 
                    // cách dùng bản 


                    int origianlIndex = Array.IndexOf(upperalphabet, c);

                    int newIndex = (origianlIndex - shift+26) % 26;
                    plaint += upperalphabet[newIndex];

                    //int newIndex = (c - 'A' - shift + 26) % 26 + 'A'; //cach dùng mã ascii
                    //plaint += (char)newIndex;





                }
                else if (char.IsLower(c))
                {
                    // int newIndex = (c - 'a' - shift + 26) % 26 + 'a';
                    //plaint += (char)newIndex;
                    int origianlIndex = Array.IndexOf(loweralphabet, c);
                    int newIndex = (origianlIndex - shift+26) % 26;

                    plaint += loweralphabet[newIndex];
                }
                else
                {
                    plaint += c; 
                }
            }
            return plaint;
            //key = 19
        }
        private string encrytion(string ciphertext, int shift)
        {
            string a = "";
            return a;
        }
        private void Plaintext_TextChanged(object sender, EventArgs e)
        {
       


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shift = int.Parse(shiftnumber.Text);
            string ciphertext = Plaintext.Text;
            string plaintext = Decrytion(ciphertext, shift);
            resultshow.Text = plaintext;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01_BAI4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private static int matrixsize = 0; 
        private void decrypt_Click(object sender, EventArgs e)
        {
            string a = input.Text;
            string key = KEY.Text;
            string decryptext = Decrypt(a, key);
            
            output.Text= decryptext.ToUpper();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = input.Text;
            string key = KEY.Text;
            string encryptext = Encrypt(a, key);
          
            output.Text= encryptext.ToUpper();
        }
        private string Decrypt(string cyphertext, string key)
        {
            string plaint = "";
            cyphertext = cyphertext.Replace(" ", "").ToLower();
            //MessageBox.Show(cyphertext);
            key = key.Replace(" ", "").ToLower();

            char[,] matrix = taomatran(key);
            for(int i = 0; i < cyphertext.Length; i = i+2)
            {
                char a = cyphertext[i];
                char b = cyphertext[i + 1];
                int rowa = 0; int cola = 0;
                int rowb = 0; int colb = 0;


                for (int f = 0; f < matrixsize; f++)
                {
                    for (int j = 0; j < matrixsize; j++)
                    {
                        if (matrix[f, j] == a)
                        {
                            rowa = f;
                            cola = j;
                        }
                    }
                }
                for (int f = 0; f < matrixsize; f++)
                {
                    for (int j = 0; j < matrixsize; j++)
                    {
                        if (matrix[f, j] == b)
                        {
                            rowb = f;
                            colb = j;
                        }
                    }
                }
                //(int rowa, int cola) = Timvitri(matrix, a);
                //(int rowb, int colb) = Timvitri(matrix, b); 3 + 5 -1 
                if (rowa == rowb)
                {
                    a = matrix[rowa, (cola + matrixsize-1)%matrixsize];// vì đây là giải mã nên phải lấy bên trái
                    b = matrix[rowb, (colb + matrixsize-1)%matrixsize];
                }else if(cola == colb)
                {
                    a = matrix[(rowa + matrixsize - 1) % matrixsize, cola];
                    b = matrix[(rowb + matrixsize - 1) % matrixsize, colb];
                }else if(rowa != rowb && cola != colb)
                {
                    a = matrix[rowa, colb];
                    b = matrix[rowb, cola];
                }
                plaint += a;
                plaint += b;



            }



            return plaint;
        }

        private string Encrypt(string plaint, string key)
        {
            string ciphertext = "";
            plaint = plaint.Replace(" ", "").ToLower();
            //MessageBox.Show(cyphertext);
            key = key.Replace(" ", "").ToLower();

            char[,] matrix = taomatran(key);
            for (int i = 0; i < plaint.Length; i = i + 2)
            {
                char a = plaint[i];
                char b = plaint[i + 1];
                int rowa = 0; int cola = 0;
                int rowb = 0; int colb = 0;


                for (int f = 0; f < matrixsize; f++)
                {
                    for (int j = 0; j < matrixsize; j++)
                    {
                        if (matrix[f, j] == a)
                        {
                            rowa = f;
                            cola = j;
                        }
                    }
                }
                for (int f = 0; f < matrixsize; f++)
                {
                    for (int j = 0; j < matrixsize; j++)
                    {
                        if (matrix[f, j] == b)
                        {
                            rowb = f;
                            colb = j;
                        }
                    }
                }
                //(int rowa, int cola) = Timvitri(matrix, a);
                //(int rowb, int colb) = Timvitri(matrix, b); 3 + 5 -1 
                if (rowa == rowb)
                {
                    a = matrix[rowa, (cola + matrixsize + 1) % matrixsize];// vì đây là giải mã nên phải lấy bên trái
                    b = matrix[rowb, (colb + matrixsize + 1) % matrixsize];
                }
                else if (cola == colb)
                {
                    a = matrix[(rowa + matrixsize + 1) % matrixsize, cola];
                    b = matrix[(rowb + matrixsize + 1) % matrixsize, colb];
                }
                else if (rowa != rowb && cola != colb)
                {
                    a = matrix[rowa, colb];
                    b = matrix[rowb, cola];
                }
                ciphertext += a;
                ciphertext += b;



            }



            return ciphertext;
        }
       private char[,] taomatran(string key)
        {
            char[,] matrix = new char[matrixsize, matrixsize];
            string alphabet = "abcdefghiklmnopqrstuvwxyz";
            if (matrixsize == 6)
            {
                alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";
            }

                string combined = key + alphabet;
            bool[]used = new bool[36];
            int index = 0;
           
            foreach(char c in combined) {
                if (c == 'j')
                {
                    continue;
                }
                int pos;
                if (char.IsDigit(c)) // Ký tự số (cho ma trận 6x6)
                {
                    pos = c - '0' + 26; // Số bắt đầu từ vị trí 26
                }
                else
                {
                    pos = c - 'a'; // Ký tự thường
                }
                if (!used[pos])// kiểm tra đã tồn tại ký tự
                {
                    matrix[index/matrixsize, index%matrixsize] = c;
                    used[pos] = true;
                    index++;
                }
                
                if (index == matrixsize * matrixsize)
                {
                    break;
                }
            }
            StringBuilder matrixString = new StringBuilder();
            matrixString.AppendLine("Generated Matrix:");
            for (int i = 0; i < matrixsize; i++)
            {
                for (int j = 0; j < matrixsize; j++)
                {
                    matrixString.Append(matrix[i, j] + " ");
                }
                matrixString.AppendLine();
            }

            // Hiển thị ma trận bằng MessageBox
            MessageBox.Show(matrixString.ToString(), "Matrix");


            return matrix;
        }

        //private (int, int ) Timvitri(char[,] matrix, char letter)
        //{


            //throw new ArgumentException($"Character '{letter}' not found in matrix. Please check input.");
        //}



        private char[,] taomatran6x6(string key)
        {
            char[,] matrix6x6 = new char[6, 6];





            return matrix6x6;
        }

        private void check5x5_CheckedChanged(object sender, EventArgs e)
        {
            if (check5x5.Checked)
            {
                check6x6.Checked = false;
                matrixsize = 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void check6x6_CheckedChanged(object sender, EventArgs e)
        {
            if (check6x6.Checked)
            {
                check5x5.Checked = false;
                matrixsize = 6;
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01_BAI6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    this.Controls[$"textBoxMatrix{i}{j}"].Enabled = false;
                }
            }
            comboBoxMatrixSize.Items.AddRange ( new string[] { "2x2", "3x3", "4x4" });
            comboBoxMatrixSize.SelectedIndex = 0;
            this.Controls[$"textBoxMatrix{0}{0}"].Enabled = true;
            this.Controls[$"textBoxMatrix{0}{1}"].Enabled = true;
            this.Controls[$"textBoxMatrix{1}{0}"].Enabled = true;
            this.Controls[$"textBoxMatrix{1}{1}"].Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            int[,] matrixkey = getmatrix();
            if (matrixkey == null) return; // Dừng nếu có lỗi

            int matrixsize = matrixkey.GetLength(0);
            string plaint = PreparePlainText(input.Text.ToUpper(), matrixsize); // Điều chỉnh độ dài chuỗi
            string ciphertext = Encrypt(matrixkey, plaint);
            MessageBox.Show(plaint+"\n"+ matrixsize.ToString());
            output.Text = ciphertext;
        }
        private string PreparePlainText(string text, int matrixSize)
        {
            // Xóa khoảng trắng và các ký tự không cần thiết
            text = text.Replace(" ", "").ToUpper();

            // Nếu độ dài chuỗi không chia hết cho kích thước ma trận, thêm ký tự 'X' vào cuối
            while (text.Length % matrixSize != 0)
            {
                text += 'X';
            }

            return text;
        }
        private void decrypt_Click(object sender, EventArgs e)
        {
            int[,] matrixkey = getmatrix();
            if (matrixkey == null) return; // Dừng nếu có lỗi

            int matrixsize = matrixkey.GetLength(0);
            string ciphertext = input.Text.ToUpper(); // Lấy chuỗi mã hóa
            string plaintext = Decrypt(matrixkey, ciphertext); // Gọi hàm Decrypt đã sửa
            output.Text = plaintext;
        }
        private int[,] getmatrix()
        {
            int matrixSize = GetMatrixSize();
            int[,] keyMatrix = new int[matrixSize, matrixSize];
            for(int i = 0; i< matrixSize; i++)
            {
                for (int j = 0; j<matrixSize; j++)
                {
                    string inputText = this.Controls[$"textBoxMatrix{i}{j}"].Text.ToUpper();
                    if (inputText.Length == 0 || inputText[0] < 'A' || inputText[0] > 'Z')
                    {
                        MessageBox.Show("Vui lòng nhập ký tự từ A đến Z cho ma trận khóa.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    char character = inputText[0];
                    keyMatrix[i, j] = character - 'A';
                }
            }

            return keyMatrix;
        }
        private int GetMatrixSize()
        {
            string selectedSize = comboBoxMatrixSize.SelectedItem.ToString();
            return int.Parse(selectedSize[0].ToString());
        }
        private string Encrypt(int[,] matrixkey, string plaint)
        {
            
            int matrixsize = matrixkey.GetLength(0);
            int plaintsize = plaint.Length;
            StringBuilder ciphertext =  new StringBuilder();
            for(int f = 0; f < plaintsize; f += matrixsize)
            {

                int[] textvector = converttexttovector(plaint.Substring(f, matrixsize), matrixsize);
                int[] encryptvector = new int[matrixsize];

                for (int i = 0; i < matrixsize; i++)
                {
                    for (int j = 0; j < matrixsize; j++)  
                    {
                        encryptvector[i] += matrixkey[i, j] * textvector[j];
                    }
                    encryptvector[i] %= 26;
                }





                ciphertext.Append (convertvectortotext(encryptvector));
            }
            return ciphertext.ToString();




        }
        private int[] converttexttovector(string text, int matrixsize)
        {
            int[]vector = new int[matrixsize];
            for (int i = 0; i < matrixsize; i++)
            {
                vector[i] = text[i] - 'A';
            }
            return vector;
        }
        private string convertvectortotext(int[] encryptvector)
        {
            string ciphertext = "";
            char[]chars = new char[encryptvector.Length];
            for(int i = 0; i < encryptvector.Length; i++)
            {
                chars[i] = (char)((encryptvector[i]%26) + 'A');
            }
            ciphertext = new string(chars);
            return ciphertext;
        }
        private int calculatedaterminant(int[,] matrix)
        {
            int size  = matrix.GetLength(0);
            if(size == 2)
            {
                return (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) % 26;
            }
            else if (size == 3)
            {
                // Tính định thức cho ma trận 3x3
                return (matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                      - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                      + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0])) % 26;
            }
            else
            {
                throw new NotImplementedException("Tính toán định thức cho ma trận 4x4 chưa được cài đặt.");
            }
        }
        private int[,] InverseMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int det = calculatedaterminant(matrix);
            int detInv = ModInverse(det, 26); // Tìm nghịch đảo modulo của định thức

            if (detInv == -1)
            {
                throw new Exception("Ma trận không khả nghịch (determinant = 0).");
            }

            int[,] inverseMatrix = new int[size, size];

            if (size == 2)
            {
                // Ma trận nghịch đảo của 2x2: (1/det) * [[d, -b], [-c, a]]
                inverseMatrix[0, 0] = (matrix[1, 1] * detInv) % 26;
                inverseMatrix[0, 1] = (-matrix[0, 1] * detInv) % 26;
                inverseMatrix[1, 0] = (-matrix[1, 0] * detInv) % 26;
                inverseMatrix[1, 1] = (matrix[0, 0] * detInv) % 26;
            }
            else if (size == 3)
            {
                // Cần tính ma trận phụ đại số (adjugate) cho ma trận 3x3 rồi nhân với nghịch đảo của định thức
                // Đây là một quá trình dài, nên cần cẩn thận.
                int[,] adjugateMatrix = Adjugate(matrix);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        inverseMatrix[i, j] = (adjugateMatrix[i, j] * detInv) % 26;
                        if (inverseMatrix[i, j] < 0) inverseMatrix[i, j] += 26; // Đảm bảo giá trị không âm
                    }
                }
            }
            else
            {
                throw new NotImplementedException("Ma trận 4x4 chưa được cài đặt.");
            }

            return inverseMatrix;
        }
        private int[,] Adjugate(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int[,] adjugateMatrix = new int[size, size];

            if (size == 2)
            {
                // Ma trận adjugate cho ma trận 2x2 là việc hoán đổi hai đường chéo và thêm dấu trừ cho hai phần tử ngoài đường chéo
                adjugateMatrix[0, 0] = matrix[1, 1];
                adjugateMatrix[0, 1] = -matrix[0, 1];
                adjugateMatrix[1, 0] = -matrix[1, 0];
                adjugateMatrix[1, 1] = matrix[0, 0];
            }
            else if (size == 3)
            {
                // Tính ma trận adjugate cho ma trận 3x3
                adjugateMatrix[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) % 26;
                adjugateMatrix[0, 1] = -(matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) % 26;
                adjugateMatrix[0, 2] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) % 26;
                adjugateMatrix[1, 0] = -(matrix[0, 1] * matrix[2, 2] - matrix[0, 2] * matrix[2, 1]) % 26;
                adjugateMatrix[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) % 26;
                adjugateMatrix[1, 2] = -(matrix[0, 0] * matrix[2, 1] - matrix[0, 1] * matrix[2, 0]) % 26;
                adjugateMatrix[2, 0] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) % 26;
                adjugateMatrix[2, 1] = -(matrix[0, 0] * matrix[1, 2] - matrix[0, 2] * matrix[1, 0]) % 26;
                adjugateMatrix[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) % 26;
            }
            else
            {
                throw new NotImplementedException("Ma trận adjugate cho kích thước lớn hơn chưa được cài đặt.");
            }

            // Đảm bảo giá trị adjugate không âm
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (adjugateMatrix[i, j] < 0)
                    {
                        adjugateMatrix[i, j] += 26;
                    }
                }
            }

            return adjugateMatrix;
        }
        private int ModInverse(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                {
                    return x;
                }
            }
            return -1; // Không có nghịch đảo
        }
        private string Decrypt(int[,] matrixkey, string ciphertext)
        {
            int matrixsize = matrixkey.GetLength(0);
            int ciphertextLength = ciphertext.Length;
            StringBuilder plaintext = new StringBuilder(); // Sử dụng StringBuilder để ghép chuỗi giải mã

            // Tìm ma trận nghịch đảo của ma trận khóa
            int[,] inverseMatrix = InverseMatrix(matrixkey);

            // Xử lý từng khối có độ dài bằng kích thước ma trận
            for (int blockStart = 0; blockStart < ciphertextLength; blockStart += matrixsize)
            {
                // Chuyển khối hiện tại thành vector
                int[] textvector = converttexttovector(ciphertext.Substring(blockStart, matrixsize), matrixsize);
                int[] decryptvector = new int[matrixsize];

                // Giải mã vector hiện tại
                for (int i = 0; i < matrixsize; i++)
                {
                    for (int j = 0; j < matrixsize; j++)
                    {
                        decryptvector[i] += inverseMatrix[i, j] * textvector[j];
                    }
                    decryptvector[i] %= 26; // Mod 26 để đảm bảo kết quả nằm trong khoảng từ 0 đến 25
                    if (decryptvector[i] < 0) decryptvector[i] += 26; // Đảm bảo giá trị không âm
                }

                // Chuyển vector giải mã thành chuỗi ký tự và ghép vào kết quả
                plaintext.Append(convertvectortotext(decryptvector));
            }

            return plaintext.ToString(); // Trả về chuỗi giải mã hoàn chỉnh
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxMatrixSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMatrixSize.SelectedIndex == 0)
            {

                
                this.Controls[$"textBoxMatrix{0}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrix{0}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrix{0}{2}"].Enabled = false;
                this.Controls[$"textBoxMatrix{1}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrix{1}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrix{1}{2}"].Enabled = false;
                this.Controls[$"textBoxMatrix{2}{0}"].Enabled =false;
                this.Controls[$"textBoxMatrix{2}{1}"].Enabled = false;
                this.Controls[$"textBoxMatrix{2}{2}"].Enabled = false;
                this.Controls[$"textBoxMatrixNumber{0}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{0}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{0}{2}"].Enabled = false;
                this.Controls[$"textBoxMatrixNumber{1}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{1}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{1}{2}"].Enabled = false;
                this.Controls[$"textBoxMatrixNumber{2}{0}"].Enabled = false;
                this.Controls[$"textBoxMatrixNumber{2}{1}"].Enabled = false;
                this.Controls[$"textBoxMatrixNumber{2}{2}"].Enabled = false;


            }
            else if(comboBoxMatrixSize.SelectedIndex == 1)
            {
                this.Controls[$"textBoxMatrix{0}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrix{0}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrix{0}{2}"].Enabled = true;
                this.Controls[$"textBoxMatrix{1}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrix{1}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrix{1}{2}"].Enabled = true;
                this.Controls[$"textBoxMatrix{2}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrix{2}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrix{2}{2}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{0}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{0}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{0}{2}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{1}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{1}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{1}{2}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{2}{0}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{2}{1}"].Enabled = true;
                this.Controls[$"textBoxMatrixNumber{2}{2}"].Enabled = true;
            }
        }

        private void textBoxMatrix33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatrix32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatrix31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatrix30_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                ConvertCharToNumber();
                
                
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked)
            {
                ConvertNumberToChar();
                
            }
        }
        private void ConvertNumberToChar()
        {
            int[,] matrixkey = getmatrix();
            if (matrixkey == null) return; // Dừng nếu có lỗi

            int matrixsize = matrixkey.GetLength(0);
            for (int i = 0; i < matrixsize; i++)
            {
                for (int j = 0; j < matrixsize; j++)
                {
                    int value;
                    bool isValidNumber = int.TryParse(this.Controls[$"textBoxMatrixNumber{i}{j}"].Text, out value);

                    if (isValidNumber && value >= 0 && value < 26)
                    {
                        this.Controls[$"textBoxMatrix{i}{j}"].Text = ((char)(value + 'A')).ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Invalid number at position ({i}, {j}). Please enter a number between 0 and 25.");
                    }
                }
            }
        }
        private void ConvertCharToNumber()
        {

            int[,] matrixkey = getmatrix();
            if (matrixkey == null) return; // Dừng nếu có lỗi

            int matrixsize = matrixkey.GetLength(0);
            for (int i = 0; i < matrixsize; i++)
            {
                for (int j = 0; j < matrixsize; j++)
                {
                    char character = this.Controls[$"textBoxMatrix{i}{j}"].Text.ToUpper()[0];

                    if (char.IsLetter(character))
                    {
                        int value = character - 'A'; // Lấy giá trị từ A=0, B=1, ..., Z=25
                        this.Controls[$"textBoxMatrixNumber{i}{j}"].Text = value.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Invalid character at position ({i}, {j}). Please enter a letter from A-Z.");
                    }
                }
            }
        }
    }
    
}
    
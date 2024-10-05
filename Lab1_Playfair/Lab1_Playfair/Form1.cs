using System;
using System.Reflection;
using System.Text;

namespace Lab1_Playfair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[,] Encrypt_Matrix = new String[5, 5];
        private string[,] Decrypt_Matrix = new String[5, 5];
        private string Plaintext = "";
        private string Plaintext1 = "";
        private string Cyphertext = "";
        bool isCreateMatrix1 = false;
        bool isCreateMatrix2 = false;
        private string ascii = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        private string ascii2 = "ABCDEFGHJKLMNOPQRSTUVWXYZ";

        private void btn_encrypt_Click_1(object sender, EventArgs e)
        {
            tb_cyphertext.Clear();
            if (tb_plaintext == null || !isCreateMatrix1)
            {
                MessageBox.Show("Hãy nhập đầy đủ");
                return;
            }
            Plaintext = tb_plaintext.Text.Trim();
            Plaintext = Plaintext.ToUpper();
            if ((Plaintext.Length % 2 == 0))
            {
                Plaintext += "X";
            }
            List<String> temp_list = new List<String>();
            string temp = "";
            foreach (var item in Plaintext)
            {
                if (item != ' ')
                {
                    temp += item.ToString();
                    if (temp.Length == 2)
                    {
                        temp_list.Add(temp);
                        temp = "";
                    }
                }
            }
            foreach (var item in temp_list)
            {
                Index index1 = new Index();
                Index index2 = new Index();
                int m = 0;
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (item[0].ToString() == Encrypt_Matrix[i, j])
                        {
                            index1.x = i;
                            index1.y = j;
                            m++;
                        }
                        if (item[1].ToString() == Encrypt_Matrix[i, j])
                        {
                            index2.x = i;
                            index2.y = j;
                            m++;

                        }
                    }
                }
                if (m == 2)
                {
                    if (index1.y == index2.y)
                    {
                        Cyphertext += shiftWithX(index1);
                        Cyphertext += shiftWithX(index2);
                    }
                    else if (index1.x == index2.x)
                    {
                        Cyphertext += shiftWithY(index1);
                        Cyphertext += shiftWithY(index2);
                    }
                    else if (index1.y != index2.y && index1.x != index2.x)
                    {
                        Cyphertext += swapPosition(index1, index2.y);
                        Cyphertext += swapPosition(index2, index1.y);
                    }
                }
            }
            tb_cyphertext.Text = Cyphertext;
        }
        private string shiftWithX(Index index)
        {
            index.x++;
            if (index.x > 4)
            {
                index.x = 0;
            }
            return Encrypt_Matrix[index.x, index.y];
        }
        private string shiftWithY(Index index)
        {
            index.y++;
            if (index.y > 4)
            {
                index.y = 0;
            }
            return Encrypt_Matrix[index.x, index.y];
        }
        private string swapPosition(Index index1, int offset)
        {
            int temp = offset;
            return Encrypt_Matrix[index1.x, temp];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_key_decrypt == null)
            {
                MessageBox.Show("Hãy nhập key!!");
                return;
            }
            isCreateMatrix2 = true;
            string en_key = tb_key_decrypt.Text.Trim();
            en_key = en_key.ToUpper();
            string temp = "";
            foreach (var item in en_key)
            {
                if (temp.Contains(item) || item == ' ')
                {
                    continue;
                }
                temp += item;
            }
            if (temp.Contains("J"))
            {
                foreach (var item in ascii2)
                {
                    if (temp.Contains(item))
                    {
                        continue;
                    }
                    temp += item;
                }
            }
            else
            {
                foreach (var item in ascii)
                {
                    if (temp.Contains(item))
                    {
                        continue;
                    }
                    temp += item;
                }
            }
            Thread newThread = new Thread(() => updateMatrix(temp));
            newThread.Start();
            newThread.IsBackground = true;
            Thread newThread1 = new Thread(() => updateMatrix1(temp));
            newThread1.Start();
            newThread1.IsBackground = true;
        }

        private void updateMatrix(string matrix)
        {
            int i = 1;
            foreach (var item in matrix)
            {
                TextBox tb = this.Controls.Find("mt" + i, true).FirstOrDefault() as TextBox;
                if (tb != null)
                {
                    Invoke(new Action(() =>
                    {
                        tb.Text = item.ToString();
                    }));
                }
                i++;
            }
        }
        private void updateMatrix1(string matrix)
        {
            int m = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Decrypt_Matrix[i, j] = matrix[m].ToString();
                    m++;
                }
            }
        }
        private void btn_create_matrix_Click(object sender, EventArgs e)
        {
            if (tb_key == null)
            {
                MessageBox.Show("Hãy nhập key!!");
                return;
            }
            isCreateMatrix1 = true;
            string en_key = tb_key.Text.Trim();
            en_key = en_key.ToUpper();
            string temp = "";
            foreach (var item in en_key)
            {
                if (temp.Contains(item) || item == ' ')
                {
                    continue;
                }
                temp += item;
            }
            if (temp.Contains("J"))
            {
                foreach (var item in ascii2)
                {
                    if (temp.Contains(item))
                    {
                        continue;
                    }
                    temp += item;
                }
            }
            else
            {
                foreach (var item in ascii)
                {
                    if (temp.Contains(item))
                    {
                        continue;
                    }
                    temp += item;
                }
            }
            Thread newThread = new Thread(() => updateMatrix2(temp));
            newThread.Start();
            newThread.IsBackground = true;
            Thread newThread1 = new Thread(() => updateMatrix3(temp));
            newThread1.Start();
            newThread1.IsBackground = true;
        }
        private void updateMatrix2(string matrix)
        {
            int i = 1;
            foreach (var item in matrix)
            {
                TextBox tb = this.Controls.Find("mt_en" + i, true).FirstOrDefault() as TextBox;
                if (tb != null)
                {
                    Invoke(new Action(() =>
                    {
                        tb.Text = item.ToString();
                    }));
                }
                i++;
            }
        }
        private void updateMatrix3(string matrix)
        {
            int m = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Invoke(new Action(() =>
                    {
                        Encrypt_Matrix[i, j] = matrix[m].ToString();
                    }));
                    m++;
                }
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            tb_plaintext1.Clear();
            if (tb_cypher_text == null || !isCreateMatrix2)
            {
                MessageBox.Show("Hãy nhập đầy đủ");
                return;
            }
            Cyphertext = tb_cypher_text.Text.Trim();
            Cyphertext = Cyphertext.ToUpper();
            List<String> temp_list = new List<String>();
            string temp = "";
            foreach (var item in Cyphertext)
            {
                if (item != ' ')
                {
                    temp += item.ToString();
                    if (temp.Length == 2)
                    {
                        temp_list.Add(temp);
                        temp = "";
                    }
                }
            }
            foreach (var item in temp_list)
            {
                Index index1 = new Index();
                Index index2 = new Index();
                int m = 0;
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (item[0].ToString() == Decrypt_Matrix[i, j])
                        {
                            index1.x = i;
                            index1.y = j;
                            m++;
                        }
                        if (item[1].ToString() == Decrypt_Matrix[i, j])
                        {
                            index2.x = i;
                            index2.y = j;
                            m++;

                        }
                    }
                }
                if (m == 2)
                {
                    if (index1.y == index2.y)
                    {
                        Plaintext1 += shiftWithX1(index1);
                        Plaintext1 += shiftWithX1(index2);
                    }
                    else if (index1.x == index2.x)
                    {
                        Plaintext1 += shiftWithY1(index1);
                        Plaintext1 += shiftWithY1(index2);
                    }
                    else if (index1.y != index2.y && index1.x != index2.x)
                    {
                        Plaintext1 += swapPosition1(index1, index2.y);
                        Plaintext1 += swapPosition1(index2, index1.y);
                    }
                }
            }
            tb_plaintext1.Text = Plaintext1;
        }
        private string shiftWithX1(Index index)
        {
            index.x--;
            if (index.x < 4)
            {
                index.x = 0;
            }
            return Decrypt_Matrix[index.x, index.y];
        }
        private string shiftWithY1(Index index)
        {
            index.y--;
            if (index.y < 4)
            {
                index.y = 0;
            }
            return Decrypt_Matrix[index.x, index.y];
        }
        private string swapPosition1(Index index1, int offset)
        {
            int temp = offset;
            return Decrypt_Matrix[index1.x, temp];
        }
    }
}

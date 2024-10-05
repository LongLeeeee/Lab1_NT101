namespace Lab1_Caesar_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string plaintText = "";
        private int encrypt_key = 0;
        private List<char> cypherText = new List<char>();

        private int convertToInt(char ascii)
        {
            switch (ascii)
            {
                case 'A':
                case 'a':
                    return 0;
                case 'B':
                case 'b':
                    return 1;
                case 'C':
                case 'c':
                    return 2;
                case 'D':
                case 'd':
                    return 3;
                case 'E':
                case 'e':
                    return 4;
                case 'F':
                case 'f':
                    return 5;
                case 'G':
                case 'g':
                    return 6;
                case 'H':
                case 'h':
                    return 7;
                case 'I':
                case 'i':
                    return 8;
                case 'J':
                case 'j':
                    return 9;
                case 'K':
                case 'k':
                    return 10;
                case 'L':
                case 'l':
                    return 11;
                case 'M':
                case 'm':
                    return 12;
                case 'N':
                case 'n':
                    return 13;
                case 'O':
                case 'o':
                    return 14;
                case 'P':
                case 'p':
                    return 15;
                case 'Q':
                case 'q':
                    return 16;
                case 'R':
                case 'r':
                    return 17;
                case 'S':
                case 's':
                    return 18;
                case 'T':
                case 't':
                    return 19;
                case 'U':
                case 'u':
                    return 20;
                case 'V':
                case 'v':
                    return 21;
                case 'W':
                case 'w':
                    return 22;
                case 'X':
                case 'x':
                    return 23;
                case 'Y':
                case 'y':
                    return 24;
                case 'Z':
                case 'z':
                    return 25;
            }
            return ' ';
        }
        private char convertToCharacter(int asciiValue)
        {
            switch (asciiValue)
            {
                case 0: return 'A';
                case 1: return 'B';
                case 2: return 'C';
                case 3: return 'D';
                case 4: return 'E';
                case 5: return 'F';
                case 6: return 'G';
                case 7: return 'H';
                case 8: return 'I';
                case 9: return 'J';
                case 10: return 'K';
                case 11: return 'L';
                case 12: return 'M';
                case 13: return 'N';
                case 14: return 'O';
                case 15: return 'P';
                case 16: return 'Q';
                case 17: return 'R';
                case 18: return 'S';
                case 19: return 'T';
                case 20: return 'U';
                case 21: return 'V';
                case 22: return 'W';
                case 23: return 'X';
                case 24: return 'Y';
                case 25: return 'Z';
            }
            return ' ';
        }

        private string cypher_Text = "";
        private int decrypt_key = 0;
        private List<char> plaint_text;

        private Dictionary<string, string> decrypt_without_key_result_list = new Dictionary<string, string>();

        private void btn_decrypt_without_key_Click_1(object sender, EventArgs e)
        {
            this.cypher_Text = tb_cypher_text.Text.Trim();
            for (int i = 0; i < 26; i++)
            {
                string mem_plaintext = "";
                this.decrypt_key = i;
                if (string.IsNullOrEmpty(cypher_Text))
                {
                    MessageBox.Show("Hãy nhập cyphertext");
                    return;
                }
                foreach (char item in cypher_Text)
                {
                    if (!char.IsLetter(item))
                    {
                        mem_plaintext += item;
                        continue;
                    }
                    int asciiValue = convertToInt(item);
                    int temp = (asciiValue - decrypt_key + 26) % 26;
                    char c = convertToCharacter(temp);
                    mem_plaintext += c;
                }
                decrypt_without_key_result_list.Add($"Case {i}: ", mem_plaintext);
                rtb_decrypt.AppendText($"Case {i}: " + mem_plaintext + "\r\n \r\n");
            }
        }

        private void btn_decrypt_Click_1(object sender, EventArgs e)
        {
            rtb_decrypt.Clear();
            plaint_text = new List<char>();
            this.cypher_Text = tb_cypher_text.Text.Trim();
            this.decrypt_key = Convert.ToInt32(tb_key_de.Text.Trim());
            if (string.IsNullOrEmpty(cypher_Text) || this.decrypt_key == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ");
                return;
            }
            foreach (char item in cypher_Text)
            {
                if (item == ' ')
                {
                    plaint_text.Add(item);
                    continue;
                }
                int asciiValue = convertToInt(item);
                int temp = (asciiValue - decrypt_key + 26) % 26;
                char c = convertToCharacter(temp);
                plaint_text.Add(c);
            }

            foreach (var item in plaint_text)
            {
                rtb_decrypt.AppendText(item.ToString());
            }
        }

        private void btn_encrypt_Click_1(object sender, EventArgs e)
        {
            rtb_en_result.Clear();
            this.plaintText = tb_plaintext.Text.Trim();
            this.encrypt_key = Convert.ToInt32(tb_key.Text.Trim());
            if (string.IsNullOrEmpty(plaintText) || this.encrypt_key == 0)
            {
                return;
            }
            foreach (char item in plaintText)
            {
                if (item == ' ')
                {
                    cypherText.Add(item);
                    continue;
                }
                int asciiValue = convertToInt(item);
                int temp = (asciiValue + encrypt_key) % 26;
                char c = convertToCharacter(temp);
                cypherText.Add(c);
            }

            foreach (var item in cypherText)
            {
                rtb_en_result.AppendText(item.ToString());
            }
        }
    }
}

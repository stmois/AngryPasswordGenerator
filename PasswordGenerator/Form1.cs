using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            copyLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            copyLabel.Visible = false;

            if (!AreInputsValid())
            {
                return;
            }

            var availableSymbols = ProcessCheckBoxes();
            var randomPassword = GenerateRandomPassword(availableSymbols);

            resultBox.Text = randomPassword;
        }

        private string GenerateRandomPassword(char[] availableSymbols)
        {
            var randomPassword = string.Empty;
            var pwdLength = Convert.ToInt32(passwordLength.Text); 
            
            for (var i = 0; i < pwdLength; i++)
            {
                randomPassword += availableSymbols[new Random().Next(availableSymbols.Length)].ToString();
            }

            return randomPassword;
        }

        private char[] ProcessCheckBoxes()
        {
            const string LATIN_SMALL_SYMBOLS = "qwertyuiopasdfghjklzxcvbnm";
            const string LATIN_BIG_SYMBOLS = "QWERTYUIOPASDFGHJKLZXCVBNM";
            const string NUMBERS = "0123456789";
            const string CYRILLIC_SMALL_SYMBOLS = "йцукенгшщзхъфывапролджэячсмитьбю";
            const string CYRILLIC_BIG_SYMBOLS = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            const string SYMBOLS = "!@#$%^&*()-_=+<>";

            var availableSymbols = string.Empty;

            if (latinSmall.Checked)
            {
                availableSymbols += LATIN_SMALL_SYMBOLS;
            }

            if (latinBig.Checked)
            {
                availableSymbols += LATIN_BIG_SYMBOLS;
            }

            if (numbers.Checked)
            {
                availableSymbols += NUMBERS;
            }

            if (cyrillicSmall.Checked)
            {
                availableSymbols += CYRILLIC_SMALL_SYMBOLS;
            }

            if (cyrillicBig.Checked)
            {
                availableSymbols += CYRILLIC_BIG_SYMBOLS;
            }

            if (symbols.Checked)
            {
                availableSymbols += SYMBOLS;
            }

            return availableSymbols.ToCharArray();
        }

        private bool AreInputsValid()
        {
            const int MIN_PASSWORD_LENGTH = 3;
            const int MAX_PASSWORD_LENGTH = 60;

            if (latinSmall.Checked == false
                && latinBig.Checked == false
                && cyrillicSmall.Checked == false
                && cyrillicBig.Checked == false
                && numbers.Checked == false
                && symbols.Checked == false)
            {
                MessageBox.Show("Необходимо выбрать хотя бы одну галочку");
                return false;
            }

            if (string.IsNullOrWhiteSpace(passwordLength.Text))
            {
                MessageBox.Show("Необходимо заполнить длину нового пароля");
                return false;
            }

            if (int.TryParse(passwordLength.Text, out _) == false)
            {
                MessageBox.Show("Неверное значение в поле длина пароля");
                return false;
            }

            if (int.TryParse(passwordLength.Text, out var length) 
                && (length > MAX_PASSWORD_LENGTH || length < MIN_PASSWORD_LENGTH))
            {
                MessageBox.Show($@"Длина пароля может быть от {MIN_PASSWORD_LENGTH} до {MAX_PASSWORD_LENGTH} символов");
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(resultBox.Text))
            {
                Clipboard.SetText(resultBox.Text);
                copyLabel.Visible = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Tool
{
    public partial class CTool : Form
    {
        public CTool()
        {
            InitializeComponent();
        }

        private void encrypt_Button_Click(object sender, EventArgs e)
        {
            if (decrypted_Text.Text.Length > 0 && input_Alphabet.Text.Length > 0 && inputKey.Text.Length > 0)
            {
                vigenere_Cipher vigenere = new vigenere_Cipher();
                vigenere.alphabet = input_Alphabet.Text.ToUpper();
                vigenere.plainText = decrypted_Text.Text.ToUpper();
                vigenere.key = inputKey.Text.ToUpper();

                vigenere.SetKeyStream(vigenere.keyStream, vigenere.plainText, vigenere.key);
                vigenere.EnumerationAlphabet(vigenere.Alphabet, vigenere.alphabet);
                vigenere.CheckTextPairsWithAlphabet(vigenere.alphabet, vigenere.key, vigenere.pair);
                if (vigenere.pair == false)
                {
                    MessageBox.Show("key and alphabet doesn't pair");
                    return;
                }
                vigenere.CheckTextPairsWithAlphabet(vigenere.alphabet, vigenere.plainText, vigenere.pair);
                if (vigenere.pair == false)
                {
                    MessageBox.Show("text and alphabet doesn't pair");
                    return;
                }
                vigenere.EnumerationKeyStream(vigenere.KeyStream, vigenere.Alphabet, vigenere.keyStream, vigenere.plainText, vigenere.alphabet);
                vigenere.EnumerationCipherText(vigenere.cipherNumber, vigenere.Alphabet, vigenere.KeyStream, vigenere.alphabet, vigenere.plainText);
                vigenere.Encrypt(vigenere.CipherText, vigenere.cipherNumber, vigenere.Alphabet, vigenere.alphabet, vigenere.plainText);

                for (int i = 0; i < vigenere.plainText.Length; i++)
                {
                    encrypted_Text.Text += vigenere.CipherText[i].ToString();

                    if (encrypted_Text.Text.Length > vigenere.plainText.Length)
                    {
                        encrypted_Text.Text = "";
                        for (int j = 0; j < vigenere.plainText.Length; j++)
                            encrypted_Text.Text += vigenere.CipherText[j].ToString();
                    }
                }
            }

        }

        private void decrypt_Button_Click(object sender, EventArgs e)
        {
            if (encrypted_Text.Text.Length > 0 && input_Alphabet.Text.Length > 0 && inputKey.Text.Length > 0)
            {
                vigenere_Cipher vigenere = new vigenere_Cipher();
                vigenere.alphabet = input_Alphabet.Text.ToUpper();
                vigenere.cipherText = encrypted_Text.Text.ToUpper();
                vigenere.key = inputKey.Text.ToUpper();

                vigenere.SetKeyStream(vigenere.keyStream, vigenere.cipherText, vigenere.key);
                vigenere.EnumerationAlphabet(vigenere.Alphabet, vigenere.alphabet);
                vigenere.CheckTextPairsWithAlphabet(vigenere.alphabet, vigenere.key, vigenere.pair);
                if (vigenere.pair == false)
                {
                    MessageBox.Show("key and alphabet doesn't pair");
                    return;
                }
                vigenere.CheckTextPairsWithAlphabet(vigenere.alphabet, vigenere.cipherText, vigenere.pair);
                if (vigenere.pair == false)
                {
                    MessageBox.Show("text and alphabet doesn't pair");
                    return;
                }


                vigenere.EnumerationKeyStream(vigenere.KeyStream, vigenere.Alphabet, vigenere.keyStream, vigenere.cipherText, vigenere.alphabet);
                vigenere.EnumerationCipherText(vigenere.cipherNumber, vigenere.Alphabet, vigenere.KeyStream, vigenere.alphabet, vigenere.cipherText);
                vigenere.EnumerationPlainText(vigenere.plainNumber, vigenere.cipherNumber, vigenere.Alphabet, vigenere.KeyStream, vigenere.alphabet, vigenere.cipherText);
                vigenere.Decyrpt(vigenere.PlainText, vigenere.cipherNumber, vigenere.Alphabet, vigenere.alphabet, vigenere.cipherText);

                for (int i = 0; i < vigenere.cipherText.Length; i++)
                {
                    decrypted_Text.Text += vigenere.PlainText[i].ToString();

                    if (decrypted_Text.Text.Length > vigenere.cipherText.Length)
                    {
                        decrypted_Text.Text = "";
                        for (int j = 0; j < vigenere.cipherText.Length; j++)
                            decrypted_Text.Text += vigenere.PlainText[j].ToString();
                    }
                }
            }
        }
       
        private void Input_Alphabet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                warning.Visible = true;
            }

            else
                warning.Visible = false;
        }

        private void InputKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                warning.Visible = true;
            }
            else
                warning.Visible = false;
        }

        private void Decrypted_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                warning.Visible = true;
            }

            else
                warning.Visible = false;
        }

        private void Encrypted_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                warning.Visible = true;
            }

            else
                warning.Visible = false;
        }

    }
}

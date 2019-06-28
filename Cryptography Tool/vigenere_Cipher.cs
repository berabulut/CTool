using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Tool
{
    class vigenere_Cipher
    {
        public string plainText { get; set; }
        public string cipherText { get; set; }
        public string key { get; set; }
        public string alphabet { get; set; }

        public string[] CipherText;
        public string[] PlainText;
        public string[] keyStream;
        public int[] cipherNumber;
        public int[] plainNumber;
        public bool pair;
        

        public List<Tuple<string, int>> Alphabet = new List<Tuple<string, int>>();
        public List<Tuple<string, int>> KeyStream = new List<Tuple<string, int>>();
       

       

        public void CheckTextPairsWithAlphabet(string alphabet, string text, bool pair)
        {
            string[] check = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < this.alphabet.Length; j++)
                    if(text[i] == this.alphabet[j])
                    {
                        check[i] = this.alphabet[j].ToString();
                    }
            }

            if (check[1]!= null && check.Length == text.Length)
                this.pair = true;
            else
                this.pair = false;            
        }

        public void SetKeyStream(string [] keyStream, string pplainText, string key)
        {
            var x = pplainText.Length;           
            this.keyStream = new string[x];

            for (int i = 0; i < x; i++)
            {
                this.keyStream[i] = this.key[i % key.Length].ToString();
            }
            string.Join("", this.keyStream);
        }


        public void EnumerationAlphabet(List<Tuple<string, int>> Alphabet, string alphabet)
        {

            for (int i = 0; i < this.alphabet.Length; i++)
            {
                this.Alphabet.Add(new Tuple<string, int>(this.alphabet[i].ToString(), i));
            }
        }

        public void EnumerationKeyStream(List<Tuple<string, int>> KeyStream, List<Tuple<string, int>> Alphabet, string[] keyStream, string text, string alphabet)
        {
            for (int i = 0; i < text.Length; i++)    //Giving numbers to KeyStream according to Alphabet
            {
                for (int j = 0; j < this.alphabet.Length; j++)
                {
                    if (this.Alphabet[j].Item1 == keyStream[i % key.Length])
                        this.KeyStream.Add(new Tuple<string, int>(this.keyStream[i], this.Alphabet[j].Item2));
                }
            }
        }

        
        public void EnumerationCipherText(int[] cipherNumber, List<Tuple<string, int>> Alphabet, List<Tuple<string, int>> KeyStream, string alphabet, string text)
        {
            this.cipherNumber = new int[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < this.alphabet.Length; j++)
                {
                    if (text[i].ToString() == this.Alphabet[j].Item1)
                    {
                        this.cipherNumber[i] = (this.Alphabet[j].Item2 + this.KeyStream[i].Item2) % this.alphabet.Length;
                    }
                }
            }
        }

        public void Encrypt(string[] CipherText, int[] cipherNumber, List<Tuple<string, int>> Alphabet, string alphabet, string plainText)
        {
            this.CipherText = new string[this.plainText.Length];

            for (int i = 0; i < this.cipherNumber.Length; i++)
            {
                for (int j = 0; j < this.alphabet.Length; j++)
                {
                    if (this.cipherNumber[i] == this.Alphabet[j].Item2)
                    {
                        this.CipherText[i] = this.Alphabet[j].Item1;
                    }
                }
            }
        }

        public void EnumerationPlainText(int[] plainNumber, int[] cipherNumber, List<Tuple<string, int>> Alphabet, List<Tuple<string, int>> KeyStream, string alphabet, string cipherText)
        {
            this.plainNumber = new int[this.cipherText.Length];

            for (int i = 0; i < this.cipherText.Length; i++)
            {
                for (int j = 0; j < this.alphabet.Length; j++)
                {
                    if (this.cipherText[i].ToString() == this.Alphabet[j].Item1)
                    {
                        this.cipherNumber[i] = this.Alphabet[j].Item2;
                    }
                }
            }

            for (int i = 0; i < this.cipherText.Length; i++)
            {
                this.plainNumber[i] = this.cipherNumber[i] - this.KeyStream[i].Item2;
                if (this.plainNumber[i] < 0)
                    this.plainNumber[i] += this.cipherText.Length;
            }
        }


        public void Decyrpt(string[] PlainText, int[] plainNumber, List<Tuple<string, int>> Alphabet, string alphabet, string cipherText)
        {
            this.PlainText = new string[this.cipherText.Length];

            for (int i = 0; i < this.cipherText.Length; i++)
            {
                for (int j = 0; j < this.alphabet.Length; j++)
                {
                    if (this.plainNumber[i] == this.Alphabet[j].Item2)
                    {
                        this.PlainText[i] = this.Alphabet[j].Item1;
                    }
                }
            }
        }
    }
}

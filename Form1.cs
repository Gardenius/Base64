using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Base64
{
    public partial class Form1 : Form
    {
        
        public string b64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        public Form1()
        {
            InitializeComponent();
            Input_Text.Text = "Wybierz plik";
            Output_Text.Text = "Wybierz folder zapisu";
        }
        
        private void Koduj_Click(object sender, EventArgs e)
        {
            if (Input_Text.Text == "Wybierz plik")
            {
                MessageBox.Show("Wybierz plik!");
            }
            else if (Output_Text.Text == "Wybierz folder zapisu")
            {
                MessageBox.Show("Wybierz folder zapisu!");
            }
            else
            {
                Kodowanie();
                MessageBox.Show("Ukończono kodowanie.");
            }
            
        }

        private void dekoduj_Click(object sender, EventArgs e)
        {
            if (Input_Text.Text == "Wybierz plik")
            {
                MessageBox.Show("Wybierz plik!");
            }
            else if (Output_Text.Text == "Wybierz folder zapisu")
            {
                MessageBox.Show("Wybierz folder zapisu!");
            }
            else
            {
                Dekodowanie();
                MessageBox.Show("Ukończono dekodowanie.");
            }
            
        }

        private void Kodowanie()
        {
            string input = Input_Text.Text;
            string output = Output_Text.Text;
            File.CreateText(Output_Text.Text + "\\CODED_FILE").Close();
            byte[] fileBytes = File.ReadAllBytes(input);
            StringBuilder sb = new StringBuilder();
            int Counter = 0;
            string i = ""; //Padding 1
            int d = 0;
            string base64 = "";

            foreach (byte b in fileBytes)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            int x = sb.ToString().Length;
            foreach (char b in sb.ToString())
            {
                i += b;
                Counter++;

                if (x % 6 == 4 && Counter == x) i += "00";
                else if (x % 6 == 2 && Counter == x) i += "0000";

                if (i.Length % 6 == 0)
                {
                    d = Convert.ToInt16((i), 2);
                    i = "";
                    base64 += b64[d];
                    if (base64.Length == 2000)
                    {
                        using (StreamWriter sw = File.AppendText(output + "\\CODED_FILE"))
                        {
                            sw.Write(base64);
                            base64 = "";
                        }
                    }
                }

            }

            if (x % 6 == 4) base64 += "=";
            if (x % 6 == 2) base64 += "==";
            using (StreamWriter sw = File.AppendText(output + "\\CODED_FILE"))
            {
                sw.Write(base64);
                base64 = "";
            }
        }
        private void Dekodowanie()
        {
            File.CreateText(Output_Text.Text + "\\DECODED_FILE").Close();
            string input = Input_Text.Text;
            string output = Output_Text.Text;
            string tekst = File.ReadAllText(input);
            string x = "";
            string y = "";
            int numOfBytes = 0;
            byte[] bytes = new byte[numOfBytes];

            foreach (char b in tekst)
            {
                x += Convert.ToString((b64.IndexOf(b)), 2).PadLeft(6, '0');
                if (x.Length == 2400)
                {
                    y = x.ToString();
                    numOfBytes = y.Length / 8;

                    bytes = new byte[numOfBytes];
                    for (int i = 0; i < numOfBytes; ++i)
                    {
                        bytes[i] = Convert.ToByte(y.Substring(8 * i, 8), 2);
                    }

                    using (var stream = new FileStream(output + "\\DECODED_FILE", FileMode.Append))
                    {
                        stream.Write(bytes, 0, bytes.Length);
                        x = "";

                    }
                    
                }


            }
            y = x.ToString();
            numOfBytes = y.Length / 8;
            bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(y.Substring(8 * i, 8), 2);
            }

            using (var stream = new FileStream(output + "\\DECODED_FILE", FileMode.Append))
            {
                stream.Write(bytes, 0, bytes.Length);
                x = "";
            }




        }
        private void Input_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filename = openFileDialog1.FileName;
                Input_Text.Text = filename;
            }
        }
        private void Output_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                String path = folderBrowserDialog1.SelectedPath;
                Output_Text.Text = path;
            }
        }

    }
}

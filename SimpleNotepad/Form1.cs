using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using System.Reflection;
using System.Threading;

namespace SimpleNotepad
{
    public partial class Form1 : Form
    {
        protected struct ControlsForm
        {
            public OpenFileDialog OpenFileDialog1;
            public SaveFileDialog SaveFileDialog1;
            public TextBox TextBox1;
        }
        ColorDialog chosenColor = new ColorDialog();
        FontDialog chosenFont = new FontDialog();
        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        /// <summary>
        /// It opens a new tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClick(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
        }

        /// <summary>
        /// It opens a new file and writes it to a screen (TextBox).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Open_Click(object sender, EventArgs e)
        {
            await Open_Click_Async();
           
        }
        private async Task Open_Click_Async()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK
    && openFileDialog1.FileName != string.Empty)
            {
                saveFileDialog1.Reset();
                FileStream file = File.Open(openFileDialog1.FileName, FileMode.Open);
                StreamReader streamReader = new StreamReader(file, Encoding.GetEncoding(1251));
                string text = await streamReader.ReadToEndAsync();

                textBox1.Text = text.ToString();
                streamReader.Close();
            }
        }

        /// <summary>
        /// If file does not exist, it creates a new file with path is chosen by user.; otherwise, it overrites yet opened file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.FileName == string.Empty && openFileDialog1.FileName == string.Empty)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != string.Empty)
                    {
                        FileStream file = File.Create(saveFileDialog1.FileName);
                        StreamWriter streamWriter = new StreamWriter(file, Encoding.GetEncoding(1251));
                        streamWriter.Write(this.textBox1.Text);

                        streamWriter.Close();
                        file.Close();
                    }
                    else return;
                }
                else
                {
                    if (saveFileDialog1.FileName == string.Empty)
                    {
                        FileStream fileStream = File.Create(openFileDialog1.FileName);
                        StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding(1251));
                        streamWriter.Write(this.textBox1.Text);
                        streamWriter.Close();

                    }
                    else
                    {
                        if (openFileDialog1.FileName == string.Empty ||
                            saveFileDialog1.FileName != string.Empty)
                        {
                            FileStream fileStream = File.Create(saveFileDialog1.FileName);
                            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding(1251));
                            streamWriter.Write(this.textBox1.Text);
                            streamWriter.Close();
                        }
                        else MessageBox.Show("Ошибка", "Exception message");
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message.ToString()); }
        }

        /// <summary>
        /// It creates a new file with path is chosen by user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != string.Empty)
            {
                FileStream file = File.Create(saveFileDialog1.FileName);
                StreamWriter streamWriter = new StreamWriter(file, Encoding.GetEncoding(866));
                streamWriter.Write(this.textBox1.Text);

                streamWriter.Close();
                file.Close();
            }
            else return;
        }

        /// <summary>
        /// Loading current Encoding for rus/ua.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        /// <summary>
        /// Shows a dialog to choose a font to a tab (TextBox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Font_Click(object sender, EventArgs e)
        {
            if (chosenFont.ShowDialog() == DialogResult.OK) this.textBox1.Font = chosenFont.Font;
            else return;
        }

        /// <summary>
        /// Shows a dialog to choose a color to a tab (TextBox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Color_Click(object sender, EventArgs e)
        {
            if (chosenColor.ShowDialog() == DialogResult.OK) this.textBox1.ForeColor = chosenColor.Color;
            else return;
        }
    }
}

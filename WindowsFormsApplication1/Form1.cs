using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Drawing.Printing;
using System.Drawing.Text;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form splas = new splash();
        public PrintDialog prindlg = new PrintDialog();
        public Boolean goss = true;
        public Boolean toss = false;
        public Form about = new AboutBox1();
        public PrintDocument printdoc = new PrintDocument();

        public Form1()
        {
             
            InitializeComponent();
        }

        public void asktosave()
        {
            if (toss.Equals(true))
          MessageBox.Show("Do you want to save changes to " + saveFileDialog1.FileName.ToString(), "Save " + saveFileDialog1.FileName.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }


        public void savedlg()
        {
            
            saveFileDialog1.Filter = "All Files | *.* | Text Document | *.txt |HTML Document | *.html | StyleSheet | *.css ";
            //saveFileDialog1.DefaultExt = ".*";

            saveFileDialog1.ShowDialog();
            saveFileDialog1.Title = "Save Document";
            saveFileDialog1.OverwritePrompt.Equals(true);
        }
        //public void saveasdlg()
        //{
        //  saveFileDialog1.Filter  = "|Text Document | *.txt |HTML Document | *.html |All Files | *.*";
        //saveFileDialog1.DefaultExt = ".*";

        //  }

        public void opendlg()
        {
            openFileDialog1.FileName = "";

            openFileDialog1.Title = "Open Document";
            openFileDialog1.Filter = "Text Document | *.txt |HTML Document | *.html|StyleSheet | *.css |All Files | *.*";
            //openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.ShowDialog();

            string filename = openFileDialog1.FileName;

        }

       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddOwnedForm(about);
            
            about.Show();

        }
        public void document_FormPrinting(object sender, PrintPageEventArgs e)
        {
           
            printdoc.PrintPage += document_FormPrinting;
            System.Drawing.Font fontt = new Font("Calibri", 14, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(textBox1.Text, fontt, System.Drawing.Brushes.Black, 10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = "newtxt.txt";
            toss = false;
            label1.Text = "DATE " + DateTime.Now.Day.ToString() + " | " + DateTime.Now.Month.ToString() + " | " + DateTime.Now.Year.ToString() + " || " + " TIME " + DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
            //StreamWriter sw = new StreamWriter(fs);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opendlg();
            if (!openFileDialog1.FileName.Equals(""))
            {
                string gg;
                gg = textBox1.Text;
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                this.Text = "TEXT EDITOR PRO  | " + openFileDialog1.FileName.ToString();
            }

            //FileStream bb = new FileStream("c:\\data.txt", FileMode.Open);

            //textBox1.Text = bb.ToString();


        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //  asktosave();
            if (toss.Equals(true))
            {
                DialogResult resultt = new DialogResult();
                resultt = MessageBox.Show("Do you want to save changes to " + saveFileDialog1.FileName.ToString(), "Save " + saveFileDialog1.FileName.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                if (resultt == DialogResult.Yes)
                {
                    savedlg();
                }
                else if (resultt == DialogResult.No)
                {
                    Application.Exit();
                       }
                else if (resultt == DialogResult.Cancel)
                {
                    e.Equals(toss);
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (goss)
            {
                savedlg();
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }

            else
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }




        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goss = false;
            savedlg();
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text); 
        }       

        private void cSS20inHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(".\\templates\\css2.nbd");
            textBox1.BackColor = Color.DarkMagenta;
            this.Text = "TEXT EDITOR | CSS Stylesheet 2 Template";
            saveFileDialog1.FileName = "webpage.html";
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "DATE " + DateTime.Now.Day.ToString() + " | " + DateTime.Now.Month.ToString() + " | " + DateTime.Now.Year.ToString() + " || " + " TIME " + DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        private void vBNETToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.Text = File.ReadAllText(".\\templates\\aspvb.net");
            textBox1.BackColor = Color.Wheat;
            saveFileDialog1.FileName = "default.aspx";
        }

        private void cNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(".\\templates\\asp.net");
            textBox1.BackColor = Color.Wheat;
            saveFileDialog1.FileName = "default.aspx";
        }

        private void hTMLTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(".\\templates\\html.nbd");
            textBox1.BackColor = Color.WhiteSmoke;
            saveFileDialog1.FileName = "webpage.html";
        }

        private void cSS21incssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(".\\templates\\css20.nbd");
            textBox1.BackColor = Color.DarkMagenta;
            saveFileDialog1.Filter = "StyleSheet (.css) | *.css";
            saveFileDialog1.DefaultExt = ".css";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asktosave();
            textBox1.Text = "";
            saveFileDialog1.DefaultExt = "";
            saveFileDialog1.FileName = "newfile.txt";
            saveFileDialog1.Filter = "";
            saveFileDialog1.DefaultExt = "";
        }

        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(".\\templates\\javashtml.nbd");
            textBox1.BackColor = Color.WhiteSmoke;
            saveFileDialog1.FileName = "webpage.html";
        }

        private void ecmascriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(".\\templates\\ecmascript.nbd");
            textBox1.BackColor = Color.WhiteSmoke;
            saveFileDialog1.FileName = "webpage.html";
        }

        private void vBScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(".\\templates\\vbscript.nbd");
            textBox1.BackColor = Color.WhiteSmoke;
            saveFileDialog1.FileName = "webpage.html";
        }

        private void jScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(".\\templates\\jscript.nbd");
            textBox1.BackColor = Color.WhiteSmoke;
            saveFileDialog1.FileName = "webpage.html";
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prindlg.AllowSelection.Equals(true);
            DialogResult result = new DialogResult();
            result = prindlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                printdoc.Print();
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (toss.Equals(true))
            {
                DialogResult resultt = new DialogResult();
                resultt = MessageBox.Show("Do you want to save changes to " + saveFileDialog1.FileName.ToString(), "Save " + saveFileDialog1.FileName.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                if (resultt == DialogResult.Yes)
                {
                    savedlg();
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                }
                else if (resultt == DialogResult.No)
                {
                    Application.Exit();
         
                }
                else if (resultt == DialogResult.Cancel)
                {
                    e.Cancel = true ;
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {           
 
                  Application.Exit ();
         
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            toss = true;
        }

      
    }

}
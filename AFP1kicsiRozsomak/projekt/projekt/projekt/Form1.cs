using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<string> symbols = new List<string>()
        {
            "!","!","$","$","%","%","p","p","ˆ","ˆ","N","N","f","f","e","e"
        };
        Label elso;
        Label masodik;
        public Form1()
        {
            InitializeComponent();
            Feltoltes();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Feltoltes()
        {
            int random;
            Label label;          
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                label = (Label)panel.Controls[i];
                random = rnd.Next(0,symbols.Count);
                label.Text = symbols[random];

                symbols.RemoveAt(random);
            }
        }

        private void elsonyomott(object sender, EventArgs e)
        {
            Label nyomott = sender as Label;
            if (elso!=null && masodik!=null)
            {
                return;
            }
            
            if (nyomott.ForeColor==Color.White)
            {
                return;
            }

            if (elso==null)
            {
                elso = nyomott;
                elso.ForeColor = Color.White;
                return;
            }
            
             masodik = nyomott;
             masodik.ForeColor = Color.White;

            if (elso.Text==masodik.Text)
            {
                elso = null;
                masodik = null;
                return;
            }

            timer1.Start();
        }

        private void idozito(object sender, EventArgs e)
        {
            timer1.Stop();
            elso.ForeColor = elso.BackColor;
            masodik.ForeColor = masodik.BackColor;
            elso = null;
            masodik = null;
        }
    }
}

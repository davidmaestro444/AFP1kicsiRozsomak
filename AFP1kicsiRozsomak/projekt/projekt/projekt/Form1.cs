using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}

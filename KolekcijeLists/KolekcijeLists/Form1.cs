using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcija_List
{
    public partial class Form1 : Form
    {

        List<Ucenik> ucenici = new List<Ucenik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNunos_Click(object sender, EventArgs e)
        {
            try
            {
                Ucenik ucenik = new Ucenik(TXTime.Text, TXTprezime.Text, CMBrazred.Text);
                ucenici.Add(ucenik);
                TXTime.Clear();
                TXTprezime.Clear();
                MessageBox.Show("Uspješan unos!", "Obabijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos! \r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTNpregled_Click(object sender, EventArgs e)
        {
            RTBispis.Text = "Ime" + "\tPrezime" + "\tRazred\r\n";
            foreach (Ucenik ucenik in ucenici)
            {
                RTBispis.AppendText(ucenik.ToString() + "\r\n");
            }
        }

        private void BTNobrada_Click(object sender, EventArgs e)
        {
            foreach (Ucenik ucenik in ucenici)
            {
                if (ucenik.Razred == "2.")
                {
                    ucenik.Razred = "3.";
                }
            }
            RTBispis.AppendText("__Obrada__" + "\r\n");
            foreach (Ucenik ucenik in ucenici)
            {
                RTBispis.AppendText(ucenik.ToString() + "\r\n");
            }
        }
    }
}
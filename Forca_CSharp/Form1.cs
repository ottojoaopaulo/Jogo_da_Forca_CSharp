using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca_CSharp
{
    public partial class Form1 : Form
    {

        string palavra, tentadas;
        char letra;
        int quantidade = 0, erros = 0, faltam = 0;
        bool achou = false, tenta = false;

        private void btTenta_Click(object sender, EventArgs e)
        {
            //codigo que veifica se a letra ja foi achada
            letra = mtLetra.Text[0];
            for (int cont = 0; cont != quantidade; cont++)
            { 
                if (letra == escondido[cont])
                { tenta = true; }
            }
            //codigo que verifica se a letra ja foi tentada
            tentadas = lbTentadas.Text;
            int quant = tentadas.Length;
            for (int cont = 0; cont!= quant; quant++)
            {
                if (letra == tentadas[cont])
                    { tenta = true; }   
            }
            if (tenta == true)
            { MessageBox.Show("Voce ja digitou essa letra"); }

        }

        char[] escondido;

        public Form1()
        {
            InitializeComponent();
            escondido = new char[20];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btComeca_Click(object sender, EventArgs e)
        {
            //codigo que comeca o jogo
            palavra = tbPalavra.Text;
            quantidade = palavra.Length;
            faltam = quantidade;
            lbPalavra.Text = "";
            lbTentadas.Text = "";
            for (int cont = 0; cont != quantidade; cont++)
            {
                escondido[cont] = '*';
                lbPalavra.Text = lbPalavra.Text + escondido[cont];
;            }
            erros = 0;

            pbCabeca.Visible = false;
            pbCorpo.Visible = false;
            pbBracoD.Visible = false;
            pbBracoE.Visible = false;
            pbPernaD.Visible = false;
            pbPernaE.Visible = false;
            tbPalavra.Enabled = false;
            btComeca.Enabled = false;
            mtLetra.Enabled = true;
            btTenta.Enabled = true;
            mtLetra.Focus();
            lbFaltam.Text = faltam.ToString();
            lbErros.Text = erros.ToString();
        }
    }
}

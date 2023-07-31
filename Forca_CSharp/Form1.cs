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
        char[] escondido;

        public Form1()
        {
            InitializeComponent();
            escondido = new char[20];
        }

        private void tbPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btTenta_Click(object sender, EventArgs e)
        {
            //codigo que verifica se a letra ja foi achada
            letra = mtLetra.Text[0];
            for (int cont = 0; cont != quantidade; cont++)
            { 
                if (letra == escondido[cont])
                { tenta = true; }
            }
            //codigo que verifica se a letra ja foi tentada
            tentadas = lbTentadas.Text;
            int quant = tentadas.Length;
            for (int cont = 0; cont!= quant; cont++)
            {
                if (letra == tentadas[cont])
                    { tenta = true; }   
            }
            if (tenta == true)
            { MessageBox.Show("Voce ja digitou essa letra"); }
            else
            //codigo que procura a letra na palavra escondida
            {
                for (int cont = 0; cont != quantidade; cont++)
                {
                    if (letra == palavra[cont])
                    {
                        escondido[cont] = letra;
                        achou = true;
                        faltam = faltam - 1;
                    }
                }
            }

            //reiniciando a palavra exibida no form
            lbPalavra.Text = "";
            for (int cont = 0; cont != quantidade; cont++)
            {
                lbPalavra.Text = lbPalavra.Text + escondido[cont];
            }

            //em caso de vitoria
            if (faltam == 0)
            {
                MessageBox.Show("Parabens, voce venceu");
                tbPalavra.Enabled = true;
                btComeca.Enabled = true;
                mtLetra.Enabled = false;
                btTenta.Enabled = false;
                tbPalavra.Text = "";
                tbPalavra.Focus();
            }

            //codigo que atualiza as letras tentadas
            if ((achou==false) & (tenta==false))
            {
                erros = erros + 1;
                lbTentadas.Text = lbTentadas.Text + " " + letra;
            }

            //codigo que atualiza a exibicao dos bonecos na forca
            if (erros == 1)
            {pbCabeca.Visible = true; }
            if (erros == 2)
            { pbCorpo.Visible = true; }
            if (erros == 3)
            { pbBracoD.Visible = true; }
            if (erros == 4)
            { pbBracoE.Visible = true; }
            if (erros == 5)
            { pbPernaD.Visible = true; }
            if (erros == 6)
            { 
                pbPernaE.Visible = true;
                MessageBox.Show("Voce Perdeu!");
                tbPalavra.Enabled = true;
                btComeca.Enabled = true;
                mtLetra.Enabled = false;
                btTenta.Enabled = false;
                tbPalavra.Text = "";
                tbPalavra.Focus();
            }

            //reinicializando as variaveis de comparacao
            tenta = false;
            achou = false;
            mtLetra.Text = "";
            mtLetra.Focus();

            lbFaltam.Text = faltam.ToString();
            lbErros.Text = erros.ToString();

        }

        private void mtLetra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

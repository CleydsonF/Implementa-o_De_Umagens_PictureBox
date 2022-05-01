using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Escolha_Veiculos
{
    public partial class frmVeiculos : Form
    {
        public frmVeiculos()
        {
            InitializeComponent();
        }

        private void radCarros_CheckedChanged(object sender, EventArgs e)
        {
            //Tornar o Bugati visivel 
            picBugati.Visible = true;
            radBugat.Visible = true;

            //Tornar a Ferrari visivel 
            picFerrari.Visible = true;
            radFerrari.Visible = true;

            //Tornar a MT-03 invisivel
            picMt03.Visible = false;
            radMt03.Visible = false;

            //Tornar a MT-09 visivel
            picMt09.Visible = false;
            radMt09.Visible = false;

            lblMensagem.Visible = false;
        }
        private void radMotos_CheckedChanged(object sender, EventArgs e)
        {
            //Tornar a MT-03 visivel
            picMt03.Visible = true;
            radMt03.Visible=true;

            //Tornar a MT-09 visivel
            picMt09.Visible=true;
            radMt09.Visible=true;

            //Tornar o Bugati invisivel 
            picBugati.Visible = false;
            radBugat.Visible = false;

            //Tornar a Ferrari invisivel 
            picFerrari.Visible = false;
            radFerrari.Visible = false;

            lblMensagem.Visible = false;
        }

        private void radBugat_CheckedChanged(object sender, EventArgs e)
        {
            //Tornar a Ferrari invisivel 
            picFerrari.Visible = false;
            radFerrari.Visible = false;

            //Descricção Label Txt
            lblMensagem.Text = "O Carro selecionado foi um" + radBugat.Text;
            lblMensagem.Visible = true;
        }

        private void radFerrari_CheckedChanged(object sender, EventArgs e)
        {
            //Tornar o Bugati invisivel 
            picBugati.Visible = false;
            radBugat.Visible = false;

            //Descricção Label Txt
            lblMensagem.Text = "O Carro selecionado foi um" + radFerrari.Text;
            lblMensagem.Visible = true;
        }

        private void radMt03_CheckedChanged(object sender, EventArgs e)
        {
            //Tornar a MT-09 invisivel
            picMt09.Visible = false;
            radMt09.Visible = false ;

            //Descricção Label Txt
            lblMensagem.Text = "A moto selecionada foi uma " + radMt03.Text;
            lblMensagem.Visible = true;
        }

        private void radMt09_CheckedChanged(object sender, EventArgs e)
        {  
            //Tornar a MT-03 invisivel
            picMt03.Visible = false;
            radMt03.Visible = false;

            //Descricção Label Txt
            lblMensagem.Text = "A moto selecionada foi uma " + radMt09.Text;
            lblMensagem.Visible = true;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa toda e qualquer marcação/reiniciando todo o processo
            radCarros.Checked = false;
            radMotos.Checked = false;

            radFerrari.Checked = false;
            radBugat.Checked = false;

            radMt03.Checked = false;
            radMt09.Checked = false;


            
            picMt03.Visible = false;
            radMt03.Visible = false;

            
            picMt09.Visible = false;
            radMt09.Visible = false;

             
            picBugati.Visible = false;
            radBugat.Visible = false;

            
            picFerrari.Visible = false;
            radFerrari.Visible = false;

            lblMensagem.Visible = false;


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fechar programa
            Close();
        }
    }
}

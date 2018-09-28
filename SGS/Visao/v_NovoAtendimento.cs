using SGS.Controle;

using SGS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.Visao
{
    public partial class v_NovoAtendimento : DevExpress.XtraEditors.XtraForm
    {
        
        m_Atendimento m_atendimento;
        c_Atendimento c_atendimento;
        c_Corretor c_corretor;
        c_Loteamento c_loteamento;
        c_CidadeEstado c_cidadeEstado;
        string indicacao,identificador;
        bool AlterarAtend;
        string _usuarioCad;
        //Construtor para registrar novo Atendimento.
        public v_NovoAtendimento()
        {
            this.m_atendimento = new m_Atendimento();
            this.c_atendimento = new c_Atendimento();
            this.c_loteamento = new c_Loteamento();
            this.c_corretor = new c_Corretor();
            this.c_cidadeEstado = new c_CidadeEstado();

            InitializeComponent();
            
        }
        public v_NovoAtendimento(string UsuarioCad)
        {
            this.m_atendimento = new m_Atendimento();
            this.c_atendimento = new c_Atendimento();
            this.c_loteamento = new c_Loteamento();
            this.c_corretor = new c_Corretor();
            this.c_cidadeEstado = new c_CidadeEstado();
            
            InitializeComponent();
            _usuarioCad = UsuarioCad;
        }
        private void v_NovoAtendimento_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            AcceptButton = btnSalvar;
            CarregarCidadeEstado();
            CarregarCorretores();
            CarregarEmpreendimentos();
        }
        //Construtor para alterar Atendimento
        public v_NovoAtendimento(int CodigoAtendimento,string NomeCliente,string Telefone,string CidadeEstado,string CorretorAtual,
            string CorretorAtdAnterior,string Empreendimento,string Identificador,string Localizou,DateTime DataCadastroAtend,string UsuarioCad,bool Alterar)
        {
            this.m_atendimento = new m_Atendimento();
            this.c_atendimento = new c_Atendimento();
            this.c_loteamento = new c_Loteamento();
            this.c_corretor = new c_Corretor();
            this.c_cidadeEstado = new c_CidadeEstado();
            InitializeComponent();
            _usuarioCad = UsuarioCad;
            //Montar alteração...
            m_atendimento.idatendimento = CodigoAtendimento;
            txtNomeCliente.Text = NomeCliente;
            txtTelefoneCliente.Text = Telefone;
            if (Identificador != string.Empty)
            {
                txtQD.Text = Identificador.Substring(3, 3);
                txtLT.Text = Identificador.Substring(10, 3);
            }
            else
            {
                txtQD.Text = string.Empty;
                txtLT.Text = string.Empty;
            }
                lookUpEditCorretorAtual.EditValue = CorretorAtual;
                lookUpEditCorretorAnterior.EditValue = CorretorAtdAnterior;
                lookUpEditEmpreendimento.EditValue = Empreendimento;
            if (CidadeEstado == null)
            {
                lookUpEditCiddeUF.EditValue = "";
            }
            else
            {
                lookUpEditCiddeUF.EditValue = CidadeEstado;
            }
            m_atendimento.cidadeUF = CidadeEstado;
            if (Localizou == "Televisão")
            {
                rbtTelevisao.Checked = true;
            }
            else if (Localizou == "Rádio")
            {
                rbtRadio.Checked = true;
            }
            else if (Localizou == "Internet")
            {
                rbtInternet.Checked = true;
            }
            else if (Localizou == "Carro Som")
            {
                rbtCarroSom.Checked = true;
            }
            else if (Localizou == "Fôlder")
            {
                rbtFolder.Checked = true;
            }
            else
            {
                txtOutros.Text = Localizou;
            }

            dtpDataCadastro.Value = DataCadastroAtend;
            AlterarAtend = Alterar;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtQD.Text == string.Empty && txtLT.Text == string.Empty)
            {
                identificador = null;
            }
            else
            {
                identificador = "QD " + txtQD.Text + " LT " + txtLT.Text;
            }

            if (lookUpEditEmpreendimento.Text != string.Empty && txtNomeCliente.Text != string.Empty)
            {
                m_atendimento.nomeCliente = txtNomeCliente.Text;
                m_atendimento.identificador = identificador;
                m_atendimento.telefone = txtTelefoneCliente.Text;
                m_atendimento.cidadeUF = lookUpEditCiddeUF.Text;
                m_atendimento.corretorAtual = lookUpEditCorretorAtual.Text;
                m_atendimento.atendimentoAnterior = lookUpEditCorretorAnterior.Text;
                m_atendimento.empreendimento = lookUpEditEmpreendimento.Text;
                m_atendimento.dataAtendimento = dtpDataCadastro.Value;
                if (txtOutros.Text != string.Empty)
                {
                    this.indicacao = txtOutros.Text;
                }
                m_atendimento.localizou = indicacao;
                m_atendimento.comprou = "NÃO";
                m_atendimento.usuariocad = _usuarioCad;
               
                if (txtQD.Text != string.Empty && txtQD.Text.Length < 3 || txtLT.Text != string.Empty && txtLT.Text.Length < 3)
                {
                    MessageBox.Show("A QD e o LT deve ter 3 digitos! Ex: 001.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /*else if ()
                {
                    MessageBox.Show("A LT deve ter 3 digitos! Ex: 001.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
                else if  (AlterarAtend == false && MessageBox.Show("Deseja salvar o novo atendimento?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c_atendimento.NovoAtendimento(m_atendimento);
                    MessageBox.Show("Atendimento cadastrado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();this.Close();
                }
                else if (AlterarAtend == true && MessageBox.Show("Deseja alterar o novo atendimento?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c_atendimento.AlterarAtendimento(m_atendimento);
                    MessageBox.Show("Atendimento alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void AtualizarGrid()
        {
            v_VisitasStand v  = Application.OpenForms["v_VisitasStand"] as v_VisitasStand;
            if (v != null)
            {
                v.CarregarAtendimentos();
            }
        }
        private void rbtOutros_CheckedChanged(object sender, EventArgs e)
        {
            indicacao = txtOutros.Text;
        }
        private void rbtTelevisao_CheckedChanged(object sender, EventArgs e)
        {
            indicacao = rbtTelevisao.Text;
        }

        private void rbtRadio_CheckedChanged(object sender, EventArgs e)
        {
            indicacao = rbtRadio.Text;
        }

        private void rbtInternet_CheckedChanged(object sender, EventArgs e)
        {
            indicacao = rbtInternet.Text;
        }

        private void rbtCarroSom_CheckedChanged(object sender, EventArgs e)
        {
            indicacao = rbtCarroSom.Text;
        }
        private void rbtFolder_CheckedChanged(object sender, EventArgs e)
        {
            indicacao = rbtFolder.Text;
        }
        private void rbtIndicacao_CheckedChanged(object sender, EventArgs e)
        {
            indicacao = rbtIndicacao.Text;
        }
        private void CarregarCorretores()
        {
            DataTable dtCorretores = new DataTable();
            dtCorretores = c_corretor.CarregarCorretor();
            lookUpEditCorretorAtual.Properties.DataSource = dtCorretores;
            lookUpEditCorretorAtual.Properties.DisplayMember = "nome";
            lookUpEditCorretorAtual.Properties.ValueMember = "idcorretor";

            lookUpEditCorretorAnterior.Properties.DataSource = dtCorretores;
            lookUpEditCorretorAnterior.Properties.DisplayMember = "nome";
            lookUpEditCorretorAnterior.Properties.ValueMember = "idcorretor";


            if (AlterarAtend == false)
            {
                lookUpEditCorretorAnterior.ItemIndex = -1;
                lookUpEditCorretorAtual.ItemIndex = -1;
            }
            else if(AlterarAtend == true)
            {
                
            }
        }
        private void CarregarEmpreendimentos()
        {
            DataTable dtLoteamentos = new DataTable();
            dtLoteamentos = c_loteamento.CarregarLoteamento();
            lookUpEditEmpreendimento.Properties.DataSource = dtLoteamentos;
            lookUpEditEmpreendimento.Properties.DisplayMember = "nome";
            lookUpEditEmpreendimento.Properties.ValueMember = "idloteamento";
            if (AlterarAtend == false)
            {
                lookUpEditEmpreendimento.ItemIndex = -1;
            }
            else if(AlterarAtend == true)
            {
                
            }
        }

        private void txtOutros_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void CarregarCidadeEstado()
        {
            DataTable dtCidadeEstado = new DataTable();
            dtCidadeEstado = c_cidadeEstado.CarregarCidadesEstadosConcatenado();
            lookUpEditCiddeUF.Properties.DataSource = dtCidadeEstado;
            lookUpEditCiddeUF.Properties.ValueMember = "CidadeEstado";
            lookUpEditCiddeUF.Properties.DisplayMember = "CidadeEstado";
            if (AlterarAtend == false)
            {
                lookUpEditCiddeUF.ItemIndex = -1;
            }
            else if(AlterarAtend == true)
            {
                
            }
        }
    }
}

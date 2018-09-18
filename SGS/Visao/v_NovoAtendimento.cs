using SGS.Controle;
using SGS.dbsgsDataSetTableAdapters;
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
            
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet1.Cidade_Estado'. Você pode movê-la ou removê-la conforme necessário.
            this.cidade_EstadoTableAdapter.Fill(this.dbsgsDataSet1.Cidade_Estado);
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet1.corretor'. Você pode movê-la ou removê-la conforme necessário.
            this.corretorTableAdapter.Fill(this.dbsgsDataSet1.corretor);
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet1.loteamento'. Você pode movê-la ou removê-la conforme necessário.
            this.loteamentoTableAdapter.Fill(this.dbsgsDataSet1.loteamento);
            CancelButton = btnVoltar;
            AcceptButton = btnSalvar;
            CarregarCidadeEstado();
            CarregarCorretores();
            CarregarEmpreendimentos();
        }
        //Construtor para alterar Atendimento
        public v_NovoAtendimento(int CodigoAtendimento,string NomeCliente,string Telefone,string CidadeEstado,string CorretorAtual,
            string CorretorAtdAnterior,string Empreendimento,string Identificador,string Indicou,DateTime DataCadastro,DateTime DataCompra,string comprou,string UsuarioCad,bool Alterar)
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
            
            
            lookUpEditCorretorAtual.Text = CorretorAtual;
            lookUpEditCorretorAnterior.Text = CorretorAtdAnterior;
            lookUpEditEmpreendimento.Text = Empreendimento;
            lookUpEditCiddeUF.Text = CidadeEstado;
            m_atendimento.cidadeUF = CidadeEstado;
            if (Indicou == "Televisão")
            {
                rbtTelevisao.Checked = true;
            }
            else if (Indicou == "Rádio")
            {
                rbtRadio.Checked = true;
            }
            else if (Indicou == "Internet")
            {
                rbtInternet.Checked = true;
            }
            else if (Indicou == "Carro Som")
            {
                rbtCarroSom.Checked = true;
            }
            else if (Indicou == "Fôlder")
            {
                rbtFolder.Checked = true;
            }
            else if (DataCompra != null)
            {
                dtpDataCompra.Value = DataCompra;
            }
            if (comprou == "SIM")
            {
                rbtComprouSim.Checked = true;
            }
            if (comprou == "NÃO")
            {
                rbtComprouNao.Checked = true;
            }
            
            else
            {
                rbtOutros.Checked = true;
                txtLocalizouOutros.Text = Indicou;
            }

            dtpDataCadastro.Value = DataCadastro;
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
                if (rbtComprouSim.Checked == true)
                {
                    m_atendimento.dataCompra = dtpDataCompra.Value;
                }
                m_atendimento.localizou = indicacao;
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
                    
                    this.Close();
                }
                else if (AlterarAtend == true && MessageBox.Show("Deseja alterar o novo atendimento?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c_atendimento.AlterarAtendimento(m_atendimento);
                    MessageBox.Show("Atendimento alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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

        private void rbtOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtOutros.Checked == true)
            {
                txtLocalizouOutros.Enabled = true;
                indicacao = txtLocalizouOutros.Text;
            }
            else if (rbtOutros.Checked == false)
            {
                txtLocalizouOutros.Enabled = false;
            }

        }

        
        private void CarregarCorretores()
        {
            
            if (AlterarAtend == true)
            {

            }
            else
            {
                lookUpEditCorretorAnterior.ItemIndex = -1;
                lookUpEditCorretorAtual.ItemIndex = -1;
            }
           
        }
        private void CarregarEmpreendimentos()
        {
            
            if (AlterarAtend == true)
            {

            }
            else
            {
                lookUpEditEmpreendimento.ItemIndex = -1;
            }
            
        }
        private void CarregarCidadeEstado()
        {
            
            
            if (AlterarAtend == false)
            {
                
                lookUpEditCiddeUF.ItemIndex = -1;
            }
            else if(AlterarAtend == true)
            {
                
            }
        }

        private void rbtComprouSim_CheckedChanged(object sender, EventArgs e)
        {
            m_atendimento.comprou = "SIM";
            dtpDataCompra.Enabled = true;
            m_atendimento.dataCompra = dtpDataCompra.Value;
        }

        private void rbtComprouNao_CheckedChanged(object sender, EventArgs e)
        {
            m_atendimento.comprou = "NÃO";
            dtpDataCompra.Enabled = false;
            //DateTime? DataNull = null;
            //m_atendimento.dataCompra = DataNull.Value;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using SGS.Controle;
using SGS.Modelo;

namespace SGS.Visao
{
    public partial class v_NovoPlantao : DevExpress.XtraEditors.XtraForm
    {
        
        c_Corretor c_corretor;
        m_Corretor m_corretor;
        m_Plantao m_plantao;
        c_Plantao c_plantao;
        m_TempoAtendimento m_tempoAtendimento;
        c_TempoAtendimento c_tempoAtendimento;
        m_CorretorPlantao m_corretorPlantao;
        c_CorretorPlantao c_corretorPlantao;
        DataTable dtb = new DataTable();
        string _UsuarioCad;
        public v_NovoPlantao()
        {
            InitializeComponent();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.m_plantao = new m_Plantao();
            this.c_plantao = new c_Plantao();
            this.m_tempoAtendimento = new m_TempoAtendimento();
            this.c_tempoAtendimento = new c_TempoAtendimento();
            this.m_corretorPlantao = new m_CorretorPlantao();
            this.c_corretorPlantao = new c_CorretorPlantao();
        }
        public v_NovoPlantao(string UsuarioCad)
        {
            InitializeComponent();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.m_plantao = new m_Plantao();
            this.c_plantao = new c_Plantao();
            this.m_tempoAtendimento = new m_TempoAtendimento();
            this.c_tempoAtendimento = new c_TempoAtendimento();
            this.m_corretorPlantao = new m_CorretorPlantao();
            this.c_corretorPlantao = new c_CorretorPlantao();
            _UsuarioCad = UsuarioCad;
        }

        private void v_NovoPlantao_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            CarregarCorretores();
            dtb.Columns.Add("posicao", typeof(int));
            dtb.Columns.Add("corretor", typeof(string));
           
        }
        private void CarregarCorretores()
        {
            
            cbxcCorretores.Properties.DataSource = c_corretor.CarregarCorretores();
            cbxcCorretores.Properties.DisplayMember = "nome";
            cbxcCorretores.Properties.ValueMember = "";
            cbxcCorretores.Properties.BeginUpdate();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarCorretor_Click(object sender, EventArgs e)
        {
            int posicao = 1;
            
            foreach (var item in cbxcCorretores.Properties.Items.GetCheckedValues())
            {
                
                dtb.Rows.Add(posicao++, item);
                gridControl1.DataSource = dtb;
                
            }
            
        }

        private void btnExcluirCorretor_Click(object sender, EventArgs e)
        {
            advBandedGridView1.DeleteRow(advBandedGridView1.FocusedRowHandle);
        }
        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            

            if (cbxEquipe.Text != string.Empty && advBandedGridView1.DataSource != DBNull.Value)
            {
                m_plantao.equipe = cbxEquipe.Text;
                m_plantao.dataplantao = DateTime.Now.Date;
                m_plantao.horainicial = Convert.ToDateTime(tsePlantaoInicia.Text);
                m_plantao.horafinal = Convert.ToDateTime(tsePlantaoTermina.Text);
                m_plantao.tempoporpessoa = Convert.ToDateTime(tseTempoPorPessoa.Text);
                m_plantao.usuariocad = _UsuarioCad;
                
                c_plantao.NovoPlantao(m_plantao);
                int UltimoID = c_plantao.CarregarUltimaIDPlantao();
                advBandedGridView1.ActiveFilter.Clear();
                gridControl1.Enabled = false;
                advBandedGridView1.FocusedRowHandle = 0;
                for (int i = 0; i < advBandedGridView1.RowCount; i++)
                {
                    m_corretorPlantao.posicao = Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]));
                    m_corretorPlantao.nomecorretor = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]).ToString();
                    m_corretorPlantao.fk_plantao_corretorplantao = Convert.ToInt32(UltimoID);

                    c_corretorPlantao.NovoCorretorPlantao(m_corretorPlantao);
                    advBandedGridView1.MoveNext();
                }
               
                
                v_VisaoAtendimentoPlantao visaoPlantao = new v_VisaoAtendimentoPlantao(UltimoID);
                visaoPlantao.Show();
                this.Close();
            }
            

        }
        
    }
}

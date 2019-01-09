using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Modelo;
using SGS.Controle;


namespace SGS.Visao
{
    public partial class v_ControlePlatao : DevExpress.XtraBars.TabForm
    {
        string _UsuarioCad;
        m_Plantao m_plantao;
        c_Plantao c_plantao;
        m_CorretorPlantao m_corretorPlantao;
        c_CorretorPlantao c_corretorPlantao;
        public v_ControlePlatao()
        {
            InitializeComponent();
            this.c_plantao = new c_Plantao();
            this.m_plantao = new m_Plantao();
            this.c_corretorPlantao = new c_CorretorPlantao();
            this.m_corretorPlantao = new m_CorretorPlantao();
        }
        public v_ControlePlatao(string UsuarioCad)
        {
            InitializeComponent();
            _UsuarioCad = UsuarioCad;
            this.c_plantao = new c_Plantao();
            this.m_plantao = new m_Plantao();
            this.c_corretorPlantao = new c_CorretorPlantao();
            this.m_corretorPlantao = new m_CorretorPlantao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            v_NovoPlantao NovoPlantao = new v_NovoPlantao(_UsuarioCad);
            NovoPlantao.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja excluir o registro selecionado?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m_plantao.idplantao = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    c_plantao.ExcluirPlantao(m_plantao);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
            
        }

        private void CarregarGrid()
        {
            
            advBandedGridView1.GridControl.DataSource = c_plantao.CarregarPlantoes();
            //m_corretorPlantao.fk_plantao_corretorplantao = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
            //advBandedGridView2.GridControl.DataSource = c_corretorPlantao.CarregarCorretoresPlantaoID(m_corretorPlantao);
        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void v_ControlePlatao_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            CarregarGrid();
            advBandedGridView1.BestFitColumns(true);
        }
    }
}

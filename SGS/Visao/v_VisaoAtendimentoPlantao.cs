using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Controle;
using SGS.Modelo;

namespace SGS.Visao
{
    public partial class v_VisaoAtendimentoPlantao : DevExpress.XtraEditors.XtraForm
    {
        bool _TelaCheia = false;
        
        TimeSpan _TempoPorVez;
        int _TotalPosicoes;
        int _PosicaoAtual;
        TimeSpan _PlantaoHorafinal;
        int ImagemNumero = 1;
        m_TempoAtendimento m_tempoAtendimento;
        c_TempoAtendimento c_tempoAtendimento;
        m_CorretorPlantao m_corretorPlantao;
        c_CorretorPlantao c_corretorPlantao;
        m_Plantao m_plantao;
        c_Plantao c_plantao;

        TimeSpan ts;
        DateTime start = DateTime.Now;
        TimeSpan delta;
        TimeSpan timeReaming;
        public v_VisaoAtendimentoPlantao()
        {
            InitializeComponent();
            this.m_tempoAtendimento = new m_TempoAtendimento();
            this.c_tempoAtendimento = new c_TempoAtendimento();
            this.m_corretorPlantao = new m_CorretorPlantao();
            this.c_corretorPlantao = new c_CorretorPlantao();
            this.m_plantao = new m_Plantao();
            this.c_plantao = new c_Plantao();
            
        }
        public v_VisaoAtendimentoPlantao(int CodigoPlantao)
        {
            InitializeComponent();
            this.m_tempoAtendimento = new m_TempoAtendimento();
            this.c_tempoAtendimento = new c_TempoAtendimento();
            this.m_corretorPlantao = new m_CorretorPlantao();
            this.c_corretorPlantao = new c_CorretorPlantao();
            this.m_plantao = new m_Plantao();
            this.c_plantao = new c_Plantao();
            m_corretorPlantao.fk_plantao_corretorplantao = CodigoPlantao;
            m_tempoAtendimento.fk_plantao_tempoatendimento = CodigoPlantao;
            m_plantao.idplantao = CodigoPlantao;
            gbxCorretores.Text = gbxCorretores.Text + " - Equipe " + c_plantao.CarregarNomeEquipePlantao(m_plantao);
        }
        private void CarregarImagemSlider()
        {
            string s = @"C:\SGS\ImagensSlider\";
            System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(s);
            int files;
            files = d.GetFiles().Length;
            if (ImagemNumero == files)
            {
                ImagemNumero = 1;
            }
            pictureBoxSlider.ImageLocation = string.Format(@"C:\SGS\ImagensSlider\{0}.jpg", ImagemNumero);
            ImagemNumero++;
        }
        public void StopSlider()
        {
            timerSliderImagens.Stop();
        }
        private void CarregarPlantao()
        {
            
            advBandedGridView1.OptionsSelection.MultiSelect = false;
            advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            advBandedGridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            advBandedGridView1.OptionsSelection.EnableAppearanceHideSelection = false;

            timerSliderImagens.Start();
            timerDataHoraCerta.Start();
            advBandedGridView1.GridControl.DataSource = c_corretorPlantao.CarregarCorretoresPlantaoID(m_corretorPlantao);
            advBandedGridView1.FocusedRowHandle = 0;
            _TotalPosicoes = c_corretorPlantao.SomarTotalPosicoesCorretoresPlantao(m_corretorPlantao);
            MostrarCorretorDaVez();
            _TempoPorVez = c_plantao.CarregarTempoPorPessoa(m_plantao);
            SalvarTempoAtendimentoInicial();
            IniciarTempo();
        }
        private void MostrarCorretorDaVez()
        {
            lblCorretorDaVez.Text = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]).ToString();
            PlaySimplesSound();
        }

        private void v_VisaoAtendimentoPlantao_Load(object sender, EventArgs e)
        {
            CarregarPlantao();
        }
        private void timerHoraCerta_Tick(object sender, EventArgs e)
        {
            lblDataDoDia.Text = DateTime.Now.ToShortDateString();
            //lblHoraCerta.Text = DateTime.Now.Hour +":"+DateTime.Now.Minute+":"+DateTime.Now.Second;
            lblHoraCerta.Text = DateTime.Now.ToLongTimeString();
        }
        private void timerTempoPorPessoa_Tick(object sender, EventArgs e)
        {
            delta = DateTime.Now - start;
            timeReaming = ts - delta;
            lblTempoRestante.Text = timeReaming.ToString("hh\\:mm\\:ss");
        }
        private void ResetTimer()
        {
            timerTempoPorPessoa.Stop();
            timeReaming = TimeSpan.Zero;
            delta = TimeSpan.Zero;
            start = DateTime.Now;
            IniciarTempo();
        }
        private void IniciarTempo()
        {
            //00:00:00
            ts = new TimeSpan(_TempoPorVez.Hours,_TempoPorVez.Minutes,_TempoPorVez.Seconds);
            timerTempoPorPessoa.Start();
        }
        private void SalvarTempoAtendimentoInicial()
        {
            m_tempoAtendimento.atendimentohorainicial = DateTime.Now;

            m_tempoAtendimento.fk_corretorplantao_tempoatendimento = Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]));
            c_tempoAtendimento.NovoTempoAtendimento(m_tempoAtendimento);
        }
        public void PassarVez()
        {
            if (_PosicaoAtual == _TotalPosicoes)
            {

                advBandedGridView1.FocusedRowHandle = 0;
                advBandedGridView1.SelectRow(0);
                SalvarTempoAtendimentoInicial();
            }
            else
            {
                advBandedGridView1.MoveNext();
                SalvarTempoAtendimentoInicial();
            }

            MostrarCorretorDaVez();
            ResetTimer();
            
        }
        
        
        private void lblSejaBemVindo_Click(object sender, EventArgs e)
        {
            if (_TelaCheia == false)
            {
                _TelaCheia = true;
                this.TopMost = true;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                
                
            }
            else if (_TelaCheia == true)
            {
                _TelaCheia = false;
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Minimized;
                
            }
        }

        private void lblTempoRestante_TextChanged(object sender, EventArgs e)
        {
            _PosicaoAtual = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]);
            if (lblTempoRestante.Text == "00:00:00")
            {

                m_tempoAtendimento.idtempoatendimento = c_tempoAtendimento.CarregarUltimaID_Inserida();
                m_tempoAtendimento.atendimentohorafinal = DateTime.Now;
                c_tempoAtendimento.AlterarAtendimentoHoraFinal(m_tempoAtendimento);
                PassarVez();
            }
        }

        private void lblDataHoraCerta_TextChanged(object sender, EventArgs e)
        {
            //00:00:00
            _PlantaoHorafinal = c_plantao.CarregarTempoFinalPlantao(m_plantao);
            if (lblHoraCerta.Text.Substring(0,5) == _PlantaoHorafinal.ToString().Substring(0,5))
            {
                //timerDataHoraCerta.Stop();
                timerTempoPorPessoa.Stop();
                lblTempoRestante.Text = "--:--:--";
            }
        }
        private void PlaySimplesSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\SGS\Sons\alerta01.wav");
            simpleSound.Play();
        }

        private void timerSliderImagens_Tick(object sender, EventArgs e)
        {
            CarregarImagemSlider();
        }

        private void v_VisaoAtendimentoPlantao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar essa tela?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

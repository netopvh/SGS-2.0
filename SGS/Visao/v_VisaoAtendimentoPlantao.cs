using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        m_TempoAtendimento m_tempoAtendimento;
        c_TempoAtendimento c_tempoAtendimento;
        m_CorretorPlantao m_corretorPlantao;
        c_CorretorPlantao c_corretorPlantao;
        m_Plantao m_plantao;
        c_Plantao c_plantao;

        // Como não especificamos um namespace, este
        // será uma instância de System.Windows.Forms.Timer
        private Timer _timer;
        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapSedTime = TimeSpan.Zero;
        private TimeSpan _totalElapSedTime = TimeSpan.Zero;
        private bool _timerRunning = false;

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
            
        }
        private void CarregarPlantao()
        {
            advBandedGridView1.GridControl.DataSource = c_corretorPlantao.CarregarCorretoresPlantaoID(m_corretorPlantao);
            string TempoPorPessoa = Convert.ToString(c_plantao.CarregarTempoPorPessoa(m_plantao));
            _timer.Tick += new EventHandler(timerTempoPorPessoa_Tick);
            timerDataHoraCerta.Start();
            advBandedGridView1.FocusedRowHandle = 0;
        }

        private void v_VisaoAtendimentoPlantao_Load(object sender, EventArgs e)
        {
            
            CarregarPlantao();
            
        }
        

        private void timerHoraCerta_Tick(object sender, EventArgs e)
        {
            
            lblDataHoraCerta.Text = DateTime.Now.ToShortDateString() +" "+DateTime.Now.Hour +":"+DateTime.Now.Minute+":"+DateTime.Now.Second;
        }
        private void timerTempoPorPessoa_Tick(object sender, EventArgs e)
        {
            // Fazemos isso para 'cortar' quaisquer milissegundos perdidos
            // resultante da imprecisão inerente do Timer,
            // com o bônus que o método TimeSpan.ToString ()
            // mostrará agora o formato correto de HH: MM: SS
            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            // O tempo decorrido atual é o tempo desde o botão iniciar
            // foi clicado, mais o tempo total decorrido desde a última reinicialização
            _currentElapSedTime = timeSinceStartTime + _totalElapSedTime;

            // Estes são apenas dois controles Label que exibem a corrente
            // tempo decorrido e tempo total decorrido

            //_totalElapSedTimeDisplay.Text = _currentElapSedTime.ToString();
            lblTempoRestante.Text = timeSinceStartTime.ToString();
            //advBandedGridView1.MoveNext();
        }
        private void ResetTimer()
        {
            // Pare e reinicie o cronômetro se ele estivesse em execução
            _timer.Stop();
            _timerRunning = false;

            // Redefinir o tempo decorrido de objetos TimeSpan
            _startTime = DateTime.Now;
            _totalElapSedTime = TimeSpan.Zero;
            _currentElapSedTime = TimeSpan.Zero;//Tempo decorrido...
        }
        private void IniciarTempo()
        {
            if (!_timerRunning)
            {
                // Defina a hora de início como Agora
                _startTime = DateTime.Now;

                // Armazena o tempo decorrido total até agora
                _totalElapSedTime = _currentElapSedTime;

                _timer.Start();
                _timerRunning = true;
            }
            else
            // Se o temporizador já estiver em execução
            {
                _timer.Stop();
                _timerRunning = false;
            }

        }
        private void PassarVez()
        {
            /*ResetTimer();
            _timer.Start();
            dgvAtendimento.SelectedRows;*/
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

        
    }
}

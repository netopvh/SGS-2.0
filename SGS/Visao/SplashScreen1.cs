using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using SGS.Controle;

namespace SGS.Visao
{
    public partial class SplashScreen1 : SplashScreen
    {
        c_Empresalicenca c_empresalicenca;
        public SplashScreen1()
        {
            InitializeComponent();
            this.c_empresalicenca = new c_Empresalicenca();
        }

        #region Overrides

        /*public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }*/

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            LogoEmpresa();
        }
        private void LogoEmpresa()
        {
            try
            {
                Stream stream = new MemoryStream(c_empresalicenca.CarrregarLogoMarca());
                var image = Image.FromStream(stream);
                pictureEdit2.Image = image;
            }
            catch (ArgumentNullException)
            {

                //throw;
            }
        }
    }
}
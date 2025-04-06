using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDHitchhiker
{
    public partial class frmSplash : Form
    {
        private delegate void HideDelegator(Control control);
        private delegate void CloseDelegator();


        public frmSplash()
        {
            InitializeComponent();
            System.Timers.Timer timer = new System.Timers.Timer(2000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void HideSplash(Control control)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new HideDelegator(HideSplash), new object[] { control });
            } else
            {
                control.Hide();

                frmMain frmMain = new frmMain();
                frmMain.SplashForm = this;
                frmMain.Show();
                frmMain.Focus();
            }
        }

        public void CloseSplash()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new CloseDelegator(CloseSplash), new object[] { });
            } else
            {
                this.Close();
            }
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (sender != null && sender is System.Timers.Timer)
                ((System.Timers.Timer)sender).Stop();

            HideSplash(this);
        }
    }
}

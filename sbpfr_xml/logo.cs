using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sbpfr_xml
{
    public partial class logo : Form
    {
        public static Form fmain = new main();
        public static Form ftest = new test();

        public static Thread hlogoThread;
        public static Thread loadFormThread;

        private static int timerLogoType = 0;
        public static bool loadStatus = false;
        public logo()
        {
            InitializeComponent();

            this.Opacity = 0;
            timer_logo.Start();


        }

        private void logo_Shown(object sender, EventArgs e)
        {
            this.Activate();
            hlogoThread = new Thread(hideLogoForm);
            hlogoThread.Start();
            
        }

        private void logo_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(60000);
            //this.Hide();
            //this.Visible = false;

            
           
        }

        private void loadform()
        {
            
            fmain.Show();
        }

        private void hideLogoForm()
        {
            while (true)
            {
                if (loadStatus)
                {
                    
                    this.Invoke(new Action(() => this.Hide()));
                    loadStatus = false;
                    timerLogoType = 1;
                    timer_logo.Start();
                    break;
                }
            }
        }

        private void timer_logo_Tick(object sender, EventArgs e)
        {
            switch (timerLogoType)
            {
                case 0:
                    if ((this.Opacity += 0.05) == 1)
                        timer_logo.Stop();

                        loadform();
                    break;
                case 1:
                    if ((Opacity -= 0.05) == 0)
                        timer_logo.Stop();
                    break;

            }
           
        }
    }
}

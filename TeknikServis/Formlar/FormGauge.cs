using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FormGauge : Form
    {
        public FormGauge()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormHakkimizda_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value += 5;
            if (arcScaleComponent1.Value==200)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value -= 5;
            if (arcScaleComponent1.Value==0)
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            arcScaleComponent3.Value += 1;
            arcScaleComponent5.Value += 1;
            labelComponent1.Text = arcScaleComponent3.Value.ToString();
            if (arcScaleComponent3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            arcScaleComponent3.Value -= 1;
            arcScaleComponent5.Value -= 1;

            labelComponent1.Text = arcScaleComponent3.Value.ToString();
            if (arcScaleComponent3.Value == 0)
            {
                timer4.Stop();
                timer3.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            arcScaleComponent4.Value += 5;
            if (arcScaleComponent4.Value == 100)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            arcScaleComponent4.Value -= 5;
            if (arcScaleComponent4.Value == 0)
            {
                timer6.Stop();
                timer5.Start();
            }
        }
    }
}

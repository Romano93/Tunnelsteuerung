using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pruefung2.Controller;
using Pruefung2.api;
using Pruefung2.models;

namespace Pruefung2.userControl
{
    public partial class VentControl : UserControl, IObserver
    {
        private VentilatorController controller;


        public VentControl()
        {
            InitializeComponent();
            initialise();
        }

        /// <summary>
        /// Initialise all components
        /// </summary>
        private void initialise()
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        /// <summary>
        /// This function sends the stage to the controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStage1_Click(object sender, EventArgs e)
        {
            controller.ButtonStagePress(1);
        }

        /// <summary>
        /// This function sends the stage to the controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOff_Click(object sender, EventArgs e)
        {
            controller.ButtonStagePress(0);
        }

        /// <summary>
        /// This function sends the stage to the controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStag2_Click(object sender, EventArgs e)
        {
            controller.ButtonStagePress(2);
        }

        /// <summary>
        /// This function sends the stage to the controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStage3_Click(object sender, EventArgs e)
        {
            controller.ButtonStagePress(3);
        }

        /// <summary>
        /// This function sends the stage to the controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStage4_Click(object sender, EventArgs e)
        {
            controller.ButtonStagePress(4);
        }

        /// <summary>
        /// It updates all the values on the view
        /// </summary>
        /// <param name="vent">an instance of a ventilator</param>
        void IObserver.Update(Ventilator vent)
        {
            //stage
            if(vent.Stage == 0)
            {
                lblStage.Text = "Aus";
            }
            else
            {
                lblStage.Text = $"Stufe: {vent.Stage}";
            }
            //Labels
            lblSpeed.Text = $"{vent.Speed.ToString()} U/Min";
            lblUsage.Text = $"{vent.Usage.ToString()} kWh";
            lblVoltage.Text = $"{vent.Voltage.ToString()} V";
            //progressbars
            pgbSpeed.Value = vent.Speed;
            pgbUseage.Value = vent.Usage;
            pgbVoltage.Value = vent.Voltage;
            //Picture
            if(vent.Speed == 0)
            {
                pbVent.ImageLocation = "..\\..\\img\\vent.png";
            }
            else
            {
                pbVent.ImageLocation = "..\\..\\img\\vent.gif";
            }

        }

        private void VentControl_Load(object sender, EventArgs e)
        {
            controller = new VentilatorController();
            controller.AttachToVent(this);
            pbVent.ImageLocation = "..\\..\\img\\vent.png";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controller.DoTick(timer1.Interval);
        }
    }
}

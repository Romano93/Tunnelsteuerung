using Pruefung2.api;
using Pruefung2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruefung2.Controller
{
    class VentilatorController
    {
        private Ventilator ventilator;
        
        /// <summary>
        /// Constroctor
        /// </summary>
        public VentilatorController()
        {
            ventilator = new Ventilator();
        }

        /// <summary>
        /// handels Button presses ont the user Controll
        /// </summary>
        /// <param name="stage">the stage we want to reach</param>
        public void ButtonStagePress(int stage)
        {
            ventilator.SetUpStage(stage);          
        }

        /// <summary>
        /// the observer will be given over to the ventilator to attach
        /// </summary>
        /// <param name="observer">an Instance of an observer</param>
        public void AttachToVent(IObserver observer)
        {
            ventilator.Attach(observer);
        }

        /// <summary>
        /// the observer will be given over to the ventilator to detach
        /// </summary>
        /// <param name="observer">an Instance of an observer</param>
        public void DetachFromVent(IObserver observer)
        {
            ventilator.Detach(observer);
        }

        /// <summary>
        /// this function gives the tick event of the user controll to the ventilator
        /// </summary>
        /// <param name="interval">the interval of the tick</param>
        internal void DoTick(int interval)
        {
            ventilator.DoTick(interval);
        }
    }
}

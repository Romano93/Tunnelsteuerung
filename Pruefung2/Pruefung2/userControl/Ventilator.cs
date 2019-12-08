using Pruefung2.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruefung2.models
{
    class Ventilator : ISubject
    {
        private int stageTarget;
        public int Stage { get; set; }
        public int Speed { get; set; }
        public int Voltage { get; set; }
        public int Usage { get; set; }
        //for timer tick
        private int stepSpeed;

        public List<IObserver> observers;

        /// <summary>
        /// Constructor of the Ventilator
        /// </summary>
        public Ventilator()
        {
            observers = new List<IObserver>();
            Voltage = 0;
            Speed = 0;
            Stage = 0;
            stageTarget = 0;
            stepSpeed = 0;
        }

        /// <summary>
        /// this function is to attach a observer to the subject (Ventilator)
        /// </summary>
        /// <param name="observer">the observer which we want attach</param>
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 
        /// this function is to detach a observer to the subject (Ventilator)
        /// </summary>
        /// <param name="observer">the observer which we want detach</param>
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        /// <summary>
        /// 
        /// do the tick of the timer
        /// </summary>
        /// <param name="interval">the interval of the timer</param>
        internal void DoTick(int interval)
        {
            //just do something if the speed isn't reached
            if (Speed != stageTarget*1000)
            {
                if ((stageTarget * 1000) > Speed)
                {
                    if (stepSpeed == 0) { stepSpeed = 1000 / (5 * 1000 / interval);}
                    //end Step
                    if (Speed + stepSpeed > stageTarget * 1000)
                    {
                        Speed = stageTarget * 1000;
                        stepSpeed = 0;
                        Usage = Speed * 5 / 1000;
                    }
                    //normal step
                    else
                    {
                        Speed = Speed + stepSpeed;
                        //Set Usage and Volt.
                        //dadurch dass der Ventlilator auch die Energie zum hochfahren braucht, geht die Spannung und Verbrauch recht schnell nach oben (reale Welt)
                        if(Speed > 0 && Voltage < 400) { Voltage = Voltage + 400 / 10; }
                        Usage = Speed * 5 / 1000;
                    }
                    //Ste the right stage
                    if (Speed == 4000) { Stage = 4; }                    
                    else if (Speed >= 3000){ Stage = 3;}
                    else if (Speed >= 2000){ Stage = 2;}
                    else if (Speed >= 1000){ Stage = 1;}
                }
                else
                {
                    if (stepSpeed == 0)
                    {
                        int tmp = 0;
                        int time;
                        tmp = Speed / 1000;
                        time = (tmp * tmp) * 10;
                        stepSpeed = Speed / time / interval;
                    }
                    //clac speed
                    if (Speed - stepSpeed <= stageTarget * 1000)
                    {
                        Speed = stageTarget * 1000;
                        Usage = Speed * 5 / 1000;
                        if (stageTarget == 0) { Usage = 0; Voltage = 0; }
                    }
                    else
                    {
                        Speed = Speed - stepSpeed;
                        Usage = Speed * 5 / 1000;
                        if (stageTarget == 0 && Voltage > 0) { Voltage = Voltage - 400 / 10; }
                    }
                    //set stage
                    if (Speed < 1000) { Stage = 0; }
                    else if (Speed < 2000) { Stage = 1; }
                    else if (Speed < 3000) { Stage = 2; }
                    else if (Speed < 4000) { Stage = 3; }
                }
            }
            Notify();
        }

        /// <summary>
        /// Set the stage we want to reach
        /// </summary>
        /// <param name="stage">stage we want to reach</param>
        public void SetUpStage(int stage)
        {
            stageTarget = stage;
            DoTick(100);
        }
    }
}

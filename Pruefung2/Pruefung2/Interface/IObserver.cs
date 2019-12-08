using Pruefung2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruefung2.api
{
    interface IObserver
    {
        void Update(Ventilator vent);
    }
}

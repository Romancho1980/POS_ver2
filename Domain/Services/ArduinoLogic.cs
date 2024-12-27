using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ArduinoLogic
    {
        enum State
        {
            Idle,
            Ready,
            Done,
        }

        public string DataFromArduino { get; set; } = string.Empty;
        public ArduinoLogic()
        {
            
        }

        public void StateMachine()
        {
            if (DataFromArduino.Equals("Hello Arduino"))
            {

            }
        }
    }
}

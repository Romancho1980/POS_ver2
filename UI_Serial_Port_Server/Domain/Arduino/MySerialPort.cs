using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Serial_Port_Server.Domain.Arduino
{
    public class MySerialPort:SerialPort,INotifyPropertyChanged
    {
        public string Loggin = string.Empty;
        public int State = 0;

        public string cost=string.Empty;
        public string account=string.Empty;
        public string pin=string.Empty;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MySerialPort(string port) :
            base()
        {
            base.BaudRate = 9600;
            base.DataBits = 8;
            base.StopBits = StopBits.Two;
            base.Parity = Parity.None;
            base.ReadTimeout = 1000;
            
            Loggin = "";

            //base.DataReceived += Do;
            //DataReceived += Do;
            
            
            base.DataReceived += DataReceive;
        }

        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Вызывается, когда стаботало событие DataReceived в классе SerialPort. Смотри документацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            var port = (SerialPort)sender;
            int bufferSize = port.BytesToRead;
            string buffer = "";
            Loggin = Convert.ToString(bufferSize) + "/n";
            for (int i = 0; i < bufferSize; i++)
            {
                char bt = (char)port.ReadChar();
                buffer += bt.ToString();
            }

            Loggin = buffer;
            ParseData();
            // Loggin = "";
        }

        public void ParseData()
        {
            if ((State == 1) && (Loggin != "Hello Arduino\r\n"))
            {
                var data = Loggin.Split(' ').ToArray();

                cost = data[0];
                account = data[1] + " " + data[2] + " " + data[3] + " " + data[4];
                pin = data[5];

            }

            if (Loggin == "Hello Arduino\r\n")
            {
                State = 1;
                Write("Ready");


            }

        }

        //private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    var port = (SerialPort)sender;
        //    string buffer = "";
        //    try
        //    {
        //        int bufferSize = port.BytesToRead;
        //        Loggin=Convert.ToString(bufferSize)+"/n";
        //        for (int i = 0; i < bufferSize; i++) 
        //        {
        //            char bt=(char)port.ReadChar();
        //            buffer += bt.ToString();
        //        }

        //        Loggin = buffer;
        //        //Loggin=port.ReadLine();
        //        char[] data = { 'O', 'K'};
        //        string data1 = "OK";
        //        //port.WriteLine(data1);
        //        port.Write("OK");
        //        foreach (char c in buffer) 
        //        {
        //            //port.Write(data,0,data.Length);
        //            //port.Write(data);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        public void Open(string port)
        {
            if (base.IsOpen)
            {
                base.Close();
            }
            base.PortName = port;
          //  base.Open();
        }
    }
}

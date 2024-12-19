using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Arduino
{
    public class MySerialPort:SerialPort
    {
        public string Loggin;
        public MySerialPort(string port):
            base()
        {
            base.BaudRate = 9600;
            base.DataBits = 8;
            base.StopBits = StopBits.Two;
            base.Parity = Parity.None;
            base.ReadTimeout = 1000;

            Loggin = "";

            //   base.DataReceived += SerialPort_DataReceived;
            base.DataReceived += DataReceive;
        }

        private void DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            var port=(SerialPort)sender;
            int bufferSize = port.BytesToRead;
            string buffer = "";
            Loggin = Convert.ToString(bufferSize) + "/n";
            for (int i = 0; i < bufferSize; i++)
            {
                char bt = (char)port.ReadChar();
                buffer += bt.ToString();
            }

            Loggin = buffer;
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
            base.Open();
        }
    }
}

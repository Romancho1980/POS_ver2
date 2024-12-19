using System.IO.Ports;

namespace Domain.Arduino;

public class UseSerial
{
    public string Loggin;
    SerialPort Arduino = new SerialPort();


    void Init()
    {
        Arduino.BaudRate = 9600;
        Arduino.DataBits = 8;
        Arduino.StopBits = StopBits.Two;
        Arduino.Parity = Parity.None;
        Arduino.ReadTimeout = 1000;
    }
    public void GetDataFromArduino()
    {

        string data=string.Empty;

        /*
        Console.WriteLine("Hello, World!");
        SerialPort asd;


        string[] ports = SerialPort.GetPortNames(); // Массив строк, в котором хранятся доступные в системе COM порты


        Console.WriteLine("Доступные COM порты:");
        foreach (string com_ports in SerialPort.GetPortNames())
        {
            Console.WriteLine("   {0}", com_ports);
        }

        Console.WriteLine("Чтение данных с Anduino");
        while (true) // Бесконечный цикл
        {
            SerialPort Arduino = new SerialPort(); // создаю экземпляр класса, без первоначальных параметров
            try
            {
                Arduino.PortName = ports[1]; // Имя COM порта - COM3
                Arduino.Open();              // открытие порта
                                             //                    Console.WriteLine($"Порт {Arduino.PortName} открыт");

                Thread.Sleep(1000); // Магия.... Говорю, чтобы поток приостановил выполнение на 1000 миллисек, т.е. 1 сек
                                    // если поставить паузу меньше, то не работает - выдаёт Excetption

                string data = Arduino.ReadLine(); // Читаю с СОМ порта в переменную data
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Читаю с СОМ порта: {data}");// вывод на экран
                Arduino.Close();        // закрываю порт
                Console.ForegroundColor = ConsoleColor.White;

                if (data == "Hello Arduino\r")
                {
                    Console.WriteLine("Отвечаю Arduino");
                    Arduino.PortName = ports[1];
                    Arduino.Open();
                    Thread.Sleep(1000);
                    data = "Got it";
                    Arduino.WriteLine(data);
                    Arduino.Close();
                }
            }
            catch
            {
                Console.WriteLine($"Ошибка открытия порта {Arduino.PortName}");
            }
        }
        */

        Init();
        string[] ports = SerialPort.GetPortNames(); // Массив строк, в котором хранятся доступные в системе COM порты

      //  SerialPort Arduino = new SerialPort(); // создаю экземпляр класса, без первоначальных параметров
        try
        {

            Arduino.PortName = ports[1]; // Имя COM порта - COM3
//            Loggin += "${Arduino.BytesToRead()}";
            Arduino.Close();
            Arduino.Open();              // открытие порта
            if (Arduino.IsOpen)
            {
                int num = Arduino.BytesToRead;
                // Loggin += Convert.ToString(Arduino.BytesToRead);
                //                    Console.WriteLine($"Порт {Arduino.PortName} открыт");

                Thread.Sleep(500); // Магия.... Говорю, чтобы поток приостановил выполнение на 1000 миллисек, т.е. 1 сек
                                    // если поставить паузу меньше, то не работает - выдаёт Excetption

                //   data = Arduino.ReadLine(); // Читаю с СОМ порта в переменную data
                Loggin += $"Читаю с СОМ порта: {data} {num.ToString()} bytes\n";

                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine($"Читаю с СОМ порта: {data}");// вывод на экран

            }
            else
            {
                Loggin += "Port not open/n";
            }
            Arduino.Close();        // закрываю порт
                                    //  Console.ForegroundColor = ConsoleColor.White;

            if (data == "Hello Arduino\r")
            {
                Loggin += "data = Hello arduino\n";
                Loggin += "Отвечаю Arduino\n";
                //  Console.WriteLine("Отвечаю Arduino");
                Arduino.PortName = ports[1];
                Arduino.Open();
                Thread.Sleep(1000);
                data = "Got it";
                Arduino.WriteLine(data);
                Arduino.Close();
            }
           // Loggin = "";
        }
        catch
        {
          //  Loggin = $"Ошибка открытия порта {Arduino.PortName}\t";
            Loggin += $"Нет данных с ардуино порт: {Arduino.PortName}\n";
            Arduino.Close();
        }
    }
}

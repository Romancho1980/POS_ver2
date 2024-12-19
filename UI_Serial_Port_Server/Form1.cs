using Domain.Arduino;
using Domain.Models.SimpleModels;
using Domain.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI_Serial_Port_Server
{
    public partial class Form1 : Form
    {
        public MockDataBase dataBase;
        MySerialPort arduino;

        public ClientAccountVer1? SelectedClientAccount { get; set; }
        public Form1()
        {
            dataBase = new MockDataBase();
            // arduino = new UseSerial();
            arduino = new MySerialPort("COM3");
            arduino.Open("COM3");
            dataBase.InitData();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
//            arduino.GetDataFromArduino();

            richTextBox1.Text += arduino.Loggin;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //arduino.Open();
            arduino.Write("OK");
            //arduino.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            foreach (var items in dataBase.accounts)
            {
                listBox1.Items.Add(items.Name+" "+items.Surname);
            }

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            SelectedClientAccount = dataBase.accounts[index];

            label12.Text=SelectedClientAccount.Name;
            label11.Text=SelectedClientAccount.Surname;
            label10.Text=SelectedClientAccount.INN;
            label9.Text=SelectedClientAccount.Passport;
            label8.Text=SelectedClientAccount.City;

            label18.Text=SelectedClientAccount.Account;
            //label19.Text=SelectedClientAccount.Name;
            label20.Text=$"{SelectedClientAccount.Balance.ToString()} руб";



            //if ((SelectedClientAccount = listBox1.SelectedItem as ClientAccountVer1) != null)
            //{
            //    throw new Exception ("Null clients");
            //}
        }
    }
}

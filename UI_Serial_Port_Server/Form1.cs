//using Domain.Arduino;
//using Domain.Models.SimpleModels;
//using Domain.Services;
using System.IO.Ports;
using UI_Serial_Port_Server.Domain.Arduino;
using UI_Serial_Port_Server.Domain.Models.SimpleModels;
using UI_Serial_Port_Server.Domain.Services;
using UI_Serial_Port_Server.Views;
using UI_Serial_Port_Server.Новая_папка;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI_Serial_Port_Server
{
    public partial class Form1 : Form, INotify
    {
        public MockDataBase dataBase;
        MySerialPort arduino;
        //        public ArduinoLogic arduinoLogic;

        public ClientAccountVer1? SelectedClientAccount { get; set; }
        public string SelectedAccount { get; set; }

        //public bool Changed=false;
        public Form1()
        {
            //arduinoLogic = new ArduinoLogic();
            dataBase = new MockDataBase();
            // arduino = new UseSerial();
            arduino = new MySerialPort("COM3");
            arduino.Open("COM3");
            dataBase.InitData();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text += arduino.Loggin;
            //arduinoLogic.DataFromArduino = arduino.Loggin;

            label26.Text = arduino.cost;
            label25.Text = arduino.account;
            label24.Text = arduino.pin;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            arduino.Write("OK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            listBox1.Items.Clear();
            foreach (var items in dataBase.accounts)
            {
                listBox1.Items.Add(items.Name + " " + items.Surname);
            }

        }

        private void RefreshData()
        {
            int index = listBox1.SelectedIndex;
            SelectedClientAccount = dataBase.accounts[index];

            label12.Text = SelectedClientAccount.Name;
            label11.Text = SelectedClientAccount.Surname;
            label10.Text = SelectedClientAccount.INN;
            label9.Text = SelectedClientAccount.Passport;
            label8.Text = SelectedClientAccount.City;
            label18.Text = SelectedClientAccount.Account;
            //label19.Text=SelectedClientAccount.Name;
            label20.Text = $"{SelectedClientAccount.Balance.ToString()} руб";

            listBox2.Items.Clear();
            listBox2.Items.Add(SelectedClientAccount.Account);
            if (listBox2.Items.Count > 0) 
            { 
                SelectedAccount=listBox2.Items[0].ToString();  
                listBox2.SelectedIndex = 0; 
            }


        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            RefreshData();

            //int index = listBox1.SelectedIndex;
            //SelectedClientAccount = dataBase.accounts[index];

            //label12.Text = SelectedClientAccount.Name;
            //label11.Text = SelectedClientAccount.Surname;
            //label10.Text = SelectedClientAccount.INN;
            //label9.Text = SelectedClientAccount.Passport;
            //label8.Text = SelectedClientAccount.City;

            //label18.Text = SelectedClientAccount.Account;
            ////label19.Text=SelectedClientAccount.Name;
            //label20.Text = $"{SelectedClientAccount.Balance.ToString()} руб";



            //if ((SelectedClientAccount = listBox1.SelectedItem as ClientAccountVer1) != null)
            //{
            //    throw new Exception ("Null clients");
            //}
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        public void Do()
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClient newForm = new AddClient();
            var EditingData = new ClientAccountVer1();
            // newForm.Show();
            newForm.ShowDialog();
            EditingData = newForm.GetUpdatedData();
            EditingData.Id = dataBase.accounts.Count;
            dataBase.accounts.Add(EditingData);
            Form1_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SelectedClientAccount != null)
            {
                AddClient newForm = new AddClient(SelectedClientAccount);
                var EditingData = new ClientAccountVer1();
                // newForm.Show();
                newForm.ShowDialog();



                //   EditingData = SelectedClientAccount;
                int ind = dataBase.accounts.FindIndex(x => x.Surname == SelectedClientAccount.Surname);
                EditingData = newForm.GetUpdatedData();
                dataBase.accounts[ind] = EditingData;
                //    this.Refresh();
                Form1_Load(sender, e);
                listBox1.SelectedIndex = ind;
                RefreshData();

                //var EditingData = new ClientAccountVer1()
                //{
                //    Id = SelectedClientAccount.Id,
                //    Name = SelectedClientAccount.Name,
                //    Surname = SelectedClientAccount.Surname,
                //    INN = SelectedClientAccount.INN,
                //    City = SelectedClientAccount.City,
                //    Account = SelectedClientAccount.Account,
                //    Passport = SelectedClientAccount.Passport,
                //    Birthday = SelectedClientAccount.Birthday,
                //    Balance = SelectedClientAccount.Balance,
                //    //Description = SelectedClientAccount.Description,

                //};
                string data = newForm.Name;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SelectedClientAccount != null)
            {
                dataBase.accounts.Remove(SelectedClientAccount);
                Form1_Load(sender, e);
                if (dataBase.accounts.Count > 0)
                {
                    SelectedClientAccount = dataBase.accounts[dataBase.accounts.Count - 1];
                    listBox1.SelectedIndex = dataBase.accounts.Count - 1;
                    RefreshData();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            AddClientAccount newForm = new AddClientAccount();
            var EditingData = new ClientAccountVer1();
            newForm.ShowDialog();
            EditingData = newForm.GetUpdatedData();
            EditingData.Id = dataBase.accounts.Count;
            dataBase.accounts.Add(EditingData);
            Form1_Load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (SelectedClientAccount != null)
            {
                AddClientAccount newForm = new AddClientAccount(SelectedClientAccount);
                var EditingData = new ClientAccountVer1();
                newForm.ShowDialog();
                EditingData = newForm.GetUpdatedData();
                EditingData.Id = dataBase.accounts.Count;
                Form1_Load(sender, e);
            }
        }
    }
}

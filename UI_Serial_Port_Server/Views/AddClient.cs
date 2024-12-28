using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Serial_Port_Server.Domain.Models.SimpleModels;

namespace UI_Serial_Port_Server.Views
{
    public partial class AddClient : Form
    {
        ClientAccountVer1 update = new ClientAccountVer1();
        public string Name { get; set; } = string.Empty;

        public ClientAccountVer1 GetUpdatedData()
        {
            return update;
        }
        public AddClient()
        {
            InitializeComponent();
        }
        public AddClient(ClientAccountVer1 data)
        {
            update = data;
            InitializeComponent();
            textBox1.Text = data.Name;
            textBox2.Text = data.Surname;
            textBox3.Text = data.INN;
            textBox4.Text = data.Passport;

            dateTimePicker1.Value = (DateTime)data.Birthday;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update.Name = textBox1.Text;
            update.Surname = textBox2.Text;
            update.INN = textBox3.Text;
            update.Passport = textBox4.Text;

            update.Birthday = dateTimePicker1.Value;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

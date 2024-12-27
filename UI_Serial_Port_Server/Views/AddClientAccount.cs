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
    public partial class AddClientAccount : Form
    {
        ClientAccountVer1 update = new ClientAccountVer1();
        public AddClientAccount()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            textBox1.Text = update.Account;
            textBox2.Text = update.Balance.ToString();
            richTextBox1.Text = update.Description;
        }
        public AddClientAccount(ClientAccountVer1 editAccount)
        {
            update = editAccount;
            //textBox1.Text=editAccount.Account;
            //textBox2.Text=editAccount.Balance.ToString();
            //richTextBox1.Text=editAccount.Description;
            if (editAccount != null)
            {
                
            InitializeComponent();
            RefreshData();
            }
            else
            {

            }
        }
        public ClientAccountVer1 GetUpdatedData()
        {

            return update;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update.Account = textBox1.Text;
            update.Balance = Decimal.Parse(textBox2.Text);
            update.Description=richTextBox1.Text;
            Close();
        }
    }
}

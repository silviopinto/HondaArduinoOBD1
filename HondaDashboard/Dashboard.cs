using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HondaDashboard
{
    public partial class Dashboard : Form
    {
        Serial _serial = new Serial();

        Connection _connection = new Connection();
        Save _save = new Save();
        

        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (_save.VerifySave() == true)
            {
                string connection = _save.ReadSave();
                string[] words = connection.Split(';');
                string ports = words[0];
                string baudrate = words[1];
                string bits = words[2];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please make your configuration and restart the program");
                _connection.Show();
            }



        }

    }
}

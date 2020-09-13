using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HondaDashboard
{
    public partial class Connection : Form
    {
        SerialPort ComPort = new SerialPort();
        Save _save = new Save();
        bool saved = false;

        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            RefreshConnections();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshConnections();
        }


        private void RefreshConnections()
        {
            int oldPorts = cb_port.Items.Count;


            cb_port.ResetText();
            cb_bits.Items.Clear();
            cb_boudRate.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            cb_port.DataSource = ports;
            cb_port.SelectedIndex = 0;

            if ((oldPorts < cb_port.Items.Count) && (oldPorts != 0))
                lbl_newPort.Visible = true;
            else
                lbl_newPort.Visible = false;
            

            cb_boudRate.Items.Add(300);
            cb_boudRate.Items.Add(600);
            cb_boudRate.Items.Add(1200);
            cb_boudRate.Items.Add(2400);
            cb_boudRate.Items.Add(9600);
            cb_boudRate.Items.Add(14400);
            cb_boudRate.Items.Add(19200);
            cb_boudRate.Items.Add(38400);
            cb_boudRate.Items.Add(57600);
            cb_boudRate.Items.Add(115200);
            cb_boudRate.SelectedIndex = 4;

            cb_bits.Items.Add(1);
            cb_bits.Items.Add(2);
            cb_bits.Items.Add(3);
            cb_bits.Items.Add(4);
            cb_bits.Items.Add(5);
            cb_bits.Items.Add(6);
            cb_bits.Items.Add(7);
            cb_bits.Items.Add(8);
            cb_bits.SelectedIndex = 7;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                _save.WriteSave(cb_port.SelectedItem.ToString() + ";" + cb_boudRate.SelectedItem.ToString() + ";" + cb_bits.SelectedItem.ToString());
                saved = true;
            }
            catch (Exception)
            {
                saved = false;
            }

            }

        private void Connection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
            {

           
            if (MessageBox.Show("Exit without saving?",
                      "That config is not saved yet",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) == DialogResult.No) 
            {
                e.Cancel = true;
            }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace HondaDashboard
{
   public class Serial
    {
        static bool _continue;
        static SerialPort _serialPort = new SerialPort();

        Thread readThread = new Thread(Read);

        // Serial Addresses

        //        NG62 and Older Datalog protocol. 

        //ECT 0x30
        //IAT 0x32
        //MAP 0xF8
        //Barometric Pressure 0x34
        //TPS 0x39
        //02 Sensor 0xFB
        //RPM Hi 0x47
        //RPM Lo 0xFA
        //Table Row 0xFE
        //Table Column 0xFD
        //VSS(Speed) 0x6C
        //Err 1 0x2B
        //Err 2 0x2C
        //Err 3 0x2D

        //// OBD1 - These adresses are for Crome <= 1.2 dataloger plugin
        //public int ECT_CROME12 = 0x10;
        //public int IAT_CROME12 = 0x11;
        //public int O2_CROME12 = 0x12;
        //public int BARO_CROME12 = 0x13;
        //public int MAP_CROME12 = 0x14;
        //public int TPS_CROME12 = 0x15;
        //public int RPMLOW_CROME12 = 0x16;
        //public int RPMHIGH_CROME12 = 0x17;
        //public int LOCAM_CROME12 = 0x19;
        //public int HICAM_CROME12 = 0x1A;
        //public int COL_CROME12 = 0x1B;
        //public int VSS_CROME12 = 0x20;
        //public int VTEC_CROME12 = 0x18;
        //public int IGN_CROME12 = 0x23;
        //public int INJLOW_CROME12 = 0x21;
        //public int INJHIGH_CROME12 = 0x08;
        //public int KNOCK_CROME12 = 0x24;
        //public int CRANK_CROME12 = 0x25;

        //// **************************************************
        //// OBD1 - These adresses are for Crome >= 1.4 dataloger plugin aka QD2
        //// **************************************************
        //int ECT_CROME14 = 0x1D;
        //int IAT_CROME14 = 0x1B;
        //int O2_CROME14 = 0x20;
        //int BARO_CROME14 = 0x1E;
        //int MAP_CROME14 = 0x14;
        //int TPS_CROME14 = 0x15;
        //int RPMLOW_CROME14 = 0x10;
        //int RPMHIGH_CROME14 = 0x11;
        //int LOCAM_CROME14 = 0x12;
        //int HICAM_CROME14 = 0x13;
        //int COL_CROME14 = 0x16;
        //int VSS_CROME14 = 0x1C;
        //int VTEC_CROME14 = 0x22;
        //int IGN_CROME14 = 0x19;
        //int INJLOW_CROME14 = 0x17;
        //int INJHIGH_CROME14 = 0x18;
        //int KNOCK_CROME14 = 0x1A;
        ////int CRANK_CROME14  = 0x00;
        //int BATT_CROME14 = 0x22;

        //// **************************************************
        //// OBD0 - These adresses are for NG60 maps
        //// **************************************************
        //int ECT_NG60 = 0x30;
        //int IAT_NG60 = 0x32;
        //int O2_NG60 = 0xFB;
        //int BARO_NG60 = 0x34;
        //int MAP_NG60 = 0x36;
        //int TPS_NG60 = 0x39;
        //int RPMLOW_NG60 = 0xFA;
        //int RPMHIGH_NG60 = 0x17;
        //int LOCAM_NG60 = 0xFE;
        ////int HICAM_NG60   0x00;
        //int COL_NG60 = 0xFD;
        //int VSS_NG60 = 0x6C;
        //int VTEC_NG60 = 0x18;
        ////int IGN_NG60     0x00;
        ////int INJLOW_NG60  0x00;
        ////int INJHIGH_NG60 0x00;
        ////int KNOCK_NG60   0x00;
        ////int CRANK_NG60   0x00;
        ////int BATT_NG60    0x00;


        // ******************************************************
        // NG63 maps
        // ******************************************************

        int ECT = 0x30;
        int IAT =0x32;
        int MAP = 0xF8;
        int Barometric_Pressure = 0x34;
        int TPS = 0x39;
        int O2Sensor = 0xFB;
        int RPM_Hi = 0x47;
        int RPM_Low = 0xFA;
        int Table_Row = 0x3B;
        int Table_Column = 0xFD;
        int Gear = 0xFE;
        int VSS_Speed = 0x6C;
        int ELD = 0xFC;
        int Timing = 0x63;
        int Fuel_Hi = 0x6F;
        int Fuel_Lo = 0x70;
        int Err_1 = 0x2B;
        int Err_2 = 0x2C;
        int Err_3 = 0x2D;


        public bool ConnectSerial(string port, string baudrate, string databits)
        {
            bool connected = false;

            

            _serialPort.PortName = port;
            _serialPort.BaudRate = baudrate;
            _serialPort.Parity = SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = data;
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            return connected;

        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console.WriteLine(message);
                }
                catch (TimeoutException) { }
            }
        }

    }




}

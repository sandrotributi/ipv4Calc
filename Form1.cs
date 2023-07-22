namespace ipCalc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int cidr;
        byte[] ipAddress = new byte[] { 192, 168, 0, 1 };
        byte[] netAddress = new byte[] { 192, 168, 0, 0 };
        byte[] broadcastAddress = new byte[] { 192, 168, 1, 255 };
        byte[] hostMin = new byte[] { 192, 168, 0, 1 };
        byte[] hostMax = new byte[] { 192, 168, 0, 254 };
        byte[] sm = new byte[] { 255, 255, 255, 0 };
        byte[] wm = new byte[] { 0, 0, 0, 255 };
        char ipClass = 'C';

        

        byte[,] subnetMasks = new byte[,]
        {
            { 255, 0, 0, 0 },       // 8
            { 255, 128, 0, 0 },     // 9
            { 255, 192, 0, 0 },     // 10
            { 255, 224, 0, 0 },     // 11
            { 255, 240, 0, 0 },     // 12
            { 255, 248, 0, 0 },     // 13
            { 255, 252, 0, 0 },     // 14
            { 255, 254, 0, 0 },     // 15
            { 255, 255, 0, 0 },     // 16
            { 255, 255, 128, 0 },   // 17
            { 255, 255, 192, 0 },   // 18
            { 255, 255, 224, 0 },   // 19
            { 255, 255, 240, 0 },   // 20
            { 255, 255, 248, 0 },   // 21
            { 255, 255, 252, 0 },   // 22
            { 255, 255, 254, 0 },   // 23
            { 255, 255, 255, 0 },   // 24
            { 255, 255, 255, 128 }, // 25
            { 255, 255, 255, 192 }, // 26
            { 255, 255, 255, 224 }, // 27
            { 255, 255, 255, 240 }, // 28
            { 255, 255, 255, 248 }, // 29
            { 255, 255, 255, 252 }, // 30
            { 255, 255, 255, 254 }, // 31
            { 255, 255, 255, 255 }  // 32
        };

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789." + (char)8;
            if (st.IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
            displayData();
        }

        private string maskToString(int cidr)
        {
            return Convert.ToString(subnetMasks[cidr - 8, 0]) + "." + Convert.ToString(subnetMasks[cidr - 8, 1]) + "." 
                + Convert.ToString(subnetMasks[cidr - 8, 2]) + "." + Convert.ToString(subnetMasks[cidr - 8, 3]);
        }

        private string decToBin(int n, int nBits)
        {
            string bin = "";
            int r, q;

            for (int i = 0; i < nBits; i++)
            {
                r = n % 2;
                bin = r.ToString() + bin;
                q = n / 2;
                n = q;
            }

            return bin;
        }

        private string toString(byte[] b)
        {
            return b[0].ToString() + "." + b[1].ToString() + "." 
                + b[2].ToString() + "." + b[3].ToString();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            displayData();    
        }

        private void displayData()
        {
            int i = 0;
            int esp;
            string tmp;
            string sIp = textBoxAddress.Text;
            string[] octets = sIp.Split('.');
            foreach (string oct in octets)
            {
                ipAddress[i] = Convert.ToByte(oct);
                i++;
            }
            cidr = (int)numericUpDownCidr.Value;
            for (i = 0; i < 4; i++)
            {
                sm[i] = subnetMasks[cidr - 8, i];
            }
            for (i = 0; i < 4; i++)
            {
                wm[i] = (byte)~subnetMasks[cidr - 8, i];
            }
            // indirizzo ip
            labelIpAddress.Text = toString(ipAddress);
            labelIpAddressBin.Text = bytesToBinaryString(ipAddress);
            // subnet mask
            labelNetmask.Text = toString(sm) + " = " + cidr.ToString();
            labelNetmaskBin.Text = bytesToBinaryString(sm);
            // wildcard mask
            labelWildcardMask.Text = toString(wm);
            labelWildcardMaskBin.Text = bytesToBinaryString(wm);
            // inidirizzo di rete
            netAddress = getNetworkAddress(ipAddress, sm);
            labelNetworkAddress.Text = toString(netAddress) + "/" + cidr.ToString();
            labelNetworkAddressBin.Text = bytesToBinaryString(netAddress);
            // ip class
            labelIpClass.Text = "(Class " + getIpClass(netAddress[0]) + ")";
            // inirizzo di broadcast
            broadcastAddress = getBroadcastAddress(ipAddress, wm);
            labelBcastAddress.Text = toString(broadcastAddress);
            labelBcastAddressBin.Text = bytesToBinaryString(broadcastAddress);
            // host min
            hostMin = getHostMinAddress(netAddress);
            labelHostMin.Text = toString(hostMin);
            labelHostMinBin.Text = bytesToBinaryString(hostMin);
            // host max
            hostMax = getHostMaxAddress(broadcastAddress);
            labelHostMax.Text = toString(hostMax);
            labelHostMaxBin.Text = bytesToBinaryString(hostMax);
            // hosts per net
            esp = 32 - cidr;
            labelHostNet.Text =Convert.ToString(Math.Pow(2, esp) - 2);
        }

        private string bytesToBinaryString(byte[] b)
        {
            return decToBin(b[0], 8) + "." + decToBin(b[1], 8)
                + "." + decToBin(b[2], 8) + "." + decToBin(b[3], 8);
        }

        private byte[] getNetworkAddress(byte[] ip, byte[] m)
        {
            byte[] address = new byte[4];
            address[0] = (byte)(ip[0] & m[0]);
            address[1] = (byte)(ip[1] & m[1]);
            address[2] = (byte)(ip[2] & m[2]);
            address[3] = (byte)(ip[3] & m[3]);
            return address;
        }

        private byte[] getBroadcastAddress(byte[] ip, byte[] m)
        {
            byte[] address = new byte[4];
            address[0] = (byte)(ip[0] | m[0]);
            address[1] = (byte)(ip[1] | m[1]);
            address[2] = (byte)(ip[2] | m[2]);
            address[3] = (byte)(ip[3] | m[3]);
            return address;
        }

        private byte[] getHostMinAddress(byte[] ip) 
        {
            byte[] address = new byte[4];
            address[0] = ip[0];
            address[1] = ip[1];
            address[2] = ip[2];
            address[3] = (byte)(ip[3] + 1);
            return address;
        }

        private byte[] getHostMaxAddress(byte[] ip)
        {
            byte[] address = new byte[4];
            address[0] = ip[0];
            address[1] = ip[1];
            address[2] = ip[2];
            address[3] = (byte)(ip[3] - 1);
            return address;
        }

        private char getIpClass(byte b)
        {
            char cl = '-';
            if (b >= 0 && b <= 127) { cl = 'A'; }
            if (b > 127 && b < 191) { cl = 'B'; }
            if (b > 191 && b < 224) { cl = 'C'; }
            if (b > 224 && b <= 239) { cl = 'D'; }
            if (b > 239) { cl = 'E'; }
            return cl;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
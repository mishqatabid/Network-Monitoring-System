using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Monitoring_Sytem
{
    public partial class MainForm : Form
    {
        bool sidebarExpand;
        bool devicesCollapsed;

        // Create a router
        Router router = new Router("Router1", new MACAddress(new byte[] { 0x00, 0x99, 0xBB, 0xCC, 0x55, 0xEE }));

        // Create a switch
        Switch sw = new Switch("Switch1", new MACAddress(new byte[] { 0x00, 0x99, 0xBB, 0xCC, 0xDD, 0xEE }));

        // Create 3 PCs
        static PC pc1 = new PC("PC1", new MACAddress(new byte[] { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55 }));
        static PC pc2 = new PC("PC2", new MACAddress(new byte[] { 0x00, 0x22, 0x33, 0x44, 0x55, 0x66 }));
        static PC pc3 = new PC("PC3", new MACAddress(new byte[] { 0x00, 0x22, 0x33, 0x44, 0x55, 0x77 }));

        // Create a Server
        Server s1 = new Server("Server1");

        // IPs of PCs and Router
        public static string IP1;
        public static string IP2;
        public static string IP3;
        public static string IProu;

        // Interface of Each PC
        static Interface pc1Iface = new Interface();
        static Interface pc2Iface = new Interface();
        static Interface pc3Iface = new Interface();

        // Interface for Router
        static Interface routerIface = new Interface();

        // Interface of Switches
        static Interface swIface1 = new Interface();
        static Interface swIface2 = new Interface();
        static Interface swIface3 = new Interface();
        static Interface swIface4 = new Interface();

        // Packet from PC1 to PC2
        Packet packet1 = new Packet();

        // Packet from PC1 to PC3
        Packet packet2 = new Packet();

        // Packet from PC2 to PC1
        Packet packet3 = new Packet();

        // Packet from PC2 to PC3
        Packet packet4 = new Packet();

        // Packet from PC3 to PC1
        Packet packet5 = new Packet();

        // Packet from PC3 to PC2
        Packet packet6 = new Packet();

        public MainForm()
        {
            InitializeComponent();

            // Create interface for Router
            routerIface.set_inter1("RouterInterface", IProu, new MACAddress(new byte[] { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55 }));

            // Create Interfaces for Switche
            swIface1.set_inter1("SwitchInterface1", "212.154.25.36", new MACAddress(new byte[] { 0x00, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE }));
            swIface2.set_inter1("SwitchInterface2", "155.255.688.25", new MACAddress(new byte[] { 0x00, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF }));
            swIface3.set_inter1("SwitchInterface3", "184.32.5.2", new MACAddress(new byte[] { 0x11, 0x22, 0xCC, 0xDD, 0xEE, 0xFF }));
            swIface4.set_inter1("SwitchInterface4", "172.30.12.5", new MACAddress(new byte[] { 0x33, 0xAA, 0x55, 0xDD, 0xEE, 0xFF }));

            // Create Interfaces for PCs
            pc1Iface.set_inter(pc1, IP1);
            pc2Iface.set_inter(pc2,IP2);
            pc3Iface.set_inter(pc3,IP3);

            // Connect the devices together by adding interfaces to their respective lists
            router.AddInterface(routerIface);
            sw.AddInterface(swIface1);
            sw.AddInterface(swIface2);
            sw.AddInterface(swIface3);
            sw.AddInterface(swIface4);
            pc1.AddInterface(pc1Iface);
            pc2.AddInterface(pc2Iface);

            // Add MAC address entries to the switch's forwarding table
            sw.LearnAddress(pc1.MACAddress, swIface1);
            sw.LearnAddress(pc2.MACAddress, swIface2);
            sw.LearnAddress(pc3.MACAddress, swIface3);


            // Access the variable from the source form
            IP1 = PC1.ipadd;
            IP2 = PC2.ipadd;
            IP3 = PC3.ipadd;
            IProu = Router_Config.ipadd;

            // Use the value as needed
            lblpc1.Text = IP1;
            lblpc2.Text = IP2;
            lblpc3.Text = IP3;
            lbliprou.Text = IProu;
        }

        // Showing the Configuration Form for PC1
        private void pcc1_Click(object sender, EventArgs e)
        {
            PC1 pc_1 = new PC1();
            pc_1.Show();
            this.Hide();
        }
        // Showing the Configuration Form for PC2
        private void pcc2_Click(object sender, EventArgs e)
        {
            PC2 pc_2 = new PC2();
            pc_2.Show();
            this.Hide();
        }
        // Showing the Configuration Form for PC3
        private void pcc3_Click(object sender, EventArgs e)
        {
            PC3 pc_3 = new PC3();
            pc_3.Show();
            this.Hide();
        }
        // Showing the Configuration Form for Router
        private void rou_pic_Click(object sender, EventArgs e)
        {
            Router_Config rcc = new Router_Config();
            rcc.Show();
            this.Hide();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //SET maximum and minimum size of sidebar Panel

            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menubox_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest to make it smoother
            sidebarTimer.Start();
        }

        private void DevicesTimer_Tick(object sender, EventArgs e)
        {
            //SET maximum and minimum size of Devices Panel

            if (devicesCollapsed)
            {
                devices_container.Height += 10;
                if (devices_container.Height == devices_container.MaximumSize.Height)
                {
                    devicesCollapsed = false;
                    DevicesTimer.Stop();
                }
            }
            else
            {
                devices_container.Height -= 10;
                if (devices_container.Height == devices_container.MinimumSize.Height)
                {
                    devicesCollapsed = true;
                    DevicesTimer.Stop();
                }
            }
        }

        private void NetworkPic_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest to make it smoother
            DevicesTimer.Start();
        }

        // Showing the Exit 
        private void logoutbutton_Click(object sender, EventArgs e)
        {
            exit ex = new exit();
            ex.Show();
            this.Hide();
        }
         
        // Capturing the Packet
        private void capturePacket_Click(object sender, EventArgs e)
        {
            if(pc1_2.Checked)
            {
                packet1.set_info(pc1Iface, pc2Iface, "Hello from PC1 to PC2");
                // Capturing the packet
                mainmessage.Text = s1.CapturePacket(packet1);
            }
            else if(pc1_3.Checked)
            {
                packet2.set_info(pc1Iface, pc3Iface, "Hello from PC1 to PC3");
                // Capturing the packet
                mainmessage.Text = s1.CapturePacket(packet2);
            }
            else if (pc2_1.Checked)
            {
                packet3.set_info(pc2Iface, pc1Iface, "Hello from PC2 to PC1");
                // Capturing the packet
                mainmessage.Text = s1.CapturePacket(packet3);
            }
            else if (pc2_3.Checked)
            {
                packet4.set_info(pc2Iface, pc3Iface, "Hello from PC2 to PC3");
                // Capturing the packet
                mainmessage.Text = s1.CapturePacket(packet4);
            }
            else if (pc3_1.Checked)
            {
                packet5.set_info(pc3Iface, pc1Iface, "Hello from PC3 to PC1");
                // Capturing the packet
                mainmessage.Text = s1.CapturePacket(packet5);
            }
            else if(pc3_2.Checked)
            {
                packet6.set_info(pc3Iface, pc2Iface, "Hello from PC3 to PC2");
                // Capturing the packet
                mainmessage.Text = s1.CapturePacket(packet6);
            }
            else
            {
                MessageBox.Show("Select an option to capture the packet", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pc1_2_CheckedChanged(object sender, EventArgs e)
        {
            if(pc1_2.Checked == true)
            {
                // to allow selecting one at a time
                pc1_3.Checked = false;
                pc2_1.Checked = false;
                pc2_3.Checked = false;
                pc3_1.Checked = false;
                pc3_2.Checked = false;
            }
        }

        private void pc1_3_CheckedChanged(object sender, EventArgs e)
        {
            if (pc1_3.Checked == true)
            {

                // to allow selecting one at a time
                pc1_2.Checked = false;
                pc2_1.Checked = false;
                pc2_3.Checked = false;
                pc3_1.Checked = false;
                pc3_2.Checked = false;
            }
        }

        private void pc2_3_CheckedChanged(object sender, EventArgs e)
        {
            if (pc2_3.Checked == true)
            {

                // to allow selecting one at a time
                pc1_3.Checked = false;
                pc2_1.Checked = false;
                pc1_2.Checked = false;
                pc3_1.Checked = false;
                pc3_2.Checked = false;
            }
        }

        private void pc2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (pc2_1.Checked == true)
            {
                // to allow selecting one at a time
                pc1_3.Checked = false;
                pc1_2.Checked = false;
                pc2_3.Checked = false;
                pc3_1.Checked = false;
                pc3_2.Checked = false;
            }
        }

        private void pc3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (pc3_1.Checked == true)
            {

                // to allow selecting one at a time
                pc1_3.Checked = false;
                pc2_1.Checked = false;
                pc2_3.Checked = false;
                pc1_2.Checked = false;
                pc3_2.Checked = false;
            }
        }

        private void pc3_2_CheckedChanged(object sender, EventArgs e)
        {
            if (pc3_2.Checked == true)
            {
                // to allow selecting one at a time
                pc1_3.Checked = false;
                pc2_1.Checked = false;
                pc2_3.Checked = false;
                pc3_1.Checked = false;
                pc1_2.Checked = false;
            }
        }


        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (pc12.Checked)
            {
                packet1.set_info(pc1Iface, pc2Iface, "Hello from PC1 to PC2");
                // Sending the packet
                sw.SendPacket(packet1, pc1Iface);
                MessageBox.Show($"Packet SENT \r\n ", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (pc13.Checked)
            {
                packet2.set_info(pc1Iface, pc3Iface, "Hello from PC1 to PC3");
                // Sending the packet
                sw.SendPacket(packet2, pc1Iface);
                MessageBox.Show("Packet SENT", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (pc21.Checked)
            {
                packet3.set_info(pc2Iface, pc1Iface, "Hello from PC2 to PC1");
                // Sending the packet
                sw.SendPacket(packet3, pc2Iface);
                MessageBox.Show("Packet SENT", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (pc23.Checked)
            {
                packet4.set_info(pc2Iface, pc3Iface, "Hello from PC2 to PC3");
                // Sending the packet
                sw.SendPacket(packet4, pc2Iface);
                MessageBox.Show("Packet SENT", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (pc31.Checked)
            {
                packet5.set_info(pc3Iface, pc1Iface, "Hello from PC3 to PC1");
                // Sending the packet
                sw.SendPacket(packet5, pc3Iface);
                MessageBox.Show("Packet SENT", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (pc32.Checked)
            {
                packet6.set_info(pc3Iface, pc2Iface, "Hello from PC3 to PC2");
                // Sending the packet
                sw.SendPacket(packet6, pc3Iface);
                MessageBox.Show("Packet SENT", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Select an option to SEND Packet", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pc12_CheckedChanged(object sender, EventArgs e)
        {
            if (pc12.Checked == true)
            {
                // to allow selecting one at a time
                pc13.Checked = false;
                pc21.Checked = false;
                pc23.Checked = false;
                pc31.Checked = false;
                pc32.Checked = false;
            }
        }

        private void pc13_CheckedChanged(object sender, EventArgs e)
        {
            if (pc13.Checked == true)
            {
                // to allow selecting one at a time
                pc12.Checked = false;
                pc21.Checked = false;
                pc23.Checked = false;
                pc31.Checked = false;
                pc32.Checked = false;
            }
        }

        private void pc23_CheckedChanged(object sender, EventArgs e)
        {
            if (pc23.Checked == true)
            {
                // to allow selecting one at a time
                pc13.Checked = false;
                pc21.Checked = false;
                pc12.Checked = false;
                pc31.Checked = false;
                pc32.Checked = false;
            }
        }

        private void pc21_CheckedChanged(object sender, EventArgs e)
        {
            if (pc21.Checked == true)
            {
                // to allow selecting one at a time
                pc13.Checked = false;
                pc12.Checked = false;
                pc23.Checked = false;
                pc31.Checked = false;
                pc32.Checked = false;
            }
        }

        private void pc31_CheckedChanged(object sender, EventArgs e)
        {
            if (pc31.Checked == true)
            {
                // to allow selecting one at a time
                pc13.Checked = false;
                pc21.Checked = false;
                pc23.Checked = false;
                pc12.Checked = false;
                pc32.Checked = false;
            }
        }

        private void pc32_CheckedChanged(object sender, EventArgs e)
        {
            if (pc32.Checked == true)
            {
                // to allow selecting one at a time
                pc13.Checked = false;
                pc21.Checked = false;
                pc23.Checked = false;
                pc31.Checked = false;
                pc12.Checked = false;
            }
        }

        private void receivebutton_Click(object sender, EventArgs e)
        {
            if (pc1_pc2.Checked)
            {
                // Receiving the packet
                if (pc2Iface.receivepacket(packet1) == true)
                {
                    MessageBox.Show("Packet RECEIVED from PC1 to PC2", "Received", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Packet NOT Received", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (pc1_pc3.Checked)
            {
                // Receiving the packet
                if (pc3Iface.receivepacket(packet2) == true)
                {
                    MessageBox.Show("Packet RECEIVED from PC1 to PC3", "Received", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Packet NOT Received", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (pc2_pc1.Checked)
            {
                // Receiving the packet
                if (pc1Iface.receivepacket(packet3) == true)
                {
                    MessageBox.Show("Packet RECEIVED from PC2 to PC1", "Received", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Packet NOT Received", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (pc2_pc3.Checked)
            {
                // Receiving the packet
                if (pc3Iface.receivepacket(packet4) == true)
                {
                    MessageBox.Show("Packet RECEIVED from PC2 to PC3", "Received", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Packet NOT Received", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (pc3_pc1.Checked)
            {
                // Receiving the packet
                if (pc1Iface.receivepacket(packet5) == true)
                {
                    MessageBox.Show("Packet RECEIVED from PC3 to PC1", "Received", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Packet NOT Received", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (pc3_pc2.Checked)
            {
                // Receiving the packet
                if (pc2Iface.receivepacket(packet6) == true)
                {
                    MessageBox.Show("Packet RECEIVED from PC3 to PC2", "Received", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Packet NOT Received", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select an option to RECEIVE packet", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pc1_pc2_CheckedChanged(object sender, EventArgs e)
        {
            if (pc1_pc2.Checked == true)
            {
                // to allow selecting one at a time
                pc1_pc3.Checked = false;
                pc2_pc1.Checked = false;
                pc2_pc3.Checked = false;
                pc3_pc1.Checked = false;
                pc3_pc2.Checked = false;
            }
        }

        private void pc1_pc3_CheckedChanged(object sender, EventArgs e)
        {
            if (pc1_pc3.Checked == true)
            {
                // to allow selecting one at a time
                pc3_pc2.Checked = false;
                pc2_pc1.Checked = false;
                pc2_pc3.Checked = false;
                pc3_pc1.Checked = false;
                pc1_pc2.Checked = false;
            }
        }

        private void pc2_pc3_CheckedChanged(object sender, EventArgs e)
        {
            if (pc2_pc3.Checked == true)
            {
                // to allow selecting one at a time
                pc1_pc3.Checked = false;
                pc2_pc1.Checked = false;
                pc3_pc2.Checked = false;
                pc3_pc1.Checked = false;
                pc1_pc2.Checked = false;
            }
        }

        private void pc2_pc1_CheckedChanged(object sender, EventArgs e)
        {
            if (pc2_pc1.Checked == true)
            {
                // to allow selecting one at a time
                pc1_pc3.Checked = false;
                pc3_pc2.Checked = false;
                pc2_pc3.Checked = false;
                pc3_pc1.Checked = false;
                pc1_pc2.Checked = false;
            }
        }

        private void pc3_pc1_CheckedChanged(object sender, EventArgs e)
        {
            if (pc3_pc1.Checked == true)
            {
                // to allow selecting one at a time
                pc1_pc3.Checked = false;
                pc2_pc1.Checked = false;
                pc2_pc3.Checked = false;
                pc3_pc2.Checked = false;
                pc1_pc2.Checked = false;
            }
        }

        private void pc3_pc2_CheckedChanged(object sender, EventArgs e)
        {
            if (pc3_pc2.Checked == true)
            {
                // to allow selecting one at a time
                pc1_pc3.Checked = false;
                pc2_pc1.Checked = false;
                pc2_pc3.Checked = false;
                pc3_pc1.Checked = false;
                pc1_pc2.Checked = false;
            }
        }
        // Triggering the Poll functions
        private void pollbutton_Click(object sender, EventArgs e)
        {
            if (pc1poll.Checked == true)
            {
                pollmessage.Text = s1.poll(pc1Iface, pc1);
            }
            else if (pc2poll.Checked == true)
            {
                pollmessage.Text = s1.poll(pc2Iface, pc2);
            }
            else if (pc3poll.Checked == true)
            {
                pollmessage.Text = s1.poll(pc3Iface, pc3);
            }
            else if (switchpoll.Checked == true)
            {
                pollmessage.Text = s1.poll(swIface4, sw);
            }
            else if (routerpoll.Checked == true)
            {
                pollmessage.Text = s1.poll(routerIface, router);
            }
            else
            {
                MessageBox.Show("Select Device to POLL", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pc1poll_CheckedChanged(object sender, EventArgs e)
        {
            if (pc1poll.Checked == true)
            {
                // to allow selecting one at a time
                pc2poll.Checked = false;
                pc3poll.Checked = false;
                switchpoll.Checked = false;
                routerpoll.Checked = false;
            }
        }

        private void pc2poll_CheckedChanged(object sender, EventArgs e)
        {
            if (pc2poll.Checked == true)
            {
                // to allow selecting one at a time
                pc1poll.Checked = false;
                pc3poll.Checked = false;
                switchpoll.Checked = false;
                routerpoll.Checked = false;
            }
        }

        private void pc3poll_CheckedChanged(object sender, EventArgs e)
        {
            if (pc3poll.Checked == true)
            {
                // to allow selecting one at a time
                pc2poll.Checked = false;
                pc1poll.Checked = false;
                switchpoll.Checked = false;
                routerpoll.Checked = false;
            }
        }

        private void switchpoll_CheckedChanged(object sender, EventArgs e)
        {
            if (switchpoll.Checked == true)
            {
                // to allow selecting one at a time
                pc2poll.Checked = false;
                pc3poll.Checked = false;
                pc1poll.Checked = false;
                routerpoll.Checked = false;
            }    
        }

        private void routerpoll_CheckedChanged(object sender, EventArgs e)
        {
            if (routerpoll.Checked == true)
            {
                // to allow selecting one at a time
                pc2poll.Checked = false;
                pc3poll.Checked = false;
                switchpoll.Checked = false;
                pc1poll.Checked = false;
            } 
        }
        // Showing the Ping form to trigger the ping funtion of server
        private void pingbutton_Click(object sender, EventArgs e)
        {
            if (pc1ping.Checked == true)
            {
                ping p1 = new ping(PC1.ipadd);
                p1.Show();
            }
            else if (pc2ping.Checked == true)
            {
                ping p1 = new ping(PC2.ipadd);
                p1.Show();
            }
            else if (pc3ping.Checked == true)
            {
                ping p1 = new ping(PC3.ipadd);
                p1.Show();
            }
            else if (switchping.Checked == true)
            {
                ping p1 = new ping(swIface4.IPAddress);
                p1.Show();
            }
            else if(routerping.Checked == true)
            {
                ping p1 = new ping(Router_Config.ipadd);
                p1.Show();
            }
            else
            {
                MessageBox.Show("Select Option to PING", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pc1ping_CheckedChanged(object sender, EventArgs e)
        {
            if (pc1ping.Checked == true)
            {
                // to allow selecting one at a time
                pc2ping.Checked = false;
                pc3ping.Checked = false;
                switchping.Checked = false;
                routerping.Checked = false;
            }
        }

        private void pc2ping_CheckedChanged(object sender, EventArgs e)
        {
            if (pc2ping.Checked == true)
            {
                // to allow selecting one at a time
                pc1ping.Checked = false;
                pc3ping.Checked = false;
                switchping.Checked = false;
                routerping.Checked = false;
            }
        }

        private void pc3ping_CheckedChanged(object sender, EventArgs e)
        {
            if (pc3ping.Checked == true)
            {
                // to allow selecting one at a time
                pc2ping.Checked = false;
                pc1ping.Checked = false;
                switchping.Checked = false;
                routerping.Checked = false;
            }
        }

        private void switchping_CheckedChanged(object sender, EventArgs e)
        {
            if (switchping.Checked == true)
            {
                // to allow selecting one at a time
                pc2ping.Checked = false;
                pc3ping.Checked = false;
                pc1ping.Checked = false;
                routerping.Checked = false;
            }
        }

        private void routerping_CheckedChanged(object sender, EventArgs e)
        {
            if (routerping.Checked == true)
            {
                // to allow selecting one at a time
                pc2ping.Checked = false;
                pc3ping.Checked = false;
                switchping.Checked = false;
                pc1ping.Checked = false;
            }
        }
    }
}


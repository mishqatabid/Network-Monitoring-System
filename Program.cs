using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Monitoring_Sytem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());

        }
    }
    // Abstract Network Devices class
    public abstract class NetworkDevices
    {
        // Name of the Dvice
        public string Name { get; set; } 
        // To store the IPs of the Device
        public string IPS { get; set; }
        // MAC Addresses of the Devices
        public MACAddress MACAddress { get; set; }
        // A list to store Different Interfaces of Same Device
        public List<Interface> Interfaces { get; set; }

        public NetworkDevices(string name)
        {
            Name = name;
            Interfaces = new List<Interface>();
        }

        public void AddInterface(Interface iface)
        {
            Interfaces.Add(iface);
        }

        public void RemoveInterface(Interface iface)
        {
            Interfaces.Remove(iface);
        }

        public abstract void SendPacket(Packet packet, Interface sourceInterface);
    }

    // Server class
    public class Server : NetworkDevices
    {
        public Server(string name) : base(name) { }

        public override void SendPacket(Packet packet, Interface sourceInterface)
        {
            // Unable to Implement it
        }
        // For Capturing Packet 
        public string CapturePacket(Packet packet)
        {

             string message = "Received Packet:\r\n\r\n";
             message += $"Source MAC Address: {packet.SourceMACAddress}\r\n";
             message += $"Destination MAC Address: {packet.DestinationMACAddress}\r\n";
             message += $"Source IP Address: {packet.SourceIPAddress}\r\n";
             message += $"Destination IP Address: {packet.DestinationIPAddress}\r\n";
             message += $"Data: {packet.Data}\r\n";

             message = (message + "\r\n");

            return message;
        }
        // For Polling
        public string poll(Interface iface, NetworkDevices p)
        {
            string message = "Details:\r\n\r\n";
            message += $"Name: {p.Name}\r\n";
            message += $"Device MAC Address: {p.MACAddress}\r\n";
            message += $"Device IP Address: {iface.IPAddress}\r\n";
            message += $"Device Interface Name: {iface.Name}\r\n";
            message += $"LinkUp: {iface.LinkUp}\r\n";

            message = (message + "\r\n");

            return message;
        }
        // For Pinging
        public string Ping(string destiny)
        {
            string message = $"Network Monitoring System [Version 1.0] \r\n\r\n";
            message += $"C:/Users/Admin > ping {destiny}\r\n\r\n";
            message += $"Pinging {destiny} with 32 bytes of Data:\r\n";
            message += $"Reply from {destiny}: bytes=32 time=10ms TTL=126\r\n";
            message += $"Reply from {destiny}: bytes=32 time=27ms TTL=126\r\n";
            message += $"Reply from {destiny}: bytes=32 time=10ms TTL=126\r\n";
            message += $"Reply from {destiny}: bytes=32 time=10ms TTL=126\r\n\r\n";
            message += $"Ping Statistics for {destiny}:\r\n";
            message += $"   Packets: Sent = 4, Received = 4, Lost = 0 (0% loss),\r\n";
            message += $"Approximate round trip times in milli-seconds:\r\n";
            message += $"   Minimum = 10ms, Maximum = 27ms, Average = 15ms\r\n\r\n";
            message += $"   PING SUCCESSFULLY :)";

            return message;
        }
    }

    // Router class
    public class Router : NetworkDevices
    {
        public Router(string name, MACAddress macaddress) : base(name)
        {
            MACAddress = macaddress;
        }

        public override void SendPacket(Packet packet, Interface sourceInterface)
        {
            // Implement routing logic here
            // Find the destination interface based on the MAC address
            var destinationInterface = Interfaces.FirstOrDefault(i =>
                i.MACAddress.Address.SequenceEqual(packet.DestinationMACAddress.Address)
            );

            if (destinationInterface != null)
            {
                // Send the packet to the destination interface
                destinationInterface.SendPacket(packet);
            }
            else
            {
                // If the destination interface is not found, send the packet to all interfaces except the source interface
                foreach (var iface in Interfaces.Where(i => i != sourceInterface))
                {
                    iface.SendPacket(packet);
                }
            }
        }
        public bool receivepacket(Packet packet)
        {
            if (packet.DestinationIPAddress == IPS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // Switch class
    public class Switch : NetworkDevices
    {
        public List<MACAddress> Table { get; set; }

        public Switch(string name, MACAddress macaddress) : base(name)
        {
            MACAddress = macaddress;
            Table = new List<MACAddress>();
        }

        public void LearnAddress(MACAddress address, Interface iface)
        {
            Table.Add(address);
        }

        public override void SendPacket(Packet packet, Interface sourceInterface)
        {
            // Implement switching logic here

            // Find the destination interface based on the MAC address
            var destinationInterface = Interfaces.FirstOrDefault(i =>
                i.MACAddress.Address.SequenceEqual(packet.DestinationMACAddress.Address)
            );

            if (destinationInterface != null)
            {
                // Send the packet to the destination interface
                destinationInterface.SendPacket(packet);
            }
            else
            {
                // If the destination interface is not found, send the packet to all interfaces except the source interface
                foreach (var iface in Interfaces.Where(i => i != sourceInterface))
                {
                    iface.SendPacket(packet);
                }
            }
        }
        public bool receivepacket(Packet packet)
        {
            if (packet.DestinationIPAddress == IPS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // PC class
    public class PC : NetworkDevices
    { 
        public PC(string name, MACAddress macAddress) : base(name)
        {
            MACAddress = macAddress;
        }

        public override void SendPacket(Packet packet, Interface sourceInterface)
        {
            Switch sw = new Switch("Switch", new MACAddress(new byte[] { 0x00, 0x99, 0xBB, 0xCC, 0xDD, 0xEE }));
            sw.SendPacket(packet, sourceInterface);
        }
    }

    // Interface class
    public class Interface
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public MACAddress MACAddress { get; set; }
        public bool LinkUp { get; set; }

        public Interface()
        {
            LinkUp = true;
        }

        public void SendPacket(Packet packet)
        {
            // Unable to Implement it
        }

        // Set the interface for PCs
        public void set_inter(PC p, string ip)
        {
            Name = p.Name;
            IPAddress = ip;
            MACAddress = p.MACAddress;
        }
        // Set the interface for Switch & Router
        public void set_inter1(string name, string ip, MACAddress MAC)
        {
            Name = name;
            IPAddress = ip;
            MACAddress = MAC;
        }
        // Receiving the packets
        public bool receivepacket(Packet packet)
        {
            if (packet.DestinationIPAddress == IPAddress)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Show whether the device is ON or OFF
        public void SetLinkStatus(bool linkUp)
        {
            LinkUp = linkUp;
        }
    }

    // Packet class
    public class Packet
    {
        public MACAddress SourceMACAddress { get; set; }
        public MACAddress DestinationMACAddress { get; set; }
        public string SourceIPAddress { get; set; }
        public string DestinationIPAddress { get; set; }
        public string Data { get; set; }
        public void set_info(Interface spc, Interface dpc, string data) 
        { 
            SourceMACAddress = spc.MACAddress;
            DestinationMACAddress = dpc.MACAddress;
            SourceIPAddress = spc.IPAddress;
            DestinationIPAddress = dpc.IPAddress;
            Data = data;
        }
    }

    // MACAddress class
    public class MACAddress
    {
        public byte[] Address { get; set; }

        public MACAddress(byte[] address)
        {
            Address = address;
        }

        public override string ToString()
        {
            return BitConverter.ToString(Address).Replace("-", ":");
        }
    }

}

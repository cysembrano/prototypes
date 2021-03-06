﻿using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SimpleSniffer
{
    static class Program
    {
        public const int byteSize = 24;
        static void Main()
        {

            // we are only listening to IPv4 interfaces
            var IPv4Addresses = Dns.GetHostEntry(Dns.GetHostName())
                .AddressList.Where(al => al.AddressFamily == AddressFamily.InterNetwork)
                .AsEnumerable();

            // echo out a header line
            Console.WriteLine("Protocol\tSourceIP:Port\t===>\tDestinationIP:Port");

            // start a sniffer for each interface
            foreach (IPAddress ip in IPv4Addresses)
                Sniff(ip);

            // wait until a key is pressed
            Console.Read();

        }

        static void Sniff(IPAddress ip)
        {

            // setup the socket to listen on, we are listening just to IPv4 IPAddresses
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
            sck.Bind(new IPEndPoint(ip, 0));
            sck.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, optionValue: true);
            sck.IOControl(IOControlCode.ReceiveAll, new byte[4] { 1, 0, 0, 0 }, null);

            //byte array to hold the packet data we want to examine.
            //  we are assuming default (20byte) IP header size + 4 bytes for TCP header to get ports
            byte[] buffer = new byte[Program.byteSize];

            // Async methods for recieving and processing data
            Action<IAsyncResult> OnReceive = null;
            OnReceive = (ar) =>
            {
                Console.WriteLine( //echo the data. details at http://en.wikipedia.org/wiki/IPv4_packet#Packet_structure
                    "{0}\t{1}:{2}\t===>\t{3}:{4}"
                    , buffer.Skip(9).First().ToProtocolString()//todo: gotta be a cleaner way to do this one...
                    , new IPAddress(BitConverter.ToUInt32(buffer, 12)).ToString()
                    , ((ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(buffer, 20))).ToString()
                    , new IPAddress(BitConverter.ToUInt32(buffer, 16)).ToString()
                    , ((ushort)IPAddress.NetworkToHostOrder(BitConverter.ToInt16(buffer, 22))).ToString());
                buffer = new byte[Program.byteSize]; //clean out our buffer
                sck.BeginReceive(buffer, 0, Program.byteSize, SocketFlags.None,
                    new AsyncCallback(OnReceive), null); //listen some more
            };

            // begin listening to the socket
            sck.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None,
                    new AsyncCallback(OnReceive), null);
        }

        // details at http://en.wikipedia.org/wiki/List_of_IP_protocol_numbers
        public static string ToProtocolString(this byte b)
        {
            switch (b)
            {
                case 1: return "ICMP";
                case 6: return "TCP";
                case 17: return "UDP";
                default: return "#" + b.ToString();
            }
        }

    }
}
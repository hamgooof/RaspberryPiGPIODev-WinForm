using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaspberryPiGPIODevUI
{
    class ConnectionManager
    {
        public Socket Socket { get; private set; }
        private const string ipRgx = "([1-2]{0,1}[0-9]{1,2}[.]){3}([1-2]{0,1}[0-9]{1,2})([:]([\\d]{1,4}))?";

        public bool IsConnected()
        {
            return Socket != null && Socket.Connected;
        }

        public bool Connect(string ipAndPort)
        {
            var regex = new Regex(ipRgx);
            if (!regex.IsMatch(ipAndPort))
            {
                MessageBox.Show($"Ip is in the wrong format", "Error - IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var colonPos = ipAndPort.IndexOf(':');
            var ip = ipAndPort.Substring(0, colonPos);
            var port = ipAndPort.Substring(colonPos + 1, ipAndPort.Length - colonPos - 1);

            Socket = CreateSocket(ip, int.Parse(port));
            return true;
        }

        public void WriteToStream(string str)
        {
            //WriteToTextBox($"Writing to stream: {str}");
            var data = Encoding.ASCII.GetBytes(str + "\r\n");
            Socket.Send(data, data.Length, SocketFlags.None);
        }

        private static Socket CreateSocket(string ip, int port)
        {
            var ipAddress = IPAddress.Parse(ip);
            var remoteEp = new IPEndPoint(ipAddress, port);

            // Create a TCP/IP  socket.  
            var sender = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            sender.Connect(remoteEp);

            return sender;
        }
    }
}
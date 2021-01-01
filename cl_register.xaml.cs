using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;

namespace SnapZ_Client_Interface
{
    /// <summary>
    /// Interaction logic for cl_register.xaml
    /// </summary>
    public partial class cl_register : Window
    {
        public cl_register() => InitializeComponent();


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Pb_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Reg_click(object sender, RoutedEventArgs e)
        {
            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
            clientSocket.Connect("127.0.0.1", 70);

            NetworkStream serverStream = clientSocket.GetStream();

            string cmd = String.Concat("[REGU|", username.Text, ":", PasswordBox.Password, "]");
            byte[] msg = Encoding.ASCII.GetBytes(cmd);

            serverStream.Write(msg, 0, msg.Length);
            serverStream.Flush();

            this.Close();
        }
    }
}

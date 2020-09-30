using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

class MyTcpListener
{
    public static void Main()
    {
        TcpListener server = null;
        try
        {
            // Set the TcpListener on port 150.
            Int32 port = 150;

            // TcpListener server = new TcpListener(port);
            server = new TcpListener(IPAddress.Any, port);

            // Start listening for client requests.
            server.Start();

            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            //String data = null;

            // Enter the listening loop.
            while (true)
            {
                // Console.Write("Waiting for a connection... ");

                // Perform a blocking call to accept requests.
                // You could also user server.AcceptSocket() here.
                TcpClient client = server.AcceptTcpClient();
                // Console.WriteLine("Connected!");

                client.Close();
            }
        }
        catch (SocketException e)
        {
            // Console.WriteLine("SocketException: {0}", e);
        }
        finally
        {
            // Stop listening for new clients.
            server.Stop();
        }


        //Console.WriteLine("\nHit enter to continue...");
        //Console.Read();
    }
}
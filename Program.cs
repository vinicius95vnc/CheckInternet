using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace CheckInternet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                Console.WriteLine("Status do IP: " + IPStatus.Success);
                Console.WriteLine("Endereço HOST: " + reply.Address);
                Console.WriteLine("Tamanho do Buffer: " + reply.Buffer.Length);
                Console.WriteLine("Tempo de vida: " + reply.Options.Ttl);
                Console.WriteLine("Tempo execução (ms): " + reply.RoundtripTime);
                               
            } catch (Exception)
            {
                Console.WriteLine("IP não acessível!");
            }
        }
    }
}

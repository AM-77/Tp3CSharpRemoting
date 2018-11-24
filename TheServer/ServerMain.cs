using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemote;

namespace TheServer
{
	class ServerMain
	{
		public static void Main (string[] args)
		{
			try{

				TcpChannel tcpChannel = new TcpChannel(1995);
				ChannelServices.RegisterChannel(tcpChannel, false);

				RemotingConfiguration.RegisterWellKnownServiceType(typeof(MailBox),
					"mailBoxObj", WellKnownObjectMode.Singleton);
				
				Console.Write("[+] The server is running ...");
				Console.ReadLine();
			}catch(Exception e){
				Console.Write ("[!] There was an error in the serverMain : {0}", e.Message);
			}
		}
	}
}

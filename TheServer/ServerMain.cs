using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemote;

namespace TheServer{
	class ServerMain{
		public static void Main (string[] args){
			try{
				TcpChannel tcpChannel = new TcpChannel(1234);
				ChannelServices.RegisterChannel(tcpChannel, false);

				//RemotingConfiguration.RegisterWellKnownServiceType(typeof(MailBox),"mailBoxObj", WellKnownObjectMode.Singleton); /* SingleCall */
				RemotingConfiguration.RegisterWellKnownServiceType(typeof(Fabrique), "fabObj", WellKnownObjectMode.Singleton); /* SingleCall */

				Console.Write("[+] The server is running ...  \n[INFO] Rememeber to activate win32 in .bashrc");
				Console.ReadLine();
			}catch(Exception e){
				Console.Write ("[!] There was an error in the serverMain : {0}", e.Message);
			}
		}
	}
}

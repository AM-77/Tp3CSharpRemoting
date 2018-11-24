using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemote;

namespace TheClient {
	class ClientSender {
		static void Main(string[] args) {
			try{
				TcpChannel chl = new TcpChannel();
				ChannelServices.RegisterChannel(chl, false);
				Console.WriteLine( "Client: Canal enregistré" );
				IMailBox obj = (IMailBox)Activator.GetObject(typeof(IMailBox),"tcp://localhost:1234/mailBoxObj");


				if (obj == null )

					Console.WriteLine("Problème de SERVEUR... " );
				else {
					Console.WriteLine( "Reference acquise de l'objet Singleton" );
					obj.receiveMsg();
					Console.ReadLine();
				}
			}
			catch (Exception e ) {
				Console.WriteLine( "There was an error in the ClientSender : {0}", e.Message );
			}
		} 
	} 
}
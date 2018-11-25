using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemote;
using System.Collections;

namespace TheClientSender {
	class ClientSender {

		static void Main(string[] args) {
			try{
				TcpChannel chl = new TcpChannel();
				ChannelServices.RegisterChannel(chl, false);

				//IMailBox mailBox = (IMailBox)Activator.GetObject(typeof(IMailBox),"tcp://localhost:1234/mailBoxObj");
				IFabrique fab = (IFabrique)Activator.GetObject(typeof(IFabrique),"tcp://localhost:1234/fabObj");
				IMailBox mailBox = fab.getMailBox();

				if (mailBox == null ){
					Console.WriteLine("[!] Object not resolved. " );
				}else {
					Console.WriteLine( "[+] Object recieved.\n" );
					Boolean sending = true;
					Console.Write( "Sender Name: " );
					String sender = Console.ReadLine();
					Console.Write( "Receiver Name: " );
					String receiver = Console.ReadLine();

					Console.Write( "\n[INFO] Type [QUIT] to exit.\n");
					while(sending){

						Console.Write( "The message: " );
						String msg = Console.ReadLine();

						if(msg.Equals("[QUIT]")){
							sending = false;
							Console.Write( "[^_^] Bye! " );
						}else{
							mailBox.sendMsg(new Message(sender, receiver, msg));
						}
			
					}
				}
			}
			catch (Exception e ) {
				Console.WriteLine( "There was an error in the ClientSender : {0}", e.Message );
			}
		} 
	} 
}
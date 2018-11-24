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
				IMailBox mailBox = (IMailBox)Activator.GetObject(typeof(IMailBox),"tcp://localhost:1234/mailBoxObj");


				if (mailBox == null ){
					Console.WriteLine("[!] Object not resolved. " );
				}else {
					Console.WriteLine( "[+] Object recieved.\n" );
					Boolean sending = true;
					Console.Write( "Sender Name: " );
					String sender = Console.ReadLine();

					while(sending){
						Console.Write( "Receiver Name: " );
						String receiver = Console.ReadLine();
						Console.Write( "The message: " );
						String msg = Console.ReadLine();

						mailBox.sendMsg(new Message(sender, receiver, msg));

						Console.Write( "[+] Message sent.\nSend an other message? y/n : " );
						String resend = Console.ReadLine();

						while(true){
							if( !resend.Equals("y") && !resend.Equals("n") ){
								Console.Write( "[!] Invalid input try with y/n : " );
								resend = Console.ReadLine();
							}else{
								if(resend.Equals("n")){
									sending = false;
									Console.Write( "[^_^] Bey! " );
								}

								break;
							}
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
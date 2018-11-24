using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using IRemote;
using System.Collections;

namespace TheClient {
	class ClientSender {
		
		static void Main(string[] args) {
			try{
				TcpChannel chl = new TcpChannel();
				ChannelServices.RegisterChannel(chl, false);
				IMailBox obj = (IMailBox)Activator.GetObject(typeof(IMailBox),"tcp://localhost:1234/mailBoxObj");


				if (obj == null ){
					Console.WriteLine("[!] Object not resolved. " );
				}else {
					Console.WriteLine( "[+] Object recieved." );
					ArrayList msgs = obj.receiveMsg();

					foreach (Message msg in msgs){
						Console.WriteLine("The sender: {0}\nThe reciever: {1}\nThe content: {2}\n\n", msg.sender, msg.receiver, msg.content);
					}
				}
			}
			catch (Exception e ) {
				Console.WriteLine( "There was an error in the ClientSender : {0}", e.Message );
			}
		} 
	} 
}
using System;
using System.Collections;

namespace TheServer
{
	public class MailBox : MarshalByRefObject, IRemote.IMailBox
	{
		
		private ArrayList msgs = new ArrayList();

		public MailBox ()
		{
		}

		void sendMsg(Message msg){
			msgs.Add (msg);
		}

		Message[] receiveMsg(){
			return msgs;
		}
	}
}


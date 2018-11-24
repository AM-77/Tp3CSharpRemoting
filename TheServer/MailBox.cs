using System;
using System.Collections;
using IRemote;

namespace TheServer
{
	public class MailBox : MarshalByRefObject, IRemote.IMailBox
	{
		
		private static ArrayList msgs = new ArrayList();

		public MailBox ()
		{
		}

		public void sendMsg(Message msg){
			msgs.Add (msg);
		}

		public ArrayList receiveMsg(){
			return msgs;
		}
	}
}


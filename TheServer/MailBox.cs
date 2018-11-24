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

		public void sendMsg(IRemote.Message msg){
			msgs.Add (msg);
		}

		public ArrayList receiveMsg(){
			return msgs;
		}
	}
}


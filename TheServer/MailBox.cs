using System;
using System.Collections;
using IRemote;

namespace TheServer
{
	public class MailBox : MarshalByRefObject, IRemote.IMailBox
	{
		
		private ArrayList msgs = new ArrayList();

		public MailBox ()
		{
			msgs.Add (new Message("Houssam","Amine","Hi"));
			msgs.Add (new Message("Amine","Houssam","Wsh"));
			msgs.Add (new Message("Houssam","Amine","cv?"));
			msgs.Add (new Message("Amine","Houssam","oui cool"));
			msgs.Add (new Message("Houssam","Amine","wusup !"));
			msgs.Add (new Message("Amine","Houssam","Rou7 t3ti b3iid"));
			msgs.Add (new Message("Houssam","Amine","lool"));

		}

		public void sendMsg(Message msg){
			msgs.Add (msg);
		}

		public ArrayList receiveMsg(){
			return msgs;
		}
	}
}


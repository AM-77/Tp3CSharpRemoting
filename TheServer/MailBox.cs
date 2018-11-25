using System;
using System.Collections;
using IRemote;

namespace TheServer{
	public class MailBox : MarshalByRefObject, IRemote.IMailBox{

		private static ArrayList msgs = new ArrayList();

		public MailBox(){
			msgs.Add (new Message("dsfsdf","fdsdsf","dsfds"));
			msgs.Add (new Message("dsfsdf","fdsdsf","dsfds"));
			msgs.Add (new Message("dsfsdf","fdsdsf","dsfds"));

		}

		public void sendMsg(Message msg){
			msgs.Add (msg);
		}

		public ArrayList receiveMsg(){
			return msgs;
		}
	}
}


﻿using System;
using System.Collections;
using IRemote;

namespace TheServer
{
	public class MailBox : MarshalByRefObject, IRemote.IMailBox
	{
		
		private static ArrayList msgs = new ArrayList();

		public MailBox ()
		{
			msgs.Add (new Message("Houssam","Amine","Hi"));
			msgs.Add (new Message("Amine","Houssam","Wsh"));
			msgs.Add (new Message("Houssam","Amine","cv?"));
			msgs.Add (new Message("Amine","Houssam","oui cool"));

		}

		public void sendMsg(Message msg){
			msgs.Add (msg);
		}

		public ArrayList receiveMsg(){
			return msgs;
		}
	}
}


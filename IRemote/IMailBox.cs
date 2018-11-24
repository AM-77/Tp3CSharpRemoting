using System;
using System.Collections;

namespace IRemote
{
	public interface IMailBox{
		void sendMsg(Message msg);
		ArrayList receiveMsg() ;
	}
}


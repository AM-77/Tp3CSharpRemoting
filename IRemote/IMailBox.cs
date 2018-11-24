using System;

namespace IRemote
{
	public interface IMailBox{
		void sendMsg(Message msg);
		Message[] receiveMsg() ;
	}
}


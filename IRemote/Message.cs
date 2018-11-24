using System;

namespace IRemote
{
	[Serializable]
	public class Message
	{
		public String sender { set; get; }
		public String receiver { set; get; }
		public String content { set; get; }

		public Message (String sender, String receiver, String content)
		{
			this.sender = sender;
			this.receiver = receiver;
			this.content = content;
		}

	}
}


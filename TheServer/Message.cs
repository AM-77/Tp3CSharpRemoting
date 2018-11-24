using System;

namespace TheServer
{
	public static class Message
	{
		private String sender { set; get; }
		private String receiver { set; get; }
		private String content { set; get; }

		public Message (String sender, String receiver, String content)
		{
			this.sender = sender;
			this.receiver = receiver;
			this.content = content;
		}

	}
}


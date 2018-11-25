using System;
using IRemote;

namespace TheServer {
	public class Fabrique : MarshalByRefObject, IFabrique {
		public IMailBox getMailBox () {
			return (IMailBox)new MailBox();
		}
	}
}
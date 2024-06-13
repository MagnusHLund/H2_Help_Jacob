namespace H2_Help_Jacob
{
	internal abstract class Message
	{
		string[] to;
		string from, body, subject, cc;
		private protected IConverter _converter;

		internal Message(string[] to, string from, string body, string subject, string cc, IConverter converter)
		{
			this.to = to;
			this.from = from;
			this.body = body;
			this.subject = subject;
			this.cc = cc;
			_converter = converter;
		}

		internal string[] To { get => to; set => to = value; }
		internal string From { get => from; set => from = value; }
		internal string Body { get => body; set => body = value; }
		internal string Subject { get => subject; set => subject = value; }
		internal string Cc { get => cc; set => cc = value; }

		internal abstract void SendMessage(bool isHTML);
	}
}

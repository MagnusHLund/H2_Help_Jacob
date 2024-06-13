namespace H2_Help_Jacob
{
	internal class VMessage : Message
	{
		internal VMessage(string[] to, string from, string body, string subject, string cc, Converter converter) : base(to, from, body, subject, cc, converter)
		{
		}

		internal override void SendMessage(bool isHTML)
		{
			if (isHTML)
			{
				this.Body = _converter.ConvertBodyToHTML(this.Body);
			}
			//her implementeres alt koden til at sende via VMessage
			
		}
	}
}

namespace H2_Help_Jacob
{
	internal class Program
	{
		static void Main()
		{
			Converter converter = new Converter();

			string[] to = { "Chadzil" };
			string from = "Yapster";
			string body = "Magnus is very sexy";
			string subject = "The truth";
			string cc = "Marcusse";

			VMessage vMessage = new VMessage(to, from, body, subject, cc, converter);
			SmtpMessage SmtpMessage = new SmtpMessage(to, from, body, subject, cc, converter);

			vMessage.SendMessage(true);
			SmtpMessage.SendMessage(true);
		}
	}
}

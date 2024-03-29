namespace WebApplication2.Service
{
	// Simple interface and implementing class for service
	public interface IEmailService
	{
		public void SendEmail(string msg);
	}
	public class EmailService : IEmailService
	{
		public void SendEmail(string msg) 
		{
			Console.WriteLine(msg);
		}
	}
}

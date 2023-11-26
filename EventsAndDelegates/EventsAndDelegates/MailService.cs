
namespace EventsAndDelegates
{
    class MailService
    {
        public void OnVideoEncodingStart(object source, EventArgs e)
        {
            Console.WriteLine("Sending Email: Your video processing started");
        }

        public void OnVideoEncodingComplete(object source, EventArgs e)
        {
            Console.WriteLine("Sending Email: Your video processing completed");
        }
    }
}

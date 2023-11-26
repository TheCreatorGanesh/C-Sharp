using EventsAndDelegates.Model;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { title = "Video 1" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();

            videoEncoder.videoEncodeStarted += mailService.OnVideoEncodingStart;
            videoEncoder.videoEncodeCompleted += mailService.OnVideoEncodingComplete;
            videoEncoder.Encode(video);
        }
    }
}

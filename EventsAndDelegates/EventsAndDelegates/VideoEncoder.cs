
using EventsAndDelegates.Model;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source,EventArgs args);

        public event EventHandler? videoEncodeStarted;
        public event EventHandler? videoEncodeCompleted;

        public void Encode(Video video)
        {
            Console.WriteLine("Video encoding started");
            OnVideoEncodeStarted();
            Thread.Sleep(3000);
            Console.WriteLine("Video encoding finished");
            OnVideoEncodeCompleted();
        }

        protected virtual void OnVideoEncodeStarted()
        {
            if (videoEncodeStarted != null)
                videoEncodeStarted(this, EventArgs.Empty);
        }

        protected virtual void OnVideoEncodeCompleted()
        {
            if (videoEncodeCompleted != null)
                videoEncodeCompleted(this, EventArgs.Empty);
        }
    }
}

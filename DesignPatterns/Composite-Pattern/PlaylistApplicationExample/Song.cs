namespace Composite_Pattern.PlaylistApplicationExample
{
    public class Song : IComponent
    {
        public String songName;
        public String artist;
        public float speed = 1; // Default playback speed

        public Song(String songName, String artist)
        {
            this.songName = songName;
            this.artist = artist;
        }

        public void play()
        {
            Console.WriteLine($"Playing song {this.getName()}");
        }

        public void setPlayBackSpeed(float speed)
        {
            this.speed = speed;
            Console.WriteLine($"Setting song speed to {speed} for the song {this.getName()}");
        }

        public string getName()
        {
            return this.songName;
        }

        public string getArtist()
        {
            return this.artist;
        }
    }
}

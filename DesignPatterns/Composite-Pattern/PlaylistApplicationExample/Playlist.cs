namespace Composite_Pattern.PlaylistApplicationExample
{
    public class Playlist : IComponent
    {
        public string playlistName;
        public List<IComponent> playlist = new List<IComponent>();

        public Playlist(String playlistName)
        {
            this.playlistName = playlistName;
        }

        public void play()
        {
            Console.WriteLine($"Playing song in the playlist {this.getName()}");
            foreach (var song in playlist)
            {
                song.play();
            }
        }

        public void setPlayBackSpeed(float speed)
        {
            Console.WriteLine($"Setting song speed to {speed} to the playlist {this.getName()}");
            foreach (var song in playlist)
            {
                song.setPlayBackSpeed(speed);
            }
        }

        public string getName()
        {
            return this.playlistName;
        }

        public void add(IComponent component)
        {
            playlist.Add(component);
        }

        public void remove(IComponent component)
        {
            playlist.Remove(component);
        }

    }
}

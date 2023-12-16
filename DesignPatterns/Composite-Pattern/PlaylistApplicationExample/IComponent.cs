namespace Composite_Pattern.PlaylistApplicationExample
{
    public interface IComponent
    {
        public void play();
        public void setPlayBackSpeed(float speed);
        public string getName();
    }
}

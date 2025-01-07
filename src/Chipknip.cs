namespace Vender
{
    public class Chipknip
    {
        public int credits { get; set; }

        public Chipknip(int initial_value)
        {
            credits = initial_value;
        }

        public bool HasValue(int p)
        {
            return credits >= p;
        }

        public void Reduce(int p)
        {
            credits -= p;
        }
    }
}

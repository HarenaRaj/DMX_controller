namespace HLight.Models
{
    public class LedChannel : Channel
    {
        public int Value { get; set; } = 0;
        public int LedId { get; set; }
        public Led Led { get; set; }
    }
}

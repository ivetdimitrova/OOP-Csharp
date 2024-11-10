namespace StreamProgressInfo
{
    public class StreamProgressInfo
    {
        private Stream file;
        public StreamProgressInfo(Stream file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}

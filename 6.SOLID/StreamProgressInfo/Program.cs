namespace StreamProgressInfo
{
    public class Program
    {
        static void Main()
        {
            File file = new File("photo", 254, 6);
            Music music = new Music("J Balvin","I don't know", 254, 6);

            StreamProgressInfo streamInfo = new StreamProgressInfo(file);
            Console.WriteLine(streamInfo.CalculateCurrentPercent());

            streamInfo = new StreamProgressInfo(music);
            Console.WriteLine(streamInfo.CalculateCurrentPercent());
        }
    }
}

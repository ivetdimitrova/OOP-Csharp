namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            var smartPhone = new SmartPhone();
            var stationaryPhone = new StationaryPhone();

            foreach (string phoneNumber in phoneNumbers)
            {
                ICaller caller = null;
                if (phoneNumber.Any(x => !char.IsDigit(x))) Console.WriteLine("Invalid number!");
                else if (phoneNumber.Length == 10) smartPhone.Calling(phoneNumber);
                else if (phoneNumber.Length == 7) stationaryPhone.Calling(phoneNumber);
            }

            foreach (string url in urls)
            {
                if (url.Any(x => char.IsDigit(x))) Console.WriteLine("Invalid URL!");
                else smartPhone.Browsing(url);
            }
        }
    }
}

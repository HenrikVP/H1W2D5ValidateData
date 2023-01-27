using System.Diagnostics;
using System.Drawing;
using System.Media;

namespace H1W2D5ValidateData
{
    internal class Program
    {

        static void Main(string[] args)
        {
            PlaySound();
            OpenSamplePhoto();
            Console.WriteLine("Hello, World!");
            WhatsMyName();
        }

        static void WhatsMyName()
        {
            Console.WriteLine("What's my name!!!!");
            string name;
            while (true)
            {
                name = Console.ReadLine();

                if (name.Length > 20) Console.WriteLine("Too many characters. Max limit is 20.");
                else break;
            }

            int day = GetInt("date"); ;
            int month = GetInt("month"); ;
            int year = GetInt("year"); ;

            DateTime dt = new(year, month, day);//TODO Check for valid date before creating dt

            Person p = new() { Name = name, Birthday = dt };

            Console.WriteLine("Age :" + GetAge(p.Birthday));

        }

        private static void OpenSamplePhoto()
        {
            Process.Start("cmd", $"/c {Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"/jkl.jpg"}");
        }


        static void PlaySound()
        {
            SoundPlayer sfx = new SoundPlayer();
            sfx.Stream = Properties.Resources.cricket;
            sfx.Play();
        }

        public static int GetAge(DateTime bd)
        {
            int age = DateTime.Now.Year - bd.Year;
            if (DateTime.Now.AddYears(-age) < bd) age--;
            return age;
        }


        private static int GetInt(string s)
        {
            int i;
            do { Console.WriteLine("Input a " +s); }
            while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }
    }
}
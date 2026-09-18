using System.Globalization;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DisplaySessions(sessionNames, sessionDates, sessionDurations);
         

            string searchName;

            Console.WriteLine("Enter Session Name");
            searchName = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(searchName))
            {
               SearchBySessionName(sessionNames, sessionDates, sessionDurations, searchName);


                Console.WriteLine("Enter Session Name");
                searchName = Console.ReadLine();
            }



        }

        static string[] sessionNames =
                                 {
                                "C# Basics",
                                "Arrays",
                                "Functions",
                                "Date and Time",
                                "Exception Handling"
                                };
        static DateTime[] sessionDates =
                                 {
                                        new DateTime(2026, 9, 10, 18, 0, 0),
                                        new DateTime(2026, 9, 13, 18, 0, 0),
                                        new DateTime(2026, 9, 17, 18, 0, 0),
                                        new DateTime(2026, 9, 20, 18, 0, 0),
                                        new DateTime(2026, 9, 24, 18, 0, 0)
                                    };
        static int[] sessionDurations =
             {

                                    180,
                                    240,
                                    180,
                                    240,
                                    180
                };

        public static void DisplaySessions(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
        {
            for (int i = 0; i < sessionNames.Length; i++)
            {
                Console.WriteLine($"Session: {sessionNames[i]}");
                //  Console.WriteLine($"Date: {sessionDates[i].ToString("dd/MMMM/yyyy ")}");
                Console.WriteLine($"Date: {sessionDates[i].ToString("dd/MMMM/yyyy", new CultureInfo("en-US"))}");
                Console.WriteLine($"Start Time: {sessionDates[i].ToString("hh:mm tt", new CultureInfo("en-US"))}");
                Console.WriteLine($"Duration: {sessionDurations[i]} minutes");
            }



        }

        public static void SearchBySessionName(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations, string searchName)
        {
            if (!Array.Exists(sessionNames, element => element.Equals(searchName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Session not found.");
                return ;
            }

         int index= Array.FindIndex(sessionNames, element => element.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"session Name :{sessionNames[index]}");          
            Console.WriteLine($"Date:{sessionDates[index].ToString("dd/MMMM/yyyy",new CultureInfo("en-US"))}");
            Console.WriteLine($"Start Time: {sessionDates[index].ToString("hh:mm tt", new CultureInfo("en-US"))}");
            Console.WriteLine($"Duration: {sessionDurations[index]} minutes");



        }

        
    }
}

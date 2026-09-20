using System.Globalization;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DisplaySessions(sessionNames, sessionDates, sessionDurations);


            //string searchName;

            //Console.WriteLine("Enter Session Name");
            //searchName = Console.ReadLine();

            //while (!string.IsNullOrWhiteSpace(searchName))
            //{
            //   SearchBySessionName(sessionNames, sessionDates, sessionDurations, searchName);


            //    Console.WriteLine("Enter Session Name");
            //    searchName = Console.ReadLine();
            //}

            //SortSessionNames(sessionNames);
            // ReverseSessionNames(sessionNames);
            // FindSessionIndex(sessionNames);
            //IsSessionNameExsist(sessionNames);

            //Console.WriteLine("Enter Session Name");
            //string ? searchCondition = Console.ReadLine();
            //FindSessionName(sessionNames, searchCondition);

            // CopyArray(sessionNames);
            //int totalDuration = GetTotalDuration(sessionDurations);
            //Console.WriteLine($"Total Duration: {totalDuration} minutes");

            //GetAverageDuration(sessionDurations);
            //GetLongestDuration(sessionDurations);
            //GetShortestDuration(sessionDurations);
            //CopySessionDurations(sessionDurations);

            //int number = 10;
            //Console.WriteLine($"Before PassByReference: {number}");
            //PassByReference(ref number);
            //Console.WriteLine($"After PassByReference: {number}");

            //Console.WriteLine("Enter Session Name");
            //string searchName = Console.ReadLine();
            //OutDemo(sessionNames,  sessionDurations,  searchName,out SessionIndex,out SessionDuration);

            //int[] arrayX = new int[6] { 8, 9, 6, 4, 4, 6 };
            //Console.WriteLine("Before ArryDemo:");
            //foreach (var item in arrayX)
            //{
            //    Console.WriteLine(item);
            //}
            //ArryDemo(arrayX);
            //Console.WriteLine("After ArryDemo:");
            //foreach (var item in arrayX)
            //{
            //    Console.WriteLine(item);
            //}

            CalculateTotalDuration(120, 180);
            CalculateTotalDuration(120, 180, 240);
            CalculateTotalDuration(60, 90, 120, 180, 240);

            SessionDateDetails(sessionNames, sessionDurations, sessionDates);

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
        #region sessionDetails
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
                return;
            }

            int index = Array.FindIndex(sessionNames, element => element.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"session Name :{sessionNames[index]}");
            Console.WriteLine($"Date:{sessionDates[index].ToString("dd/MMMM/yyyy", new CultureInfo("en-US"))}");
            Console.WriteLine($"Start Time: {sessionDates[index].ToString("hh:mm tt", new CultureInfo("en-US"))}");
            Console.WriteLine($"Duration: {sessionDurations[index]} minutes");



        }

        public static void SortSessionNames(string[] sessionNames)
        {
            string[] copySessionName = new string[sessionNames.Length];
            Array.Copy(sessionNames, copySessionName, sessionNames.Length);
            Array.Sort(copySessionName);
            for (int i = 0; i < copySessionName.Length; i++)
            {
                Console.WriteLine(copySessionName[i]);
            }
        }

        public static void ReverseSessionNames(string[] sessionNames)
        {
            string[] copySessionName = new string[sessionNames.Length];
            Array.Copy(sessionNames, copySessionName, sessionNames.Length);
            Array.Reverse(copySessionName);
            for (int i = 0; i < copySessionName.Length; i++)
            {
                Console.WriteLine(copySessionName[i]);
            }
        }

        public static void FindSessionIndex(string[] sessionNames)
        {
            Console.WriteLine("Enter Session Name");
            string searchName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(searchName))
            {
                Console.WriteLine("Session name cannot be empty.");
                return;
            }
            int index = Array.FindIndex(sessionNames, x => x.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (index == -1)
            {
                Console.WriteLine("Session not found.");
            }
            else
            {
                Console.WriteLine($"Session :{searchName}");
                Console.WriteLine($"index: {index}");
            }


        }

        public static void IsSessionNameExsist(string[] sessionNames)
        {
            Console.WriteLine("Enter Session Name");
            string searchName = Console.ReadLine();
            if (!Array.Exists(sessionNames, x => x.Equals(searchName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Session does not exist.");
                return;
            }

            Console.WriteLine($"Session exists.");




        }

        public static void FindSessionName(string[] sessionNames, string searchCondition)
        {
            string result = Array.Find(sessionNames, x => x.Equals(searchCondition, StringComparison.OrdinalIgnoreCase));
            if (string.IsNullOrWhiteSpace(result))
            {
                Console.WriteLine("Session not found.");
                return;
            }

            Console.WriteLine($"Session found: {result}");
            return;

        }

        public static void FindSessionIndexByCondition(string[] sessionNames, string searchCondition)
        {
            int index = Array.FindIndex(sessionNames, x => x.Equals(searchCondition, StringComparison.OrdinalIgnoreCase));
            if (index == -1)
            {
                Console.WriteLine("Session not found.");
                return;
            }

            Console.WriteLine($"Session found at index: {index}");
        }


        public static void CopyArray(string[] sourceArray)
        {
            string[] destinationArray = new string[sourceArray.Length];
            Array.Copy(sourceArray, destinationArray, sourceArray.Length);

            destinationArray[0] = "New Session Name";
            Console.WriteLine("copied array:");
            foreach (var session in destinationArray)
            {

                Console.WriteLine(session);
            }

            Console.WriteLine(" source array:");
            foreach (var session in sourceArray)
            {

                Console.WriteLine(session);
            }

        }

        #endregion

        #region Part5

        public static int GetTotalDuration(int[] sessionDurations)
        {
            int totalDuration = 0;
            foreach (int duration in sessionDurations)
            {
                totalDuration += duration;
            }

            return totalDuration;
        }

        public static void GetAverageDuration(int[] sessionsDurations)
        {
            int totalDuration = GetTotalDuration(sessionsDurations);
            int averageDuration = totalDuration / sessionsDurations.Length;
            Console.WriteLine($"Average Duration: {averageDuration} minutes");
        }

        public static void GetShortestDuration(int[] sessionsDurations)
        {
            int shortestDuration = sessionsDurations[0];
            foreach (int duration in sessionsDurations)
            {
                if (duration < shortestDuration)
                {
                    shortestDuration = duration;


                }
            }
            Console.WriteLine($"Shortest Duration: {shortestDuration} minutes");
        }

        public static void GetLongestDuration(int[] sessionDuration)
        {
            int longestDuration = sessionDuration[0];
            foreach (var duration in sessionDuration)
            {
                if (duration > longestDuration)
                {
                    longestDuration = duration;
                }
            }
            Console.WriteLine($"Longest Duration: {longestDuration} minutes");
        }

        public static void CopySessionDurations(int[] sourceArray)
        {
            int[] copyArray = new int[sourceArray.Length];
            Array.Copy(sourceArray, copyArray, sourceArray.Length);
            copyArray.Sort();
            foreach (var duration in copyArray)
            {
                Console.WriteLine(duration);
            }

        }

        public static void PassByReference(ref int number)
        {
            number = 999;
        }

        static int SessionIndex;
        static int SessionDuration;

        public static void OutDemo(string[] sessionNames, int[] sessionDuration, string searchName, out int index, out int duration)
        {
            index = Array.IndexOf(sessionNames, searchName);
            if (index == -1)
            {
                duration = -1;
                index = -1;
                Console.WriteLine("Session not found.");
            }
            else
            {
                duration = sessionDuration[index];

                Console.WriteLine($"Session: {index}");
                Console.WriteLine($"Duration: {duration} minutes");
            }



        }



        public static void ArryDemo(int[] arrayY)
        {
            arrayY[3] = 999;


        }




        #endregion


        public static void CalculateTotalDuration(params int[] durations)
        {
            int totalDeuration = 0;
            foreach(var duration in durations)
            {
                totalDeuration += duration;
            }
            Console.WriteLine($"Total Duration: {totalDeuration} minutes");

        }

        public static void SessionDateDetails(string[] sessionNames, int[] sessionDurations, DateTime[] sessionDate)
        {
            Console.WriteLine("Enter Session Name");
            string searchName = Console.ReadLine();
            //if(!Array.Exists(sessionNames, x => x.Equals(searchName, StringComparison.OrdinalIgnoreCase)))
            //{
            //    Console.WriteLine("Session not found.");
            //    return;
            //}
           int index=Array.FindIndex(sessionNames,x=>x.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (index == -1)
            {
                Console.WriteLine("Session not found.");
                return;
            }

            Console.WriteLine($"Session: {sessionNames[index]}");
            Console.WriteLine($"Date: {sessionDate[index].ToString("dd/MMMM/yyyy", System.Globalization.CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Date: {sessionDate[index].Day}");
            Console.WriteLine($"Date: {sessionDate[index].Month}");
            Console.WriteLine($"Date: {sessionDate[index].Year}");
            Console.WriteLine($"Start Time: {sessionDate[index].ToString("hh:mm tt", new CultureInfo("en-US"))}");
            Console.WriteLine($"Duration: {sessionDurations[index]} minutes");
            DateTime endTime = sessionDate[index].AddMinutes(sessionDurations[index]);
            Console.WriteLine($"End Time: {endTime.ToString("hh:mm tt", new CultureInfo("en-US"))}");

        }
    }
}


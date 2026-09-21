using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
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

            //CalculateTotalDuration(120, 180);
            //CalculateTotalDuration(120, 180, 240);
            //CalculateTotalDuration(60, 90, 120, 180, 240);

            //SessionDateDetails(sessionNames, sessionDurations, sessionDates);

            //DateDifference();
            //  PastAndUpcomingSessions();
            //FindNextSession();
            //DisplayselectedSession();
            //var Date =ReadAndValidateDate();
            //Console.WriteLine(Date.ToString(new CultureInfo("en-US")));

            //MenuInput();
            // InvalidArrayIndex(sessionNames);

            //ValidateSessionDuration();
            //  BuildScheduleReport();
            ReportUsingStringBuilder();
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

        #endregion

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

        //part 10
        public static void DateDifference()
        {
            Console.WriteLine("Enter the First Session Name");
            string firstSessionName = Console.ReadLine();
            while (!Array.Exists(sessionNames,x=>x.Equals(firstSessionName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Enter Valid Session Name.");
                Console.WriteLine("Enter the First Session Name");

                firstSessionName = Console.ReadLine();
            }
            Console.WriteLine("Enter the Second Session Name");
            string secondSessionName = Console.ReadLine();
            while (!Array.Exists(sessionNames, x => x.Equals(secondSessionName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Enter Valid Session Name.");
                Console.WriteLine("Enter the Second Session Name");
                secondSessionName = Console.ReadLine();
            }

          int firstSessionIndex = Array.FindIndex(sessionNames, x => x.Equals(firstSessionName, StringComparison.OrdinalIgnoreCase));
          int secondSessionIndex = Array.FindIndex(sessionNames, x => x.Equals(secondSessionName, StringComparison.OrdinalIgnoreCase));

            TimeSpan dateDifference = sessionDates[firstSessionIndex] - sessionDates[secondSessionIndex];
            Console.WriteLine($"Difference:\n{dateDifference.Days}days \n{dateDifference.Hours}Hours ");

        }
        //part11
        public static void PastAndUpcomingSessions() 
        {
            for (int i=0;i<sessionDates.Length;i++)
            {
                if (DateTime.Now < sessionDates[i])
                {
                    Console.WriteLine($"{sessionNames[i]} upcoming");

                }
                else
                {
                    Console.WriteLine($"{sessionNames[i]} Past");

                }

            }
        }

        //part 12
        public static void FindNextSession()
        {
            DateTime Now = DateTime.Now;
            int index = -1;
            var minDifference = TimeSpan.MaxValue;
            for (int i = 0; i < sessionDates.Length; i++)
            {
                
                if (Now > sessionDates[i])
                {
                    continue;

                }
                var diference = sessionDates[i] - Now;
                
                

                if (diference < minDifference)
                {
                    minDifference = diference;
                    index = i;

                }

                




            }
            Console.WriteLine($"next session: {sessionNames[index]}");
            Console.WriteLine($"{sessionDates[index].ToString("dd/MMMM/yyyy", new CultureInfo("en-US"))} ");
            Console.WriteLine($"{sessionDates[index].ToString("hh:mm tt", new CultureInfo("en-US"))}");


            Console.WriteLine($"Time Remaining : \n {(sessionDates[index] - Now).Days}days");
            Console.WriteLine($" {(sessionDates[index] - Now).Hours}hours");




        }


        //part 13 
        public static void DisplayselectedSession()
        {
          Console.WriteLine( sessionDates[0].ToString("yyyy-MM-dd"));
          Console.WriteLine( sessionDates[0].ToString("dd/MM/yyyy"));
          Console.WriteLine( sessionDates[0].ToString("dd/MMMM/yyyy",new CultureInfo("en-US")));
          Console.WriteLine( sessionDates[0].ToString("dddd,dd/MMMM/yyyy",new CultureInfo("en-US")));
          Console.WriteLine( sessionDates[0].ToString("hh:mm tt",new CultureInfo("en-US")));
            
        }

        //part 14

        public static DateTime ReadAndValidateDate()
        {
            DateTime result;
            bool success;

            do
            {
                Console.WriteLine("Enter the Date yyyy-MM-dd HH:mm");

                success = DateTime.TryParseExact(
                    Console.ReadLine(),
                    "yyyy-MM-dd HH:mm",
                    new CultureInfo("en-US"),
                    DateTimeStyles.None,
                    out result
                );

                if (!success)
                {
                    Console.WriteLine("Wrong format");
                }

            } while (!success);
            
           return  result;

        }

        //part 15

        public static void MenuInput()
        {
            Console.WriteLine("Enter Number");
            int? result;
            while (true)
            {
                try
                {
                    result = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Valid Number {result}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }


            }
        }

        //part 16
        public static void InvalidArrayIndex(string[] sessionNames)
        {
            Console.WriteLine("Enter the Index");
            bool success = int.TryParse(Console.ReadLine(), out int index);
            if (!success)
            { Console.WriteLine("Enter Valid Index");
                return; 
            }

                try
                {
                Console.WriteLine(sessionNames[index]);




                }
                catch (IndexOutOfRangeException ex)
                {
                Console.WriteLine(ex.Message);
                 }
            
        }

        public static void ValidateSessionDuration()
        {
            Console.WriteLine("Enter duration ");
            try
            {


                int duration = int.Parse(Console.ReadLine());

                if (duration <= 0)
                {
                    throw new ArgumentException();

                }
                else
                Console.WriteLine("Duration accepted");



            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Input operation finished.");
            }

            


        }


        public static void BuildScheduleReport()
        {
            string result = "";
            for (int i = 0; i < sessionNames.Length;i++)
            {
                result += sessionNames[i] + " - " + sessionDates[i].ToString("dd/MM/yyyy hh:mm tt", new CultureInfo("en-US"))
                    + " - " + sessionDurations[i] + " minutes \n";

            }
            Console.WriteLine(result);
            
        }


        public static void ReportUsingStringBuilder()
        {
            StringBuilder result = new StringBuilder("");
            for (int i = 0; i < sessionNames.Length; i++)
            {
                result.Append(sessionNames[i]) ;
                result.Append(" - ") ;
                result.Append(sessionDates[i].ToString("dd/MM/yyyy hh:mm tt", new CultureInfo("en-US")));
                result.Append(" - ");
                result.Append(sessionDurations[i]);
                result.Append( " minutes \n");

            }
            Console.WriteLine(result);

        }


    }
}


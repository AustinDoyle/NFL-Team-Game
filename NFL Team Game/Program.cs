using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL_Teams_Game_
{
    class Program
    {
        public static class afcEast
        {
            public static string[] afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] afcPrint = new string[] { "Buffalo Bills", "Miami Dolphins", "New England Patriots", "New York Jets" };
            public static string[] afcPartCheck = new string[] { "BILLS", "DOLPHINS", "PATRIOTS", "JETS" };
        }

        public static class afcNorth
        {
            public static string[] afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] afcPrint = new string[] { "Cleveland Browns", "Baltimore Ravens", "Cincinnati Bengals", "Pittsburgh Steelers" };
            public static string[] afcPartCheck = new string[] { "BROWNS", "RAVENS", "BENGALS", "STEELERS" };
        }

        public static class afcSouth
        {
            public static string[] afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] afcPrint = new string[] { "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Tennessee Titans" };
            public static string[] afcPartCheck = new string[] { "TEXANS", "COLTS", "JAGUARS", "TITANS" };
        }

        public static class afcWest
        {
            public static string[] afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] afcPrint = new string[] { "Denver Broncos", "Kansas City Chiefs", "Los Angeles Chargers", "Oakland Raiders" };
            public static string[] afcPartCheck = new string[] { "BRONCOS", "CHIEFS", "CHARGERS", "RAIDERS" };
        }

        public static class nfcEast
        {
            public static string[] nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] nfcPrint = new string[] { "Dallas Cowboys", "New York Giants", "Philadelphia Eagles", "Washington Redskins" };
            public static string[] nfcPartCheck = new string[] { "COWBOYS", "GIANTS", "EAGLES", "REDSKINS" };
        }

        public static class nfcNorth
        {
            public static string[] nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] nfcPrint = new string[] { "Chicago Bears", "Detroit Lions", "Green Bay Packers", "Minnesota Vikings" };
            public static string[] nfcPartCheck = new string[] { "BEARS", "LIONS", "PACKERS", "VIKINGS" };
        }

        public static class nfcSouth
        {
            public static string[] nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] nfcPrint = new string[] { "Atlanta Falcons", "Carolina Panthers", "New Orleans Saints", "Tampa Bay Buccaneers" };
            public static string[] nfcPartCheck = new string[] { "FALCONS", "PANTHERS", "SAINTS", "BUCCANEERS" };
        }

        public static class nfcWest
        {
            public static string[] nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] nfcPrint = new string[] { "Arizona Cardinals", "Los Angeles Rams", "San Francisco 49ers", "Seattle Seahawks" };
            public static string[] nfcPartCheck = new string[] { "CARDINALS", "RAMS", "49ERS", "SEAHAWKS" };
        }

        public static class Counter
        {
            private static int incorrect;
            public static int Incorrect
            {
                get
                {
                    return incorrect;
                }
                set
                {
                    incorrect = value;
                }
            }
        }
        static void renderGame()
        {
            Console.WriteLine("");
            Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", "AFC East", "AFC North", "AFC South", "AFC West");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", afcEast.afc[i], afcNorth.afc[i], afcSouth.afc[i], afcWest.afc[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", "NFC East", "NFC North", "NFC South", "NFC West");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", nfcEast.nfc[i], nfcNorth.nfc[i], nfcSouth.nfc[i], nfcWest.nfc[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Attempts: " + Counter.Incorrect);
            Console.WriteLine("");
            Console.WriteLine("Insert a team (Example: 'Cleveland Browns' or 'Browns'): ");

            string teamInput = Console.ReadLine().ToUpper().Trim();

            if (teamInput == "QUIT")
            {
                afcEast.afc = afcEast.afcPrint;
                afcNorth.afc = afcNorth.afcPrint;
                afcSouth.afc = afcSouth.afcPrint;
                afcWest.afc = afcWest.afcPrint;
                nfcEast.nfc = nfcEast.nfcPrint;
                nfcNorth.nfc = nfcNorth.nfcPrint;
                nfcSouth.nfc = nfcSouth.nfcPrint;
                nfcWest.nfc = nfcWest.nfcPrint;
                Console.Clear();
            }
            else
            {

                try
                {
                    handleInput(teamInput);
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect value");
                    Console.WriteLine();
                }
                finally
                {
                    Counter.Incorrect = Counter.Incorrect + 1;
                }
            }
        }

        static void staticGame()
        {
            Console.WriteLine("");
            Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", "AFC East", "AFC North", "AFC South", "AFC West");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", afcEast.afc[i], afcNorth.afc[i], afcSouth.afc[i], afcWest.afc[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", "NFC East", "NFC North", "NFC South", "NFC West");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", nfcEast.nfc[i], nfcNorth.nfc[i], nfcSouth.nfc[i], nfcWest.nfc[i]);
            }
        }

        static void handleInput(string team)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (team == afcEast.afcPrint[i].ToUpper() || team == afcEast.afcPartCheck[i])
                {
                    afcEast.afc[i] = afcEast.afcPrint[i];
                    break;
                }
                else if (team == afcNorth.afcPrint[i].ToUpper() || team == afcNorth.afcPartCheck[i])
                {
                    afcNorth.afc[i] = afcNorth.afcPrint[i];
                    break;
                }
                else if (team == afcSouth.afcPrint[i].ToUpper() || team == afcSouth.afcPartCheck[i])
                {
                    afcSouth.afc[i] = afcSouth.afcPrint[i];
                    break;
                }
                else if (team == afcWest.afcPrint[i].ToUpper() || team == afcWest.afcPartCheck[i])
                {
                    afcWest.afc[i] = afcWest.afcPrint[i];
                    break;
                }
                else if (team == nfcEast.nfcPrint[i].ToUpper() || team == nfcEast.nfcPartCheck[i])
                {
                    nfcEast.nfc[i] = nfcEast.nfcPrint[i];
                    break;
                }
                else if (team == nfcNorth.nfcPrint[i].ToUpper() || team == nfcNorth.nfcPartCheck[i])
                {
                    nfcNorth.nfc[i] = nfcNorth.nfcPrint[i];
                    break;
                }
                else if (team == nfcSouth.nfcPrint[i].ToUpper() || team == nfcSouth.nfcPartCheck[i])
                {
                    nfcSouth.nfc[i] = nfcSouth.nfcPrint[i];
                    break;
                }
                else if (team == nfcWest.nfcPrint[i].ToUpper() || team == nfcWest.nfcPartCheck[i])
                {
                    nfcWest.nfc[i] = nfcWest.nfcPrint[i];
                    break;
                }
                else
                {
                    continue;
                }

            }
            Console.Clear();
        }

        static void reset()
        {
            Console.Clear();
            afcEast.afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            afcNorth.afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            afcWest.afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            afcSouth.afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            nfcEast.nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            nfcNorth.nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            nfcWest.nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            nfcSouth.nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            Counter.Incorrect = 0;
        }

        static bool compare()
        {
            bool afcEastCompare = Enumerable.SequenceEqual(afcEast.afc, afcEast.afcPrint);
            bool afcNorthCompare = Enumerable.SequenceEqual(afcNorth.afc, afcNorth.afcPrint);
            bool afcSouthCompare = Enumerable.SequenceEqual(afcSouth.afc, afcSouth.afcPrint);
            bool afcWestCompare = Enumerable.SequenceEqual(afcWest.afc, afcWest.afcPrint);
            bool nfcEastCompare = Enumerable.SequenceEqual(nfcEast.nfc, nfcEast.nfcPrint);
            bool nfcNorthCompare = Enumerable.SequenceEqual(nfcNorth.nfc, nfcNorth.nfcPrint);
            bool nfcSouthCompare = Enumerable.SequenceEqual(nfcSouth.nfc, nfcSouth.nfcPrint);
            bool nfcWestCompare = Enumerable.SequenceEqual(nfcWest.nfc, nfcWest.nfcPrint);

            if (afcEastCompare == true && afcNorthCompare == true && afcSouthCompare == true && afcWestCompare == true && nfcEastCompare == true && nfcNorthCompare == true && nfcSouthCompare == true && nfcWestCompare == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool startGame = false;
            bool firstQuestion = true;

            while (firstQuestion)
            {
                Console.WriteLine("");
                Console.WriteLine("NFL Team Challenge!");
                Console.WriteLine("");
                Console.WriteLine("Can you guess all of the NFL Teams? Enter START to begin! ");
                string beginningInput = Console.ReadLine().ToUpper();

                if (beginningInput == "START")
                {
                    Console.Clear();
                    startGame = true;
                    firstQuestion = false;
                }
                else if (beginningInput == "QUIT")
                {
                    firstQuestion = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Invalid entry. Enter QUIT if you wish to exit the application.");
                }
            }

            while (startGame)
            {
                if (compare() == true)
                {
                    staticGame();

                    if (Counter.Incorrect >= 32)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Correct Answers: 32");
                        Console.WriteLine("Incorrect Attempts: " + (Convert.ToInt32(Counter.Incorrect - 32)));
                        Console.WriteLine("");
                        Console.Write("Congratulations! You're a winner!");
                    }

                    Console.WriteLine("");
                    Console.Write("Would you like to try again? (YES/NO) ");
                    string continueGame = Console.ReadLine().ToUpper();

                    if (continueGame == "YES")
                    {
                        reset();
                    }
                    else if (continueGame == "NO")
                    {
                        startGame = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Invalid response");
                    }
                }
                else
                {
                    renderGame();
                }

            }
        }
    }
}



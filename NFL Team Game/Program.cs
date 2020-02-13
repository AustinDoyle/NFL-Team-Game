using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL_Teams_Game_
{
    class Program
    {
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
                if (Compare() == true)
                {
                    StaticGame();

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
                        Reset();
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
                    RenderGame();
                }

            }
        }

        public static class AfcEast
        {
            public static string[] afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] afcPrint = new string[] { "Buffalo Bills", "Miami Dolphins", "New England Patriots", "New York Jets" };
            public static string[] afcPartCheck = new string[] { "BILLS", "DOLPHINS", "PATRIOTS", "JETS" };
        }

        public static class AfcNorth
        {
            public static string[] afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] afcPrint = new string[] { "Cleveland Browns", "Baltimore Ravens", "Cincinnati Bengals", "Pittsburgh Steelers" };
            public static string[] afcPartCheck = new string[] { "BROWNS", "RAVENS", "BENGALS", "STEELERS" };
        }

        public static class AfcSouth
        {
            public static string[] afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] afcPrint = new string[] { "Houston Texans", "Indianapolis Colts", "Jacksonville Jaguars", "Tennessee Titans" };
            public static string[] afcPartCheck = new string[] { "TEXANS", "COLTS", "JAGUARS", "TITANS" };
        }

        public static class AfcWest
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

        public static class NfcSouth
        {
            public static string[] nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            public static string[] nfcPrint = new string[] { "Atlanta Falcons", "Carolina Panthers", "New Orleans Saints", "Tampa Bay Buccaneers" };
            public static string[] nfcPartCheck = new string[] { "FALCONS", "PANTHERS", "SAINTS", "BUCCANEERS" };
        }

        public static class NfcWest
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
        static void RenderGame()
        {
            Console.WriteLine("");
            Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", "AFC East", "AFC North", "AFC South", "AFC West");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", AfcEast.afc[i], AfcNorth.afc[i], AfcSouth.afc[i], AfcWest.afc[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", "NFC East", "NFC North", "NFC South", "NFC West");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", nfcEast.nfc[i], nfcNorth.nfc[i], NfcSouth.nfc[i], NfcWest.nfc[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Attempts: " + Counter.Incorrect);
            Console.WriteLine("");
            Console.WriteLine("Insert a team (Example: 'Cleveland Browns' or 'Browns'): ");

            string teamInput = Console.ReadLine().ToUpper().Trim();

            if (teamInput == "QUIT")
            {
                AfcEast.afc = AfcEast.afcPrint;
                AfcNorth.afc = AfcNorth.afcPrint;
                AfcSouth.afc = AfcSouth.afcPrint;
                AfcWest.afc = AfcWest.afcPrint;
                nfcEast.nfc = nfcEast.nfcPrint;
                nfcNorth.nfc = nfcNorth.nfcPrint;
                NfcSouth.nfc = NfcSouth.nfcPrint;
                NfcWest.nfc = NfcWest.nfcPrint;
                Console.Clear();
            }
            else
            {

                try
                {
                    HandleInput(teamInput);
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

        static void StaticGame()
        {
            Console.WriteLine("");
            Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", "AFC East", "AFC North", "AFC South", "AFC West");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", AfcEast.afc[i], AfcNorth.afc[i], AfcSouth.afc[i], AfcWest.afc[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", "NFC East", "NFC North", "NFC South", "NFC West");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,22}{1,22}{2,22}{3,22}", nfcEast.nfc[i], nfcNorth.nfc[i], NfcSouth.nfc[i], NfcWest.nfc[i]);
            }
        }

        static void HandleInput(string team)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (team == AfcEast.afcPrint[i].ToUpper() || team == AfcEast.afcPartCheck[i])
                {
                    AfcEast.afc[i] = AfcEast.afcPrint[i];
                    break;
                }
                else if (team == AfcNorth.afcPrint[i].ToUpper() || team == AfcNorth.afcPartCheck[i])
                {
                    AfcNorth.afc[i] = AfcNorth.afcPrint[i];
                    break;
                }
                else if (team == AfcSouth.afcPrint[i].ToUpper() || team == AfcSouth.afcPartCheck[i])
                {
                    AfcSouth.afc[i] = AfcSouth.afcPrint[i];
                    break;
                }
                else if (team == AfcWest.afcPrint[i].ToUpper() || team == AfcWest.afcPartCheck[i])
                {
                    AfcWest.afc[i] = AfcWest.afcPrint[i];
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
                else if (team == NfcSouth.nfcPrint[i].ToUpper() || team == NfcSouth.nfcPartCheck[i])
                {
                    NfcSouth.nfc[i] = NfcSouth.nfcPrint[i];
                    break;
                }
                else if (team == NfcWest.nfcPrint[i].ToUpper() || team == NfcWest.nfcPartCheck[i])
                {
                    NfcWest.nfc[i] = NfcWest.nfcPrint[i];
                    break;
                }
                else
                {
                    continue;
                }

            }
            Console.Clear();
        }

        static void Reset()
        {
            Console.Clear();
            AfcEast.afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            AfcNorth.afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            AfcWest.afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            AfcSouth.afc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            nfcEast.nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            nfcNorth.nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            NfcWest.nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            NfcSouth.nfc = new string[] { "1. --------", "2. --------", "3. --------", "4. --------" };
            Counter.Incorrect = 0;
        }

        static bool Compare()
        {
            bool afcEastCompare = Enumerable.SequenceEqual(AfcEast.afc, AfcEast.afcPrint);
            bool afcNorthCompare = Enumerable.SequenceEqual(AfcNorth.afc, AfcNorth.afcPrint);
            bool afcSouthCompare = Enumerable.SequenceEqual(AfcSouth.afc, AfcSouth.afcPrint);
            bool afcWestCompare = Enumerable.SequenceEqual(AfcWest.afc, AfcWest.afcPrint);
            bool nfcEastCompare = Enumerable.SequenceEqual(nfcEast.nfc, nfcEast.nfcPrint);
            bool nfcNorthCompare = Enumerable.SequenceEqual(nfcNorth.nfc, nfcNorth.nfcPrint);
            bool nfcSouthCompare = Enumerable.SequenceEqual(NfcSouth.nfc, NfcSouth.nfcPrint);
            bool nfcWestCompare = Enumerable.SequenceEqual(NfcWest.nfc, NfcWest.nfcPrint);

            if (afcEastCompare == true && afcNorthCompare == true && afcSouthCompare == true && afcWestCompare == true && nfcEastCompare == true && nfcNorthCompare == true && nfcSouthCompare == true && nfcWestCompare == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



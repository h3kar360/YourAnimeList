using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace YourAnimeList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int intplus = 1;
            int score = 0;

            //use for query
            var inCondition = new List<Anime>();

            //the list itself
            //input your anime here
            List<Anime> animeList = new List<Anime>()
            {
                new Anime{ ID = intplus++, AnimeName = "Konosuba", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Konosuba s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Konosuba movie", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Konosuba ova", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Baka to test", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Gintama", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Nisekoi", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Nisekoi s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Nisekoi ova 1", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Nisekoi ova 2", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Nisekoi ova 3", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Akame ga kill", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Takagi-san", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Takagi-san s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Noragami", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Noragami s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Noragami ova", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Strike the blood", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Oreshura", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Plastic memories", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Snow white with red hair", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Maid-sama", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Blend s", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Dog and scissors", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Your lie in April", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Violet evergarden", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Violet evergarden special", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Violet evergarden movie", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Rent-a-girlfriend", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Kimi no nawa", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Weathering with you", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Cuticle tantei inaba", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Kiss him, not me", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Oregairu", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Oregairu s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Oregairu s3", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Oregairu ova 1", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Oregairu ova 2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "That time I got reincarnated as a slime", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "We never learn: bokuben", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "We never learn: bokuben s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "The helpful fox senko-san", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Anohana", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Angelbeats", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "My little monster", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Saiki", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Saiki s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Saiki s3", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Saiki ona", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Servant x service", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Girls beyond the wasteland", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Girls beyond the wasteland ova", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Beelzebub", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Kakegurui", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "The pet girl of sakurasou", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Ao-chan can't study", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Hensuki", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Fruit basket", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Fruit basket s2", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Fruit basket s3", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Boarding school juliet", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Suppose a kid from the last dungeon boonies moved to a starter town?", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Classroom of the elite", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Tonikaku kawaii", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Love is war", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Love is war s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Hyouka", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Re:zero", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Re:zero s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "My hero academia", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "My hero academia s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "My hero academia s3", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Assasination classroom", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Assasination classroom s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Sao", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "The ryuo's work is never done", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Handa-kun", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Monogatari series", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Shield hero", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Sankarea", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Love is like a cocktail", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "One punch man", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "One punch man s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Mob psycho 100", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Mob psycho 100 s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "How to raise a boring girlfriend", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "How to raise a boring girlfriend s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "How to raise a boring girlfriend movie", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Rascal does not dream of bunny girl senpai", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Rascal does not dream of bunny girl senpai movie", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Tsuki ga kirei", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Tsuki ga kirei ova", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Kono oto tomare", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Maquia", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Kimetsu no yaiba", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Kiznaiver", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Tanaka-kun", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Oresuki", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Horimiya", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "The devil's part timer", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Yamada and the seven witches", Watched = false},                
                new Anime{ ID = intplus++, AnimeName = "Dragon maid", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Dragon maid ova 1", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Dragon maid ova 2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Dragon maid ova 3", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Gamers!", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "No game no life", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "No game no life movie", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Oka san online", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Toradora", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Konobi", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Photokano", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Masamune-kun's no revenge", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Masamune-kun's no revenge ova", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Rikei ga koi", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "The tale of the princess kaguya", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Moriarty the patriot", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Higehiro", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "The way of the house husband", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Amaburi", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Osamuke", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "86", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Welcome to demon school iruma-kun", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Welcome to demon school iruma-kun s2", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Bakugan", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Love is like after the rain", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Black bullet", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Mushouko tensei", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Jujutsu kaisen", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Charlotte", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "It's too sick to call love", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Arifureta", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Love lab", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Joran the princess of snow and blood", Watched = false}, 
                new Anime{ ID = intplus++, AnimeName = "A couple of cuckoos", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Mikakunin de shinkoukei", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "The millionaire detective", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Daitoshokan no hitsujika", Watched = false},
                new Anime{ ID = intplus++, AnimeName = "Relife", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "The detective is already dead", Watched = true},
                new Anime{ ID = intplus++, AnimeName = "Seirei Genshouki", Watched = true},
            };            
            Console.Title = "Your Anime List";

            do
            {
                WelcomeToYAL(score);


                input = Console.ReadLine();
                Console.Clear();
                if (input.ToLower() == "l")
                {
                    DisplayingList(animeList, inCondition, input, intplus);
                    Console.Clear();
                }
                else if (input.ToLower() == "s")
                {
                    string search = "";
                    Searchfunc(inCondition, animeList, search, input);
                    Console.Clear();
                }
                else if (input.ToLower() == "r")
                {
                    RollAnime(animeList, inCondition, input, ref score);
                    
                }
                else if (input.ToLower() == "x")
                {
                    //so it wont do the error message
                }
                else
                {
                    ErrorMsg("Invalid input, use 'l', 's', 'r' or 'x'.");
                    Console.Clear();
                }
               

            }while(!(input.ToLower() == "x"));
        }

        /// <summary>
        /// pick out an anime in random
        /// </summary>
        /// <param name="intplus"></param>
        /// <param name="anime"></param>
        /// <param name="ul"></param>
        /// <param name="score"></param>
        public static void RollAnime(List<Anime> anime, List<Anime> ul, string input, ref int score)
        {
            do
            {
                int dice = anime.Count();
                              

                Random randAnime = new Random();
                int random = randAnime.Next(1, dice);

                ul = anime.Where(x => x.ID == random).ToList();
                Anime.DisplayTable(ul, "Your Rolled Anime");

                score++;

                Console.WriteLine("\n(a)again\n(b)back");
                input = Console.ReadLine();

                if (input.ToLower() == "b")
                {
                    Console.Clear();
                }
                else if (input.ToLower() == "a")
                {
                    Console.Clear();
                }
                else
                {
                    ErrorMsg("Invalid input, use 'a' or 'b'.");
                }
                               

            } while (input.ToLower() != "b");
        }

        /// <summary>
        /// for error message
        /// </summary>
        /// <param name="e"></param>
        public static void ErrorMsg(string e)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e + "\npress any key to continue");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// the openning
        /// </summary>
        /// <param name="score"></param>
        public static void WelcomeToYAL(int score)
        {
            Console.WriteLine("Welcome to Your Anime List");
            Console.WriteLine("--------------------------");
            Console.WriteLine("(l)look at you anime list\n(s)search anime\n(r)roll anime\n(x)exit");
            Console.WriteLine("\n\nYour score today: " + score);
        }

        /// <summary>
        /// to display the list
        /// </summary>
        /// <param name="anime"></param>
        /// <param name="choose"></param>
        public static void DisplayingList(List<Anime> anime, List<Anime> ul, string choose, int plusint)
        {
            int count = 0;
            int watched = 0;
            int unwatched = 0;
            do
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Anime.DisplayTable(anime, "Your Anime List Table");
                sw.Stop();
                            

                count = anime.Count();
                watched = anime.Count(x => x.Watched == true);
                unwatched = anime.Count(c => c.Watched == false);

                Console.WriteLine("\n--------------------");
                Console.WriteLine("Total anime: " + count);
                Console.WriteLine("Watched anime: " + watched);
                Console.WriteLine("Unwatched anime: " + unwatched);

                Console.WriteLine("\nElapsed time: {0}", sw.Elapsed.TotalSeconds + " seconds.");


                Console.WriteLine("\n\n(a)add item\n(d)delete item\n(u)update item\n(b)back");
                choose = Console.ReadLine();

                #region back
                if (choose.ToLower() == "b")
                {
                    Console.Clear();
                }
                #endregion

                #region add item
                else if (choose.ToLower() == "a")
                {                    
                    try
                    {                       
                        
                        Console.Clear();
                        Console.WriteLine("Add your anime:");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Watched?: ");
                        bool watch = bool.Parse(Console.ReadLine());

                        anime.Add(new Anime { ID = plusint++, AnimeName = name, Watched = watch });
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    catch (Exception e)
                    {
                        ErrorMsg(e.Message);
                    }
                                        
                }
                #endregion

                #region update item
                else if (choose.ToLower() == "u")
                {
                    try
                    {
                        Console.Clear();
                        Anime.DisplayTableWithID(anime);
                        Console.Write("\nPick your anime row: ");
                        int pick = int.Parse(Console.ReadLine());

                        Console.Clear();
                        ul = anime.Where(x => x.ID == pick).ToList();
                        Anime.DisplayTableWithID(ul);

                        Console.WriteLine("Which part would you like to update?");
                        string part = Console.ReadLine();

                        if(part.ToLower() == "name")
                        {
                            Console.Clear();
                            Console.WriteLine("What would you like you anime name to change to?");
                            part = Console.ReadLine();
                            ul = ul.Select(x => { x.AnimeName = part; return x; }).ToList();

                            Console.WriteLine("\nName updated.\nPress any key to go back.");
                            Console.ReadKey();
                        }
                        else if(part.ToLower() == "watched" || part.ToLower() == "watch")
                        {
                            Console.Clear();
                            Console.WriteLine("What would you like your watch status to change to?");
                            bool watch = bool.Parse(Console.ReadLine());
                            ul = ul.Select(x => { x.Watched = watch; return x; }).ToList();

                            Console.WriteLine("\nWatch status updated.\nPress any key to continue.");
                            Console.ReadKey();
                        }
                        else
                        {
                            ErrorMsg("Only 2 parts exist: name, watched or watch.");
                        }

                    }
                    catch(Exception e)
                    {
                        ErrorMsg(e.Message);
                    }
                }
                #endregion

                #region delete item
                else if (choose.ToLower() == "d")
                {
                    try
                    {
                        Console.Clear();
                        Anime.DisplayTableWithID(anime);
                        Console.Write("\nPick the anime row you want to delete: ");
                        int row = Convert.ToInt32(Console.ReadLine());
                        anime.RemoveAll(x => x.ID == row);
                        #region secret no reveal
                        #region I said no!
                        #region nope
                        #region nice try, but no
                        #region goodbye
                        if (row == 3313)
                        {
                            anime.Clear();
                            Console.WriteLine("All row is deleted.\nPress any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"Row {row} is deleted.\nPress any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        #endregion
                        #endregion
                        #endregion
                        #endregion
                        #endregion
                    }
                    catch (Exception e)
                    {
                        ErrorMsg(e.Message);
                    }
                }
                #endregion

                //just an error message
                else
                {
                    ErrorMsg("Invalid input. use 'a', 'd', 'u' or 'b'.");
                }
            } while (choose.ToLower() != "b");
        }
        /// <summary>
        /// to search for items in list
        /// </summary>
        /// <param name="uc"></param>
        /// <param name="al"></param>
        /// <param name="inp"></param>
        /// <param name="input"></param>
        public static void Searchfunc(List<Anime> uc, List<Anime> al, string inp, string input)
        {
            int searchResult = 0;

            Console.Write("Search: ");
            inp = Console.ReadLine();
            Console.WriteLine();
                 
            uc = al.Where(x => x.AnimeName.Contains(inp)).ToList();            
            searchResult = uc.Count();

            //showing search result
            Anime.DisplayTable(uc, "Search Result");
            Console.WriteLine($"\n---------------\n{searchResult} search result");

            Console.WriteLine("\n(b)back");
            input = Console.ReadLine();

            if(input.ToLower() == "b")
            {
                Console.Clear();
            }
            else
            {
                ErrorMsg("Invalid input, use 'b'.");
            }
        }
    }

    /// <summary>
    /// to input item
    /// </summary>
    class Anime
    {
        public int ID { get; set; }
        public string AnimeName { get; set; }
        public bool Watched { get; set; }

        /// <summary>
        /// to display item
        /// </summary>
        /// <param name="anime"></param>
        /// <param name="title"></param>
        public static void DisplayTable(List<Anime> anime, string title)
        {
            
            Console.WriteLine($"{title}:\n");
            Console.WriteLine("Anime Name  | Watched\n========================================================");
            
            foreach (var item in anime)
            {
                Console.WriteLine($"{item.AnimeName} | {item.Watched}");

            }
            
        }

        public static void DisplayTableWithID(List<Anime> anime)
        {
            Console.WriteLine("Pick your anime row:\n");
            Console.WriteLine("ID | Anime Name  | Watched\n========================================================");
            foreach (var item in anime)
            {
                Console.WriteLine($"{item.ID} | {item.AnimeName} | {item.Watched}");
            }
        }
    }
}

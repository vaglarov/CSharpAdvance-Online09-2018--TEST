namespace _107._The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class VLogger
    {
        static void Main(string[] args)
        {
            var dictVlogers = new Dictionary<string, Vloger>();
            var input = string.Empty;
            //Read Input
            while ((input = Console.ReadLine()) != "Statistics")
            {
                var splitInput = input.Split();
                var nameVloger = string.Empty;
                switch (splitInput[1])
                {
                    case "joined":
                        nameVloger = splitInput[0];
                        if (!dictVlogers.ContainsKey(nameVloger))
                        {
                            var newVloger = new Vloger(nameVloger);
                            dictVlogers.Add(nameVloger, newVloger);
                        }
                        break;
                    case "followed":
                        var nameReglarPersonFirst = splitInput[0];
                        var nameVlogerFoSecond = splitInput[2];
                        
                        if (nameReglarPersonFirst== nameVlogerFoSecond)
                        {
                            break;
                        }
                        if (dictVlogers.ContainsKey(nameReglarPersonFirst))
                        {
                            var vloger = dictVlogers[nameReglarPersonFirst];
                            //dobawamq imenata 
                            if (!vloger.ContainsFollowing(nameVlogerFoSecond))
                            {
                                vloger.AddFollowingName(nameVlogerFoSecond);
                            }
                        }
                        //dobawqme na vlogera followers
                        if (dictVlogers.ContainsKey(nameVlogerFoSecond))
                        {
                            var vloger = dictVlogers[nameVlogerFoSecond];
                            if (!vloger.ContainsFollowers(nameReglarPersonFirst))
                            {
                                vloger.AddFollowersName(nameReglarPersonFirst);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Outher type of input");
                        break;
                }
            }

            //Print Statistic
            Console.ForegroundColor = ConsoleColor.Red;
            var counter = 1;
            Console.WriteLine($"The V-Logger has a total of {dictVlogers.Count} vloggers in its logs.");
            foreach (var vloger in dictVlogers.
                OrderByDescending(x=>x.Value.FollowersCount()).
                ThenBy(x=>x.Value.FollowingCount()))
            {
                if (counter==1)
                {
                    Console.WriteLine($"{counter}. {vloger.Key} : {vloger.Value.FollowersCount()} followers, {vloger.Value.FollowingCount()} following");
                    var listFollowers = vloger.Value.ListFollowers();
                    foreach (var liker in listFollowers.OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {liker}");
                    }
                }
                else
                {
                    Console.WriteLine($"{counter}. {vloger.Key} : {vloger.Value.FollowersCount()} followers, {vloger.Value.FollowingCount()} following");
                }
                counter++;
            }
        }
    }

    class Vloger
    {
        public string vlogerName;
        public List<string> followers;
        public List<string> following;

        public Vloger(string name)
        {
            this.Name = name;
            this.Followers = new List<string>();
            this.Following = new List<string>();
        }


        //following 
        public bool ContainsFollowing(string followingName)
        {
            if (this.Following.Contains(followingName))
            {
                return true;
            }
            return false;
        }

        public void AddFollowingName(string followingName)
        {
            this.Following.Add(followingName);
        }

        public List<string> ListFollowing()
        {
            return this.Following;
        }
        public int FollowingCount()
        {
            var result = this.Following.Count;
            return result;
        }

        //following 
        public bool ContainsFollowers(string followingName)
        {
            if (this.Followers.Contains(followingName))
            {
                return true;
            }
            return false;
        }

        public void AddFollowersName(string followingName)
        {
            this.Followers.Add(followingName);
        }

        public List<string> ListFollowers()
        {
            return this.Followers;
        }
        public int FollowersCount()
        {
            return this.Followers.Count;
        }

        public string Name { get; set; }
        public List<string> Followers { get; set; }
        public List<string> Following { get; set; }
    }

}

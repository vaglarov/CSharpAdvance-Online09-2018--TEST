
namespace _006._SoftUni_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniParty
    {
        static void Main(string[] args)
        {
            var hashSetGuestsList = new HashSet<string>();
            var inputName = string.Empty;

            //Add in list
            while ((inputName = Console.ReadLine()) != "PARTY")
            {
                if (inputName.Length == 8)
                {
                    if (!hashSetGuestsList.Contains(inputName))
                    {
                        hashSetGuestsList.Add(inputName);
                    }
                }
                else
                {
                    Console.WriteLine("The name is to long or short!");
                }
            }

            //Remove if guest is here
            var nameGuest = string.Empty;
            while ((nameGuest = Console.ReadLine()) != "END")
            {
                if (hashSetGuestsList.Contains(nameGuest))
                {
                    hashSetGuestsList.Remove(nameGuest);
                }
            }

            //Print result==> name of Guest did not come

            Console.ForegroundColor = ConsoleColor.Red;
            if (hashSetGuestsList.Count != 0)
            {
                Console.WriteLine(hashSetGuestsList.Count);
                foreach (var name in hashSetGuestsList.OrderBy(x=>x ))
                {
                    Console.WriteLine(name);
                }
            }
            else
            {
                Console.WriteLine("Еveryone came!");
            }
        }
    }
}

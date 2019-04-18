using System;

namespace NarutoCharacterIndex
{
    internal class Character
    {
        internal static string name;
        internal static int age;

        internal Character(string name, int age)
        {
            Character.name = name;
            Character.age = age;
        }

        internal static string PrintCharInfo => $"{name} {age}";

        internal static object GetCharInfo()
        {
            Console.WriteLine("What is the name of the character?");
            string newName = Console.ReadLine();
            Console.WriteLine("How old is the character?");
            int newAge = Convert.ToInt32(Console.ReadLine());

            var Character = new Character(newName, newAge);

            return Character;
        }
    }
}
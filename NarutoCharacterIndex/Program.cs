using System;
using Google.Cloud.Firestore;


namespace NarutoCharacterIndex
{
    class Program
    {
        internal static void Main(string[] args)
        {
            export GOOGLE_APPLICATION_CREDENTIALS="../CharacterIndex-05b988c7f612.json";
            Character.GetCharInfo();

            Console.WriteLine(Character.PrintCharInfo);
            Console.Read();

        }
    }
}

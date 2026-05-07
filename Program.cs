using System;

namespace inventory
{
    class Program
    {
        static void Main()
        {
            string[] inventar = {"Pusca" , "Pistolet" , "Cutit" , "Heal"};
            inventar [0] = "Pusca_lvl2";

            for (int i = 0 ; i < inventar.Length ; i++)
            {
                Console.WriteLine("El : " + inventar[i]);
            }
            
        }
    }
}
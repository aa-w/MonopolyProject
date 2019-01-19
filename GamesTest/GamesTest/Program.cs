using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesTest
{
    class Program
    {
        static void Main(string[] args)
        {
          const int PropertyCount = 28;

          Console.WriteLine("This is a test");
          string [] PropertyList = new string [PropertyCount]; //creates a list of all of the property classes

         //using hard coded class declaration otherwise shit gets fucckky

         //defining each Property as a class to keep the values clean

          Property Brown1 = new Property();
          Brown1.Name = "Old Kent Road";
          Brown1.Colour = "Brown";
          Brown1.Cost = 60;

          Property Brown2 = new Property();
          Brown2.Name = "Whitechapel Road";
          Brown2.Colour = "Brown";
          Brown2.Cost = 60;

         Property LightBlue1 = new Property();
         LightBlue1.Name = "The Angle Islington";
         LightBlue1.Colour = "Light Blue";
         LightBlue1.Cost = 100;

            PropertySetup();

          
            Console.ReadLine();


        }

        //defines each Property
        public static void PropertySetup ()
        {

            Console.WriteLine(Brown1.Name);
            Console.WriteLine(Brown2.Name);
            Console.WriteLine(LightBlue1.Name);


        }
    }

    public class Player
    {
      public int BoardPos = 0;
      public int Cash = 1500;
      public int [] PropertyOwned = new int [28]; //stores the PropertyOwned as a list max size
      //enum PlayerStyle; //this will be for the future when players have different styles
    }

    public class Property
    {
      public string Name;
      public string Colour;
      public int Cost;
      //houses and values may come later

      //this is used to define the type of property it is for cost calculation
      int PropertyDef = 1; //im being too lazy to use enums so lets just use int and a key 1 is normal, 2 is  TrainStation, 3 is Utility
    }



}

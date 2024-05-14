using System;

namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin greenDustbin = new Dustbin("Green");

            Garbage appleCore = new Garbage("Apple Core");
            PaperGarbage oldNewspaper = new PaperGarbage("Old Newspaper", true);
            PlasticGarbage waterBottle = new PlasticGarbage("Water Bottle", false);
            PlasticGarbage sodaCan = new PlasticGarbage("Soda Can", false);
            
            greenDustbin.ThrowOutGarbage(appleCore);
            greenDustbin.ThrowOutGarbage(oldNewspaper);
            
            try
            {
                greenDustbin.ThrowOutGarbage(waterBottle);
            }
            catch (DustbinContentException ex)
            {
                Console.WriteLine($"Cannot throw dirty plastic: {ex.Message}");
                
                waterBottle.Clean();  
                greenDustbin.ThrowOutGarbage(waterBottle); 
            }

            
            sodaCan.Clean();  
            greenDustbin.ThrowOutGarbage(sodaCan);
            
            greenDustbin.DisplayContents();
            
            greenDustbin.EmptyContents();
            Console.WriteLine("Dustbin emptied.");
            
            greenDustbin.DisplayContents();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Codecool.WasteRecycling
{
    public class Dustbin 
    {
        private readonly string color;
        private readonly List<Garbage> houseWaste;
        private readonly List<PaperGarbage> paperWaste;
        private readonly List<PlasticGarbage> plasticWaste;

        public string Color => color;
        public int HouseWasteCount => houseWaste.Count;
        public int PaperWasteCount => paperWaste.Count;
        public int PlasticWasteCount => plasticWaste.Count;

        public Dustbin(string color)
        {
            this.color = color;
            houseWaste = new List<Garbage>();
            paperWaste = new List<PaperGarbage>();
            plasticWaste = new List<PlasticGarbage>();
        }

        public void ThrowOutGarbage(Garbage garbage)
        {
            switch (garbage)
            {
                case PaperGarbage paper when paper.IsSqueezed:
                    paperWaste.Add(paper);
                    break;
                case PlasticGarbage plastic when plastic.IsCleaned:
                    plasticWaste.Add(plastic);
                    break;
                default:
                    if (!(garbage is PaperGarbage || garbage is PlasticGarbage))
                    {
                        houseWaste.Add(garbage);
                    }
                    else
                    {
                        throw new DustbinContentException("Invalid type or state");
                    }
                    break;
            }
        }

        public void EmptyContents()
        {
            houseWaste.Clear();
            paperWaste.Clear();
            plasticWaste.Clear();
        }

        public override string ToString()
        {
         return $"{Color} Dustbin!\n" +
                $"House waste content: {HouseWasteCount} item(s)\n" +
                $"{string.Join("\n", houseWaste.Select((item, index) => $"{item.Name} nr.{index + 1}"))}\n" +
                $"Paper content: {PaperWasteCount} item(s)\n" +
                $"{string.Join("\n", paperWaste.Select((item, index) => $"{item.Name} nr.{index + 1}"))}\n" +
                $"Plastic content: {PlasticWasteCount} item(s)\n" +
                $"{string.Join("\n", plasticWaste.Select((item, index) => $"{item.Name} nr.{index + 1}"))}";
        }

        public void DisplayContents()
        {
            Console.WriteLine(this.ToString());
        }
    }
}








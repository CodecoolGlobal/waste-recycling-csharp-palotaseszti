using System;

namespace Codecool.WasteRecycling
{
    public class Garbage
    {
        private readonly string name;

        public string Name => name;

        public Garbage(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Garbage must have a valid name", nameof(name));
            }

            this.name = name;
        }
    }
}

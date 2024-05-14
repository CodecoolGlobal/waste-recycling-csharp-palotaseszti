namespace Codecool.WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        private bool isCleaned;

        public bool IsCleaned
        {
            get { return isCleaned; }
            private set { isCleaned = value; }
        }

        public PlasticGarbage(string name, bool isCleaned) : base(name)
        {
            this.isCleaned = isCleaned;
        }

        public void Clean()
        {
            if (!isCleaned)
            {
                IsCleaned = true;
            }
        }
    }
}

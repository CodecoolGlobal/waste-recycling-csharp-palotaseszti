namespace Codecool.WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        private bool isSqueezed;

        public bool IsSqueezed
        {
            get { return isSqueezed; }
            private set { isSqueezed = value; }
        }

        public PaperGarbage(string name, bool isSqueezed) : base(name)
        {
            this.isSqueezed = isSqueezed;
        }

        public void Squeeze()
        {
            if (!isSqueezed)
            {
                IsSqueezed = true;
            }
        }
    }
}

namespace Chapter6
{
    internal class Building
    {
        private string v1;
        private string v2;

        public Building(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfStories { get; set; }
    }
}
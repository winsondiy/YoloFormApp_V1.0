namespace YoloMainApp
{
    public class ImageInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class YoloItem
    {
        public string Type { get; set; }
        public double Confidence { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Point Center()
        {
            return new Point(this.X + this.Width / 2, this.Y + this.Height / 2);
        }
    }
}

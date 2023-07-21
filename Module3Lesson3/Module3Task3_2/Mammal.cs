namespace Module3Task3_2
{
    public class Mammal: Animal
    {
        protected string FurColor { get; set; }
        
        public Mammal(string name, string furColor) : base(name) => FurColor = furColor;
        
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Fur color: {0}", FurColor);
        }
    }
}

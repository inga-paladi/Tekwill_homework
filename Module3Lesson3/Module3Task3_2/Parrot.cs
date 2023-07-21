namespace Module3Task3_2
{
    public class Parrot : Bird
    {
        protected string Vocabulary { get; set; }
        
        public Parrot(string name, string flightType, string vocabulary) : base(name, flightType) => Vocabulary = vocabulary;

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Vocabulary: {0}", Vocabulary);
        }
    }
}

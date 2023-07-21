namespace Module3Task3_2
{
    public class Bird : Animal
    {
        protected string FlightType { get; set; }
        
        public Bird(string name, string flightType) : base(name) => FlightType = flightType;
       
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Flight Type: {0}", FlightType);
        }
    }
}

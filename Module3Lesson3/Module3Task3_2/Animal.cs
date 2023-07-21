namespace Module3Task3_2
{
    public class Animal
    {
        protected string Name { get; set; }

        public Animal(string name) => Name = name;

        public virtual void ShowDetails() => Console.WriteLine("Animal name:{0}", Name);
    }
}

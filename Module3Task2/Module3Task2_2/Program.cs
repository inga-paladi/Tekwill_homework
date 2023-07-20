using Module3Task2_2;

class Program
{
    static void Main()
    {
        Book book1 = new Book("Sample Book", "John Doe", 2023, 240);
        Book book2 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997, 320);
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, 281);
        
        book1.ShowDetails();
        book2.ShowDetails();
        book3.ShowDetails();
    }
}
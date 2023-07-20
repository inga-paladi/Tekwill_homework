namespace Module3Task2_2
{
    public class Book
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private int ReleaseYear { get; set; }
        private int PageNumber { get; set; }


        public Book(string title,string author, int releaseYear, int pageNumber )
        { 
            Title = title;
            Author = author;
            ReleaseYear = releaseYear;
            PageNumber = pageNumber;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Release Year: " + ReleaseYear);
            Console.WriteLine("Page Number: " + PageNumber);
        }


    }
}

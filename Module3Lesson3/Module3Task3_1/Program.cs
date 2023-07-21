//Tema: Utilizarea moștenirii de un nivel și apelul constructorului de bază:
//1.Creați o clasă de bază numită Angajat care să conțină următoarele 
//proprietăți și metode:
//Proprietatea Nume pentru a reține numele angajatului.
//Metoda AfisareDetalii() pentru a afișa detaliile despre angajat.
using Module3Task3_1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Creating an Employee object and displaying details");
        new Employee("John Doe").ShowDetails();

        Console.WriteLine("Creating a Manager object and displaying details");
        new Manager("Jane Smith", "Sales").ShowDetails();
    }
}
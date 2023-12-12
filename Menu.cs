public class Menu
{
    public void Display()
    {
        Console.WriteLine("Witaj! Naciśnij odpowiedni klawisz, aby wykonać operację:");
        Console.WriteLine("1 - wyświetl całą bazę danych(dostępne opcje)");
        Console.WriteLine("2 - wyszukaj danego pracownika/kierownika(mozesz go usunąc lub zmienic jego dane)");
        Console.WriteLine("3 - dodaj pracownika");
        Console.WriteLine("4 - sortuj bazę");
        Console.WriteLine("x - zakończ dzialanie programu");
    }

    public void WyborOpcji()
    {
        string option = Console.ReadLine();
        
    }
}
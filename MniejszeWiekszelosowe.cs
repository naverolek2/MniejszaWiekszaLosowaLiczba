


Random rnd = new Random();
int liczba1, liczba2;
    liczba1 = rnd.Next(1, 10);
main();
int main()
 { 
    {
        Console.WriteLine("Zgadnij liczbę od 1 do 10");
        liczba2 = Convert.ToInt32(Console.ReadLine());
        if (liczba1 == liczba2)
        {
            Console.WriteLine("Gratulacje zgadłeś");
        }
        else
        {
            Console.WriteLine("Nie zgadłeś, spróbuj ponownie");
            if (liczba2 < liczba1)
            {
                Console.WriteLine("Podana liczba jest mniejsza niż wylosowana");    
            }
            if (liczba1 < liczba2)
            {
                Console.WriteLine("Podana liczba jest większa niż wylosowana");
            }
            main();
            
        }
    }
    return 0;
}
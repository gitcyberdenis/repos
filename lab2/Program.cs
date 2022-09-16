using System;
using System.Runtime.InteropServices;

class Adress
{ string index;
    public string Index
    { set
            index=02175;
            }
    get
{
        return Index;
}
}
Public string Country
{
    set
    {
        country = Ukraine;
    }
    get
    {
        return country;
    }
}
public string city
{
    set
    {
        city = Kyiv;
    }
    get
    {
        return city;
    }
}
public string Street
{
    set
    {
        street = Kharkivske highway;
    }
    get
    {
        return street;
    }
}
public string House
{
    set
    {
        house = 58;
    }
    get
    {
        return house;
    }
}
public string Apartment
{
    set
    {
        apartment = 36;
    
    get
    {
        return apartment;
    }

    }
        class Program
{
    static void Main()
    {
        Adress program = new Adress();
        program.Index = "02175";
        Console.WriteLine(program.Index);
        program.Country = "Ukraine";
        Console.WriteLine(program.Country);
        program.City = "Kyiv";
        Console.WriteLine(program.City);
        program.Street = "Kharkivske highway";
        Console.WriteLine(program.Street);
        program.House = "58";
        Console.WriteLine(program.House);
        program.Apartment = "36";
        Console.WriteLine(program.Apartment);
    }
}

class Converter
{
    private:
    double eur;
    double usd;

    public:
    Converter(double eur, double usd) : eur(eur), usd(usd)
    {
        std::cout.precision(4);
    }

    void menu()
    {
        int choice, stat = 1;
        double value;
        while (stat)
        {
            std::cout << "\n1. uah to eur\n2. uah to usd\n3. usd to uah\n4. eur to uah\n5. rub to uah\n6. uah to rub\n0. Exit"
                      << std::endl;
            std::cout << ">>> ";
            std::cin >> choice;
            std::cout << "Value >>> ";
            std::cin >> value;
            switch (choice)
            {
                case 1:
                    std::cout << value << " uah = " << value / eur << " eur.\n";
                    break;
                case 2:
                    std::cout << value << " uah = " << value / usd << " usd.\n";
                    break;
                case 3:
                    std::cout << value << " usd = " << value * usd << " uah.\n";
                    break;
                case 4:
                    std::cout << value << " eur = " << value * eur << " uah.\n";
                    break;
                case 5:
                    std::cout << value << " uah = " << value * rub << " rub.\n";         
                    break;
                case 6:
                    std::cout << value << " rub = " << value * uah << " uah.\n";
                    break;
                case 0:
                    stat = 0;

                default:
                    std::cout << "Incorrect input!\n";
            }
        }
    }
};

int main()
{
    Converter converter(36.64, 36.65, 0,61);
converter.menu();
}

class user
{
    public string name;
    public int age;
    public int username

}







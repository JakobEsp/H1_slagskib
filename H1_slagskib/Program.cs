// See https://aka.ms/new-console-template for more information
class Program
{
    static Random random = new();
    static int size = 5;
    static int ships = 3;
    static int[,] coordinates = new int[size, size];
    static void Main(string[] args)
    {
        Menu();
        Grid();
        AddRandomShips(ships);
        ShowGrid();
    }

    private static void Menu()
    {
        Console.WriteLine("Welcome to battleships!");
        //As long as the input connot parse to int. The loop will continue.
        //If it CAN parse to int, then it outputs the value [size] and the method returns true and breaks the loop.
        do{Console.WriteLine(" Choose size of grid: ");}
        while (!int.TryParse(Console.ReadLine(), out size));
        coordinates = new int[size, size];
        do{Console.WriteLine(" How many ships: ");}
        while (!int.TryParse(Console.ReadLine(), out ships));
 
        //do
        //{
        //    string input = Console.ReadLine();
        //    bool b = int.TryParse(input, out size);
        //    if (b) break;
        //} while (true);

    }

    static void AddRandomShips(int ships)
    {
        for(int i = 0; i < ships; i++)
        {
            while (true)
            {
                int y = random.Next(0, size);
                int x = random.Next(0, size);
                if (coordinates[x, y] == 0) 
                {
                    coordinates[x, y] = 1;
                    break;
                }
            }   
        }
        
    }
    static void ShowGrid()
    {
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                Console.Write(coordinates[x, y]);
            }
            Console.WriteLine();
        }
    }

    static void Grid()
    {
        for(int x = 0; x < size; x++)
        {
            for(int y = 0; y < size; y++)
            {
                coordinates[x, y] = 0;
            }
        }
    }
}
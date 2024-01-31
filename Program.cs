internal class Program
{
    private static void Main(string[] args)
    {
        //Welcome the user
        Console.WriteLine("Welcome to TicTacToe!");

        //Create game board array
        string[] gameBoard = new string[9];
        bool WinGame = false;
        int player = 0

        //Ask players for their choice & update game board
        while (!WinGame)
        {
            Console.WriteLine("Where would you like to play? Pick a number 1-9.");
            
            int choice = Console.ReadLine();
            //Check if choice is already used/acceptable
            if ((choice > 9) | (choice < 1))
            {
                Console.WriteLine("Please choose a number between 1 and 9");
            }
        }


        //Method(choice, gameBoard);


        //Ask plaers for their choice & update game board

        //Print board by calling method in TicTacTools

        //Check for winner by calling method in TicTacTools & notify players who won
    }
}
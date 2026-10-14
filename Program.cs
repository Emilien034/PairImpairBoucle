namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */

        string restart;
        do
        {
            Console.WriteLine("Donne moi un nombre entier.");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Ce nombre est pair.");
            }
            else
            {
                Console.WriteLine("Ce nombre est impair.");
            }
            Console.WriteLine("Veux-tu vérifier un autre nombre ou sortir? (y/n)");
            restart = Console.ReadLine();
        } while (restart == "y" || restart == "Y");
    }
}

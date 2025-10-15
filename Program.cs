namespace LeetCode_1812
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Coordinates");
            string c = Console.ReadLine();

            Console.WriteLine("The Color is White?");
            Console.WriteLine(SquareIsWhite(c));

            bool SquareIsWhite(string coordinates)
            {

                switch (coordinates)
                {
                    case "a1":
                    case "a3":
                    case "a5":
                    case "a7":

                    case "c1":
                    case "c3":
                    case "c5":
                    case "c7":

                    case "e1":
                    case "e3":
                    case "e5":
                    case "e7":

                    case "g1":
                    case "g3":
                    case "g5":
                    case "g7":

                    case "b2":
                    case "b4":
                    case "b6":
                    case "b8":

                    case "d2":
                    case "d4":
                    case "d6":
                    case "d8":

                    case "f2":
                    case "f4":
                    case "f6":
                    case "f8":

                    case "h2":
                    case "h4":
                    case "h6":
                    case "h8":
                        return false;
                    default:
                        return true;

                   }
                }
            }
    }
}

namespace CodeStyleAsErrorDoesntBreakTheBuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i < args.Length; i++)
            {

            }

            if (i < 5)
                throw new Exception("");
        }
    }
}

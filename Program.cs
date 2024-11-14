namespace reserved;

   internal class Program
    {
        static void Main()
        {
        Console.WriteLine("ваше шестизначное число");
        string input = Console.ReadLine();

        if (input.Length == 6)
        {
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine("Число наизнанку" + reversed);
        }
        else
        {
            Console.WriteLine("Error404");
        }
    }
}

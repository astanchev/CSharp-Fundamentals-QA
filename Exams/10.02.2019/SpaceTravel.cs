namespace _01.SpaceTravel
{
    using System;
    using System.Text;

    class SpaceTravel
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string planet = Console.ReadLine();
                string message = Console.ReadLine();
                
                StringBuilder decodedMessage = new StringBuilder();

                for (int i = 0; i < message.Length; i += 2)
                {
                    int charASCII = (message[i] - 48) * 10 + (message[i + 1] - 48);

                    decodedMessage.Append((char)charASCII);
                }

                Console.WriteLine(decodedMessage);

                if (decodedMessage.ToString() == "GO HOME")
                {
                    break;
                }
            }

            Console.WriteLine("Going home.");
        }
    }
}

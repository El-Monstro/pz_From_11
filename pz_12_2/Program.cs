namespace pz_12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            string command;

            Console.WriteLine("Управление плеером:");
            Console.WriteLine("Введите команду (play, pause, stop, rewind):");

            while (true)
            {
                Console.Write("Введите команду: ");
                command = Console.ReadLine()?.ToLower();

                if (command == "play")
                {
                    player.Play();
                }
                else if (command == "pause")
                {
                    player.Pause();
                }
                else if (command == "stop")
                {
                    player.Stop();
                }
                else if (command == "rewind")
                {
                    player.Rewind();
                }
                else if (command == "exit")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неизвестная команда. Попробуйте снова.");
                }
            }
        }
    }
}

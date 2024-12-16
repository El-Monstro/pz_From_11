namespace pz_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип файла для просмотра:");
            Console.WriteLine("1. Графический файл");
            Console.WriteLine("2. Текстовый файл");
            Console.WriteLine("3. JSON файл");

            int choice = int.Parse(Console.ReadLine());

            // Запрашиваем путь к файлу
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();  // Путь к файлу

            // В зависимости от выбора пользователя создается соответствующая фабрика
            IFileViewerFactory factory = choice switch
            {
                1 => new ImageFileViewerFactory(),
                2 => new TextFileViewerFactory(),
                3 => new JsonFileViewerFactory(),
                _ => throw new ArgumentOutOfRangeException()
            };

            // Создаем файл через выбранную фабрику
            IFileViewer viewer = factory.CreateFileViewer(filePath);

            // Выводим содержимое файла
            viewer.DisplayFile();
        }
    }
}

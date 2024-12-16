namespace pz_13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем обработчиков
            var employeeHandler = new EmployeeComplaintHandler();
            var managerHandler = new ManagerComplaintHandler();
            var directorHandler = new DirectorComplaintHandler();
            var ceoHandler = new CEOComplaintHandler();

            // Устанавливаем цепочку
            employeeHandler.SetNext(managerHandler);
            managerHandler.SetNext(directorHandler);
            directorHandler.SetNext(ceoHandler);

            // Инструкция для пользователя
            Console.WriteLine("Добро пожаловать в систему обработки жалоб.");
            Console.WriteLine("Введите жалобу на сотрудника, менеджера, директора или генерального директора.");
            Console.WriteLine("Введите 'exit' для выхода из программы.");

            while (true)
            {
                // Запрос жалобы от пользователя
                Console.Write("\nВведите жалобу: ");
                string complaint = Console.ReadLine();

                // Проверка на пустую строку
                if (string.IsNullOrWhiteSpace(complaint))
                {
                    Console.WriteLine("Жалоба не может быть пустой. Пожалуйста, введите корректную жалобу.");
                    continue;  // Пропускаем итерацию, если введена пустая строка
                }

                if (complaint.ToLower() == "exit")
                {
                    break;  // Прерываем цикл, если пользователь хочет выйти
                }

                // Обрабатываем жалобу
                employeeHandler.HandleComplaint(complaint);
            }

            Console.WriteLine("Программа завершена.");
        }
    }
}

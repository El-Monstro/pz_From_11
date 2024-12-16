namespace pz_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип контакта:");
            Console.WriteLine("1. Личный контакт");
            Console.WriteLine("2. Рабочий контакт");
            Console.WriteLine("3. Семейный контакт");
            int choice = int.Parse(Console.ReadLine());

            // В зависимости от выбора пользователя создается соответствующая фабрика
            ContactFactory factory = choice switch
            {
                1 => new PersonalContactFactory(),
                2 => new WorkContactFactory(),
                3 => new FamilyContactFactory(),
                _ => throw new ArgumentOutOfRangeException()
            };

            // Создаем контакт через выбранную фабрику
            Contact contact = factory.CreateContact();
            contact.Name = "Пример имени";
            contact.PhoneNumber = "123-456-7890";
            contact.Email = "example@mail.com";

            // Дополнительные действия для рабочих и семейных контактов
            if (contact is WorkContact workContact)
            {
                workContact.Position = "Менеджер";
            }

            if (contact is FamilyContact familyContact)
            {
                familyContact.Relationship = "Брат";
            }

            // Вызываем метод для отображения информации о контакте
            contact.DisplayContactInfo();
        }
    }
}

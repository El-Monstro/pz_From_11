namespace pz_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка email:");
            var emailValidator = new EmailValidator();
            emailValidator.Validate("user@example.com");  // Должно пройти проверку

            Console.WriteLine("\nПроверка диапазона чисел:");
            var rangeValidator = new RangeValidator(10, 50);
            rangeValidator.Validate("25");  // Должно пройти проверку

            Console.WriteLine("\nНеверный email:");
            emailValidator.Validate("user@notexample.com");  // Должно не пройти проверку

            Console.WriteLine("\nНеверное число:");
            rangeValidator.Validate("100");  // Должно не пройти проверку
        }
    }
}

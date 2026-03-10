namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Логика
            var table = Logic.GenerateMultiplicationTable(7);
            
            // Взаимодействие с пользователем
            foreach (var line in table)
            {
                Console.WriteLine(line);
            }
        }
    }
}
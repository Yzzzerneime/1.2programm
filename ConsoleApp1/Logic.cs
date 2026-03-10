namespace MultiplicationTable
{
    public class Logic
    {
        public static List<string> GenerateMultiplicationTable(int multiplier, int from = 1, int to = 9)
        {
            var table = new List<string>();
            for (int i = from; i <= to; i++)
            {
                table.Add($"{i} x {multiplier} = {i * multiplier}");
            }
            return table;
        }
        
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
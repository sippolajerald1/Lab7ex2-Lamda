namespace Lab7ex2_Lamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;


            int[] numbers = new int[1];

            Console.WriteLine("Please enter a value x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter value y:");
            y = int.Parse(Console.ReadLine());

            for (int i =0; i < numbers.Length; i++)
            {
                numbers = new int[] { x, y };
            } 


            // Lamda Expressions
            // Add 2 Numbers
            var sum = (int x, int y) => x + y;
            // Multiply 2 numbers
            var result = (int x, int y) => x * y;
            // Lamda Statements
            // Find the smaller value

            
            var smallerValue = (int x, int y) =>
            {
                if (x < y)
                    return x;
                else
                    return y;
            };

         
            // Using lamda expressions and statements
            for ( int z = 0; z < numbers.Length-1; z++)
            {
                Console.WriteLine($"Numbers you are using: {numbers[z]} and {numbers[z+1]}");
                Console.WriteLine($"The 2 numbers added: {sum(numbers[z], numbers[z + 1])}");
                Console.WriteLine($"The multiplication is: {result(numbers[z], numbers[z + 1])}");
                Console.WriteLine($"The smaller value is: {smallerValue(numbers[z], numbers[z + 1])}");
                Console.WriteLine();
            }

        }
    }
}

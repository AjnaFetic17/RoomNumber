public class RoomNumber
{
    public static int LowerLimit { get; set; } = 1;
    public static int UpperLimit { get; set; } = 1000000;

    public static int numberOfSets(int roomNumber)
    {
        if (roomNumber < LowerLimit || roomNumber > UpperLimit)
        {
            throw new ArgumentException($"Please provide number in range from {RoomNumber.LowerLimit} to {RoomNumber.UpperLimit}.");
        }

        var digits = GetDigits(roomNumber).ToList().GroupBy(p => (p == 6 || p == 9) ? 6 : p)
            .ToDictionary(p => p.Key, q => q.Key==6 ? (int)Math.Ceiling(q.Count()/2.0) : q.Count());

        return digits.Values.Max();
    }

    public static IEnumerable<int> GetDigits(int source)
    {
        while (source > 0)
        {
            var digit = source % 10;
            source /= 10;
            yield return digit;
        }
    }
}

public static class Program
{
    public static void Main()
    {
        try
        {
            var check = false;
            int number = 0;

            while (!check)
            {
                Console.WriteLine("Please enter the number of the room.");
                number = Convert.ToInt32(Console.ReadLine());
                if (number < RoomNumber.LowerLimit || number > RoomNumber.UpperLimit)
                {
                    Console.WriteLine($"Please provide number in range from {RoomNumber.LowerLimit} to {RoomNumber.UpperLimit}.");
                }
                else
                {
                    check = true;
                }
            }

            var result = RoomNumber.numberOfSets(number);
            Console.WriteLine($"Required number of sets is {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
using System;

namespace LinterExamples
{
    public class UserService
    {
        public string GetUserInfo(int userId) 
        {
            if (userId <= 0)
            {
                return "Invalid User ID";
            }
            return $"User ID: {userId}";
        }

        public void ProcessData()
        {
            int tempData = 42;

            Console.WriteLine("Processing Data...");
        }

        public int CalculateTotal(int[] numbers){
          int total = 0;

            foreach (var num in numbers)
            {
                total += num;
            }

            return total;
        }

        public void PrintSummary()
        {
            Console.WriteLine("Summary printed successfully.");
        }
    }
}

using System;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            // Enter income
            int debitSum = 0;
            for(int i = 0;i < 10; i++)
            {
                string debit = "";
                int debitInt;
                
                Console.Write("Enter the your income: ");
                debit = Console.ReadLine();
               
                int.TryParse(debit, out debitInt); // translate from string to number
                debitSum += debitInt;
            }
            Console.WriteLine("Your income: " + debitSum);
            Console.WriteLine(); // для разделения строк

            //Вводим expenses
            int expensesSum = 0;
            for(int i =0; i < 10; i++)
            {
                string expenses = "";
                Console.Write("Enter the your expenses: ");
                expenses = Console.ReadLine();

                int expensesInt;
                int.TryParse(expenses, out expensesInt); //translate from string to number
                expensesSum += expensesInt;
            }
            Console.WriteLine("Your expenses: " + expensesSum.ToString());
            Console.WriteLine();

        
            //Balance calculation
            int balance = debitSum - expensesSum;
            Console.WriteLine("Your balance: " + balance);

            // Output conditions
            if (balance > 0)
            {
                Console.WriteLine("Congratulations! You have money!");
            }
            else
            {
                Console.WriteLine("You have debts!");
            }
           

            Console.ReadKey();
        }
    }
}

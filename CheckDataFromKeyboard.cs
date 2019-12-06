
using System;

public class CheckDataFromKeyboard
    {
    public int CheckNumber()
        {
            String enteredData;
            int num = 0;
            bool isNum = false;

            while (!isNum)
            {
                enteredData = Console.ReadLine();
                isNum = int.TryParse(enteredData, out num);
                if (isNum)
                {
                    return num;
                }
                Console.WriteLine("Incorrest format. Correct format is: 16");
                Console.Write("Try again: ");
            }
            return num;
        }
}


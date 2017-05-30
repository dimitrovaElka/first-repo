using System;

namespace SMSTyping
{
    public class SMSTyping
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var message = "";

            for (int i = 0; i < n; i++)
            {
                var inputNum = Console.ReadLine();
                // ASCII code 0 -> 48
                var mainDigit = inputNum[0] - 48;
                var digitLength = inputNum.Length;
                var offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                var letterIndex = offset + digitLength - 1;
                if (mainDigit > 0)
                {
                    message += alphabet[letterIndex];
                }
                else if (mainDigit == 0)
                {
                    message += " ";
                }
            }
            Console.WriteLine(message);
        }
    }
}

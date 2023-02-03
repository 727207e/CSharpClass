namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_03
{
    public class Division
    {
        public static void Main()
        {
            int numerator;
            int denominator;
            int quotient;
            int remainder;

            System.Console.Write("Enter the numerator: ");
            numerator = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the denominator: ");
            denominator = int.Parse(System.Console.ReadLine());

            quotient = numerator / denominator;
            remainder = numerator % denominator;

            System.Console.WriteLine(
                $"{numerator} / {denominator} = {quotient} with remainder {remainder}");
        }
    }
}

/*
 ��� ���� ������
 
 + - * / %

* ���ϱ�
/ ������ (��� �� ��)
% ������ (��� �� ������)

��ǻ�� ��� ��� - ��Ģ������ ������ ���´�.
 

            int number1 = 5;
            int number2 = 16;

            int plus = number1 + number2;
            System.Console.WriteLine($"P : {plus}");

            int minus;
            minus = 5 - number2;
            System.Console.WriteLine($"Min : {minus}");

            int mult = number1 * 16;
            System.Console.WriteLine($"Mul : {mult}");

            int quotient;
            quotient = 16 / 5;
            System.Console.WriteLine($"Quo : {quotient}");

            int remainder = number2 % 5;
            System.Console.WriteLine($"Rem : {remainder}");


 */
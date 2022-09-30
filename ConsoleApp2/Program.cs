//Люков Андрей 22-ИСП-2/2 
try 
{
    Console.WriteLine("введите длину основания а трапеции");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("введите длину основания b трапеции");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("введите высоту h трапеции");
    double h = double.Parse(Console.ReadLine());
    double res = Math.Sqrt(Math.Pow(Math.Abs(a - b) / 2, 2) + Math.Pow(h, 2)) * 2 + a + b;
    Console.WriteLine("периметр трапеции");
    Console.WriteLine(res);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString);
}
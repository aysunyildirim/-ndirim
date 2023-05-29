namespace İndirim
{
    internal class İndirim
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Kac lira alisveris yaptın");
            var can = Console.ReadLine();
            int yeni = Convert.ToInt32();

            yeni = yeni/10;

            Console.WriteLine(yeni +"tl indirim");
            Console.ReadLine();
        }
    }
}
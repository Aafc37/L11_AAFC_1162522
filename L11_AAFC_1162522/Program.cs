class Program
{
    static void Main(string[] args)
    {
        int tipo1, resu;
            
            double cant2, dola;



        Console.WriteLine("Bienvenido ;)");


        Console.WriteLine("Ingrese 1 para dolares a euros, ingrese 2 para libras a euros, ingrese 3 para yen a euros");
        tipo1 = Int32.Parse(Console.ReadLine());


        Console.WriteLine("Ingrese la cantidad: ");
        cant2 = Int32.Parse(Console.ReadLine());

    
     


        if ( tipo1 == 1)
        {
            Console.WriteLine("Su cantidad es " + cant2 * 0.75);
        }

        if (tipo1 == 2)
        {
            Console.WriteLine("Su cantidad es " + cant2 * 1.22);
        }

        if (tipo1 == 3)
        {
            Console.WriteLine("Su cantidad  es " + cant2 * 0.009);
        }
    }
}
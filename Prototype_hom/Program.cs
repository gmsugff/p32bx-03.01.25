namespace Prototype_hom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ввидите: \n 1 - sets\n 2 - выход\n ");
                int use2 = int.Parse(Console.ReadLine());
            switch (use2) 
            {
                case 1:
                        Console.WriteLine("выбирите set:\n1- Праздничный: пицца, суши, бургер;\n2 - Офисный: пицца, суши");
                        int use = int.Parse(Console.ReadLine());
            OrderSet set1 = new OrderSet("пицца 4 сыра", "суши с крабом", "бургер"); ;
            OrderSet set2;
                    switch (use)
                    {
                        case 1:

                            Console.WriteLine(set1);

                            break;
                        case 2:
                            set2 = set1.Clon();
                                set2.Pizza = "bigdir";
                                set2.Sushi = "girtino";
                            set2.Burger = null;
                            Console.WriteLine(set2);
                            break;
                    }
                    break;                    
                case 2:
                    return;
            }

            }
        }
    }

 public interface IClonPrototype<T>
    {
        public T Clon();

    }
    public class OrderSet : IClonPrototype<OrderSet>
    {

        public string Pizza { get; set; }
        public string Sushi { get; set; }
        public string Burger { get; set; }

        public OrderSet(string pizza, string sushi, string burger)
        {
            Pizza = pizza;
            Sushi = sushi;
            Burger = burger;
        }

        public OrderSet Clon()
        {

            return (OrderSet)MemberwiseClone();
        }
        public override string ToString()
        {
            if (Pizza == null)
            {
                 return $" Sushi {Sushi}\n Burger: {Burger}\n";
            }
            else if(Sushi == null)
            {
                return $" Pizza:{Pizza}\n Burger: {Burger}\n";
            }
            if (Burger == null)
            {
                return $" Pizza:{Pizza}\n Sushi {Sushi}\n";
            }
            else
            {
                return $"Состав:\n Pizza:{Pizza}\n Sushi {Sushi}\n Burger: {Burger}\n";
            }
        }
    }
}
        

        
               


            
           
        
    
   


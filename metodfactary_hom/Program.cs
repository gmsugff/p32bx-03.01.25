using static metodfactary_hom.Delivery;

namespace metodfactary_hom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("выберите\n 1 - выбор доставки\n 2 -выход\n");
                int user = int.Parse(Console.ReadLine());
                switch (user)
                {
                    case 1:
                Console.WriteLine("выберите тип доставки\n 1- пицца\n 2-суши\n 3- бургер\n");
                int chonse = int.Parse(Console.ReadLine());
                Delivery delivery = null;
                        switch (chonse)
                        {
                            case 1:
                                delivery = new PizzaDelivery();
                                break;
                            case 2:
                                delivery = new SushiDelivery();
                                break;
                            case 3:
                                delivery = new BurgerDelivery();
                                break;
                            default:
                                Console.WriteLine("некорекный выбор");
                                break;

                        }
                delivery.Delivery_1();
                        break;
                    case 2:
                        return;
                }
              
       
            }
        } 
    }
    public abstract class Food
    {
        public abstract void Prepare();


    }


    public class Pizza : Food
    {



        public override void Prepare()
        {
            
            Console.WriteLine("Вы выбрали:Пицца");
            Console.WriteLine("доставка выпоняется в коробке");
        }
    }
    public class Sushi : Food
    {
        public override void Prepare()
        {
            Console.WriteLine("Вы выбрали:Суши");
            Console.WriteLine("доставка выпоняется в специальном контейнире");
        }


    }
    public class Burger : Food
    {
        public override void Prepare()
        {
           
            Console.WriteLine("Вы выбрали:Бургер");
            Console.WriteLine("доставка выпоняется в картонных коробках");
        }


    }


    public abstract class Delivery
    {
        public abstract Food CreateFood();
        public void Delivery_1()
        {
            var food = CreateFood();
            food.Prepare();
            
        }
        public class PizzaDelivery : Delivery
        {
            public override Food CreateFood()
            {
                return new Pizza();
            }
        }

        public class SushiDelivery : Delivery
        {
            public override Food CreateFood()
            {
                return new Sushi();
            }
        }
        public class BurgerDelivery : Delivery
        {
            public override Food CreateFood()
            {
                return new Burger();
            }
        }

    }
}

using System;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductChair CreateChair();
        IAbstractProductCoffeeTable CreateCoffeeTable();
        IAbstractProductSofa CreateSofa();
    }
    class VictorianFurnitureConcreteFactory : IAbstractFactory
    {
        public IAbstractProductChair CreateChair()
        {
            return new ConcreteProductVictorianChair();
        }

        public IAbstractProductCoffeeTable CreateCoffeeTable()
        {
            return new ConcreteProductVictorianCoffeeTable();
        }
        
        public IAbstractProductSofa CreateSofa()
        {
            return new ConcreteProductVictorianSofa();
        }
    }
    class ModernFurnitureConcreteFactory : IAbstractFactory
    {
        public IAbstractProductChair CreateChair()
        {
            return new ConcreteProductModernChair();
        }

        public IAbstractProductCoffeeTable CreateCoffeeTable()
        {
            return new ConcreteProductModernCoffeeTable();
        }
        
        public IAbstractProductSofa CreateSofa()
        {
            return new ConcreteProductModernSofa();
        }
    }
    
    public interface IAbstractProductChair
    {
        string UsefulFunctionChair();
    }
    
    class ConcreteProductVictorianChair : IAbstractProductChair
    {
        public string UsefulFunctionChair()
        {
            return "The result of the UsefulFunctionChair VictorianChair.";
        }
    }

    class ConcreteProductModernChair : IAbstractProductChair
    {
        public string UsefulFunctionChair()
        {
            return "The result of the UsefulFunctionChair ModernChair.";
        }
    }
    
    public interface IAbstractProductCoffeeTable
    {
        string UsefulFunctionCoffeeTable();
    }
    
    class ConcreteProductVictorianCoffeeTable : IAbstractProductCoffeeTable
    {
        public string UsefulFunctionCoffeeTable()
        {
            return "The result of the UsefulFunctionCoffeeTable VictorianCoffeeTable.";
        }
    }

    class ConcreteProductModernCoffeeTable : IAbstractProductCoffeeTable
    {
        public string UsefulFunctionCoffeeTable()
        {
            return "The result of the UsefulFunctionCoffeeTable ModernCoffeeTable.";
        }
    }
    
    public interface IAbstractProductSofa
    {
        string UsefulFunctionSofa();
        string AnotherUsefulFunctionSofa();
    }
    
    class ConcreteProductVictorianSofa : IAbstractProductSofa
    {
        public string UsefulFunctionSofa()
        {
            return "The result of the UsefulFunctionSofa VictorianSofa.";
        }
        public string AnotherUsefulFunctionSofa()
        {
            return "The result of the AnotherUsefulFunctionSofa VictorianSofa.";
        }
    }

    class ConcreteProductModernSofa : IAbstractProductSofa
    {
        public string UsefulFunctionSofa()
        {
            return "The result of the UsefulFunctionSofa ModernSofa.";
        }
        public string AnotherUsefulFunctionSofa()
        {
            return "The result of the AnotherUsefulFunctionSofa ModernSofa.";
        }
    }
    
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new VictorianFurnitureConcreteFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ModernFurnitureConcreteFactory());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var Chair = factory.CreateChair();
            var CoffeeTable = factory.CreateCoffeeTable();
            var Sofa = factory.CreateSofa();

            Console.WriteLine(Chair.UsefulFunctionChair());
            Console.WriteLine(CoffeeTable.UsefulFunctionCoffeeTable());
            Console.WriteLine(Sofa.AnotherUsefulFunctionSofa());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
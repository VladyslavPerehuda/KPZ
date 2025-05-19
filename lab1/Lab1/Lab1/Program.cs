using Lab1.Animals;
using Lab1.Enclosures;
using Lab1.Food;
using Lab1.Staff;
using Lab1.Management;

class Program
{
    static void Main(string[] args)
    {
        
        IEnclosure savannah = new Savannah();
        IEnclosure smallCage = new SmallCage();

        
        IAnimal lion = new Lion("Simba");
        IAnimal parrot = new Parrot("Polly");

       
        savannah.AddAnimal(lion);
        smallCage.AddAnimal(parrot);

       
        IFood meat = new Meat();
        IFood grass = new Grass();

        
        IStaff zookeeper = new Zookeeper("Alex");
        IStaff vet = new Veterinarian("Dr. Smith");

        
        zookeeper.Work();
        vet.Work();

        
        lion.Eat(meat);
        parrot.Eat(grass);

        
        ZooInventory inventory = new ZooInventory();
        inventory.AddAnimal(lion);
        inventory.AddAnimal(parrot);
        inventory.AddEnclosure(savannah);
        inventory.AddEnclosure(smallCage);
        inventory.AddStaff(zookeeper);
        inventory.AddStaff(vet);
        inventory.AddFood(meat);
        inventory.AddFood(grass);

        
        inventory.PrintReport();
    }
}
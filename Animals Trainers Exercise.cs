using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        Animals dog = new Animals();
        dog.Name = "Max";

        Animals cat = new Animals();
        cat.Name = "Lucy";

        Animals elephant = new Animals();
        elephant.Name = "Fofy";

        Trainers john = new Trainers();
        john.TrainerName = "John Jackson";

        ArrayList list = new ArrayList();
        list.Add(dog);
        list.Add(cat);
        list.Add(elephant);
        list.Add(john);

        foreach (var item in list)
        {
            if (typeof(Animals) == item.GetType())
            {
                Console.WriteLine();
                ((Animals)item).SayHi();
                ((Animals)item).Feed();
            }
            else
            {
                Console.WriteLine();
                ((Trainers)item).SayHi();
            }
        }
    }

    struct Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello my name is " + name);
        }

        public void Feed()
        {
            Console.WriteLine(name + " is now Eating");
        }
    }
    
    struct Trainers
    {
        private string trainerName;

        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello I Am The New Trainer");
        }
    }
}

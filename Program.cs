namespace HomeTaskAnimal.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            dog.Name = "Kara";
            dog.Breed = "Bulldog";
            dog.Gender = "Male";

            Console.WriteLine($"Ad-{dog.Name} \nBreed-{dog.Breed} \nGender-{dog.Gender} \nBirthYear-{dog.BirthYear}");


        }
    }
}
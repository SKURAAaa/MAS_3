using System;

public class Program
{
    public static void Main(string[] args)
    {
        Zoo zoo = new Zoo("City Zoo");

        Enclosure lionEnclosure = new Enclosure("Lion Enclosure");
        Enclosure reptileEnclosure = new Enclosure("Reptile Enclosure");

        // Wieloaspektowe zwierzęta
        Animal lion = new Mammal("Leo", 5);
        IHabitat landHabitat = new LandHabitat();
        MultiAspectAnimal landLion = new MultiAspectAnimal(lion, landHabitat);

        Animal crocodile = new Reptile("Croc", 12);
        IHabitat waterHabitat = new WaterHabitat();
        MultiAspectAnimal waterCrocodile = new MultiAspectAnimal(crocodile, waterHabitat);

        lionEnclosure.AddAnimal(landLion);
        reptileEnclosure.AddAnimal(waterCrocodile);

        zoo.AddEnclosure(lionEnclosure);
        zoo.AddEnclosure(reptileEnclosure);

        Keeper john = new Keeper { Name = "John", Experience = 10 };
        zoo.AddKeeper(john);

        zoo.AssignKeeperToAnimal(landLion, john);
        zoo.AssignKeeperToAnimal(waterCrocodile, john);

        // Dynamiczne zwierzęta
        DynamicAnimal dynamicLion = new DynamicMammal("Leo", 5);
        DynamicHabitatAnimal dynamicAnimal = new DynamicHabitatAnimal(dynamicLion, landHabitat);

        dynamicAnimal.MakeSound();
        dynamicAnimal.DescribeAnimal();
        dynamicAnimal.DescribeHabitat();

        DynamicAnimal dynamicCrocodile = new DynamicReptile("Croc", 12);
        dynamicAnimal.ChangeAnimal(dynamicCrocodile);
        dynamicAnimal.ChangeHabitat(waterHabitat);

        dynamicAnimal.MakeSound();
        dynamicAnimal.DescribeAnimal();
        dynamicAnimal.DescribeHabitat();
        
        // Overlapping examples
        Employee employee = new Employee("Alice", 30, 3000);
        Student student = new Student("Bob", 20, 1000);
        Pensioner pensioner = new Pensioner("Charlie", 65, 1500);
        WorkingStudent workingStudent = new WorkingStudent("Dave", 25, 2000, 500);

        employee.Work();
        student.Study();
        pensioner.Relax();
        workingStudent.Work();
        workingStudent.Study();

        employee.EmployeeMethod();
        student.StudentMethod();
        pensioner.PensionerMethod();
        workingStudent.EmployeeMethod();
        workingStudent.StudentMethod();

        Console.WriteLine($"Employee Income: {employee.GetIncome()}");
        Console.WriteLine($"Student Income: {student.GetIncome()}");
        Console.WriteLine($"Pensioner Income: {pensioner.GetIncome()}");
        Console.WriteLine($"WorkingStudent Total Income: {workingStudent.GetIncome()}");
    }
}

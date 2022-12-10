namespace InstanceVariables
{
    internal class Program
    {
        // These variables are instance variables/non static.
        // These variables are in a Program class and are not inside any function
        int physicsMarks;
        int chemistryMarks;
        int mathsMarks;
        int totalMarks;

        //creating a non static method to get the total marks
        void TotalNumber()
        {
            totalMarks = physicsMarks + chemistryMarks + mathsMarks;
            Console.WriteLine("Total Marks is out of 300: " +totalMarks);
        }

        //Staic Main Method
        public static void Main(String[] args)
        {
            //need to create an object to access/update the instance variable/non static in static method
            //Note : class should be same

            //created a object1
            Program obj1 = new Program();
            obj1.physicsMarks = 67;
            obj1.chemistryMarks = 60;
            obj1.mathsMarks = 59;
            
            //created an object2
            Program obj2 = new Program();
            obj2.physicsMarks = 59;
            obj2.chemistryMarks = 90;
            obj2.mathsMarks = 89;

            // displaying marks for object1
            Console.WriteLine("Marks for object 1: ");
            Console.WriteLine(obj1.physicsMarks);
            Console.WriteLine(obj1.chemistryMarks);
            Console.WriteLine(obj1.mathsMarks);
            //calling TotalNumber method for object 1
            obj1.TotalNumber();

            // displaying marks for object 2 & total marks
            Console.WriteLine("\nMarks for object 2: ");
            Console.WriteLine(obj1.physicsMarks);
            Console.WriteLine(obj1.chemistryMarks);
            Console.WriteLine(obj1.mathsMarks);
            //calling TotalNumber method for object 2
            obj2.TotalNumber();

        }
    }
}
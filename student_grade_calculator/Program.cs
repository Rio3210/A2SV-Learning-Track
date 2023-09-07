class Program{
    static void Main(string[] args){
        Console.WriteLine("Welcome to your grade calculator!");
        Console.WriteLine("Please enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Please enter the number of subjects you have taken: ");
        
        Dictionary<string, int> subjects = new Dictionary<string, int>();
        int num_subjects = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < num_subjects; i++){
            Console.WriteLine("Please enter the name of subject " + (i+1) + ": ");
            string? subject = Console.ReadLine();
            Console.WriteLine("Please enter the grade you obtained for " + subject + ": ");
            int grade = Convert.ToInt32(Console.ReadLine());
            subjects.Add(subject, grade);
        }
        
        int total = 0;
        foreach (KeyValuePair<string, int> subject in subjects){
            total += subject.Value;
        }
        int average = total / num_subjects;
        
        Console.WriteLine("Name: " + name);
        foreach (KeyValuePair<string, int> subject in subjects){
            Console.WriteLine(subject.Key + ": " + subject.Value);
        }
        Console.WriteLine("Average grade: " + average);

    }
}
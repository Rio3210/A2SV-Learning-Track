class Program{
    static void Main(string[] args){
        Console.WriteLine("Welcome to your grade calculator!");
        Console.WriteLine("Please enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Please enter the number of subjects you have taken: ");
        
        Dictionary<string, float> subjects = new Dictionary<string, float>();
        int num_subjects = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < num_subjects; i++){
            Console.WriteLine("Please enter the name of subject " + (i+1) + ": ");
            string? subject = Console.ReadLine();
            Console.WriteLine("Please enter the grade you obtained for " + subject + ": ");
            float grade = Convert.ToSingle(Console.ReadLine());
            if (grade >= 0 && grade <= 100){
                subjects.Add(subject, grade);
            } else {
                Console.WriteLine("Invalid grade entered. Please enter a grade between 0 and 100.");
                i--;
            }
            
        }
        
        float total = 0;
        foreach (KeyValuePair<string, float> subject in subjects){
            total += subject.Value;
        }
        float average = total / num_subjects;
        
        Console.WriteLine("Name: " + name);
        foreach (KeyValuePair<string, float> subject in subjects){
            Console.WriteLine(subject.Key + ": " + subject.Value);
        }
        Console.WriteLine("Average grade: " + average);

    }
}
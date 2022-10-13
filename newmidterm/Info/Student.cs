public class Student: Info{
    private int year;
    private string school;

    public Student(string prefix, string name, string surname, int age, string allergy, string religion, int year, string school)
    : base(prefix, name, surname, age, allergy, religion) {
        this.year = year;
        this.school = school;
    }
    
}
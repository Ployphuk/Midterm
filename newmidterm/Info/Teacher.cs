public class Teacher: Info{
    private string jobTitle;
    private string carinfo;
    private string cartag;

    public Teacher(string prefix, string name,string surname, int age, string allergy, string religion, string jobTitle, string carinfo, string cartag)
    : base(prefix, name, surname, age, allergy, religion) {
       this.jobTitle = jobTitle;
       this.carinfo = carinfo;
       this.cartag = cartag;
    }
    
}
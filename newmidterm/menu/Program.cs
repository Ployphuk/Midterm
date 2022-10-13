using System;
enum Menu{
    Register = 1 ,
    ShowStatic = 2 ,
    Login = 3 
}

enum Type{
    CurrentStudent = 1,
    Student = 2,
    Teacher = 3
}

class Program{
    static InfomationList infomationList;
    static AdminList adminList;

    static void Main(string[] args){
        PrepareInfoList();
        ClearMenu();
    }

    static void ClearMenu(){
        Console.Clear();

        PrintMenu();
        InputMenu();
    }
    static void PrintMenu(){
        Console.WriteLine("************");
        Console.WriteLine("Press 1 : Register");
        Console.WriteLine("Press 2 : Show statics");
        Console.WriteLine("Press 3 : Login");
        Console.WriteLine("*************");
    }

    static void InputMenu(){
        Console.Write("Enter your choice");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        ShowMenu(menu);
    }
    static void ShowMenu(Menu menu){
        switch(menu){
            case Menu.Register:
                 RegisterMenuScreen();
                break;
            case Menu.ShowStatic:
                ShowStaticMenu();
                break;
            case Menu.Login:
                ShowLoginMenu();
                break;
            default:
                break;
        }
    }

    static void ShowStaticMenu(){
        Console.WriteLine("Show Infomation");
        Console.WriteLine("**********");

        Program.infomationList.FetchInfoList();
    }

    static void ShowLoginMenu(){
        Console.Clear();

        Console.WriteLine("************");
        Console.WriteLine("Login Menu");
    }

    static void RegisterMenu(){
        Console.Clear();
        Console.WriteLine("******RegisterMenu******");
        Console.WriteLine("Press 1 : Current student");
        Console.WriteLine("Press 2 : Student");
        Console.WriteLine("Press 3 : Teacher");
    }
    static void InputRegisterType(){
        Console.Write("Enter your choice : ");
        Type type = (Type)(int.Parse(Console.ReadLine()));

        RegisterType(type);
    }

    static void RegisterType(Type type){
        switch(type){
            case Type.CurrentStudent:
                 CurrentStudentLogin();
                break;
            case Type.Student:
                NewStudentLogin();
                break;
            case Type.Teacher:
                TeacherLogin();
                break;
            default:
                break;
        }
    }
     static void RegisterMenuScreen(){
        RegisterMenu();
        InputRegisterType();
    }

////////Current Student//////////////
    static void CurrentStudentLogin(){

        Console.Clear();

        PrintCurrentStudentRegisterHead();

        int totalCurrentStudent = TotalPresentStudent();
        InputCurrentStudent(totalCurrentStudent);

    }

    static void PrintCurrentStudentRegisterHead(){
        Console.WriteLine("Register Current Student");
        Console.WriteLine("************************");
    }

    static int TotalPresentStudent(){
        Console.Write("Input Total Present Student : ");

        return int.Parse(Console.ReadLine());
    }
    static void InputCurrentStudent(int totalCurrentStudent){
        for(int i = 0; i < totalCurrentStudent; i++){
            Console.Clear();
            PrintCurrentStudentRegisterHead();

            CurrentUniStudent currentUniStudent = new CurrentUniStudent(InputPrefix(),
            InputName(),
            InputSurname(),
            InputAge(),
            InputAllergy(),
            InputReligion(),
            InputStudentID());

             Program.infomationList.AddNewInfo(currentUniStudent);
        }

       AddminCheck();
    }
/////////////Student///////////////
    static void NewStudentLogin(){
         Console.Clear();

        PrintStudentRegisterHead();

        int totalStudent = TotalStudent();
        InputStudent(totalStudent);
    }

    static void PrintStudentRegisterHead(){
        Console.WriteLine("Register Student");
        Console.WriteLine("****************");
    }

    static int TotalStudent(){
        Console.Write("Input Total Student :");

        return int.Parse(Console.ReadLine());
    }

     static void InputStudent(int totalStudent){
        for(int i = 0; i < totalStudent; i++){
            Console.Clear();
            PrintStudentRegisterHead();

            Student student = new Student(InputPrefix(),
            InputName(),
            InputSurname(),
            InputAge(),
            InputAllergy(),
            InputReligion(),
            InputYear(),
            InputSchool());

             Program.infomationList.AddNewInfo(student);
        }

       BackToStartMenu();
    }

    ////////////////Teacher/////////////////

      static void TeacherLogin(){
         Console.Clear();

        PrintTeacherRegisterHead();

        int totalTeacher = TotalTeacher();
        InputTeacher(totalTeacher);

      }

   

    static void PrintTeacherRegisterHead(){
        Console.WriteLine("Register Teacher");
        Console.WriteLine("**************");
    }

    static int TotalTeacher(){
        Console.Write("Input total Teacher :");

        return int.Parse(Console.ReadLine());
    }

    static void InputTeacher(int totalTeacher){
        for(int i = 0; i < totalTeacher; i++){
            Console.Clear();
            PrintTeacherRegisterHead();

            Teacher teacher = new Teacher(InputPrefix(),
            InputName(),
            InputSurname(),
            InputAge(),
            InputAllergy(),
            InputReligion(),
            InputJobtitle(),
            Inputcarinfo(),
            Inputcartag()
            );

             Program.infomationList.AddNewInfo(teacher);
        }

       BackToStartMenu();
    }

    

    static void PrepareInfoList(){
        Program.infomationList = new InfomationList();
    }

    static void BackToStartMenu(){
        Console.Clear();
        PrintMenu();
        InputMenu();
    }
/////////////////////////Addmin////////////////////////////////////////////
    static void AddminCheck(string InputCheck){
        if(InputCheck == "Y" && InputCheck == "y"){
            Addmin addmin = new Addmin(InputEmail(),
            InputPassword()
            );
             Program.adminList.AddNewAdmin(addmin);
        }else if(InputCheck == "N" && InputCheck =="n"){
             BackToStartMenu();
        }
    }

    static string InputCheck(){
        Console.Write("Type answer : ");
        return Console.ReadLine();
    }
    static string InputPrefix(){
        Console.Write("Prefix : ");
        return Console.ReadLine();
    }

    static string InputName(){
        Console.Write("Name : ");
        return Console.ReadLine();
    }

    static  long InputStudentID(){
        Console.Write("StudentID : ");

        return long.Parse(Console.ReadLine());
    }

    static int InputAge(){
        Console.Write("Age : ");

        return int.Parse(Console.ReadLine());
    }

    static string InputAllergy(){
        Console.Write("Allergy : ");

        return Console.ReadLine();
    }

    static string InputReligion(){
        Console.Write("Religion :");

        return Console.ReadLine();
    }

    static int InputYear(){
        Console.Write("Year : ");

        return int.Parse(Console.ReadLine());
    }
    static string InputSchool(){
        Console.Write("Input School : ");

        return Console.ReadLine();
    }

    static string InputJobtitle(){
        Console.Write("Title :");

        return Console.ReadLine();
    }

    static string Inputcarinfo(){
        Console.Write("Car info :");

        return Console.ReadLine();
    }

    static string Inputcartag(){
        Console.Write("Car tag : ");

        return Console.ReadLine();
    }

    static string InputSurname(){
        Console.Write("Surname : ");

        return Console.ReadLine();
    }

    static string InputEmail(){
        Console.Write("Email : ");

        return Console.ReadLine();
    }

    static string InputPassword(){
        Console.Write("Password : ");

        return Console.ReadLine();
    }

    


}



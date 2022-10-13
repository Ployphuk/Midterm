using System.Collections.Generic;
using System;

class Login{
    public void LoginScreen(){
        Console.Clear();
    }

    //public bool InputLogin(List<Info> infomationList){
        //string name = InputNameFromKeyboard();
        //string password = InputPasswordFromKeyboard();

        //foreach(Info info in infomationList) {
           // Console.WriteLine(info.GetUserName());
           // if (info.GetUserName() == name && user.GetPassword() == password) {
               // ShowMenuForUserWhenAuthenSuccess(user);

                //return true;
            //}
       // }

       // return false;
    //}

    public string InputNameFromKeyboard() {
        Console.Write("Input name: ");

        return Console.ReadLine();
    }

    public string InputPasswordFromKeyboard() {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private void PrintHeaderLoginScreen() {
        Console.WriteLine("Login Screen");
        Console.WriteLine("------------"); 
    }
}
using System.ComponentModel.Design;

namespace ConsoleApp7
{
    public class User
    {
        public string username;
        public string password;
        public bool loggedIn;

        public User(string username, string password) 
        {
         this.username = username;
         this.password = password;
         this.loggedIn = false;
        }
        public void Login(string enteredPassword)
        {
            if (!loggedIn)
            {
                if (enteredPassword == password)
                {
                    loggedIn = true;
                    Console.WriteLine($"{username} hesaba daxil oldu.");
                }
                else
                {
                    Console.WriteLine("Shifre yanlisdir. Hesaba daxil olunmadi");
                }
            }
            else
            {
                Console.WriteLine($"{username} onceden hesaba daxil olub.");
            }
                
            }
        public void Logout()
        {
            if (loggedIn)
            {
                loggedIn = false;
                Console.WriteLine($"{username} hesabdan cixis etdi.");
            }
            else
            {
                Console.WriteLine("istifadeci login olmayib");
            }
        }
        public static void Main(string[] args)
        { 
            User user1 = new User("user1", "parol123");

            user1.Login("parol123");  // Hesaba daxil oldu
            user1.Login("yanlisparol");  // Şifrə yanlışdır. Hesaba daxil olunmadı.
            user1.Logout();  // Hesabdan çıxış etdi
            user1.Logout();  // İstifadəçi login olmayıb.
        }
        
    }
}
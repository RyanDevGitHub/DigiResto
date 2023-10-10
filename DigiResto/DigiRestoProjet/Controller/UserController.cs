using DigiRestoProjet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DigiResto.Controller
{
    public class UserController
    {
        private static UserController? instance;
        private static User? iUserLogin;
        private static User? iUserUpdate;

        public static UserController Instance
        {
            get { if (instance == null) instance = new UserController(); { return instance; } }
            private set { instance = value; }
        }

        public static User UserLogin
        {
            get { if (iUserLogin == null) iUserLogin = new User(); { return iUserLogin; } }
            set { iUserLogin = value; }
        }

        public static User UserUpdate
        {
            get { if (iUserUpdate == null) iUserUpdate = new User(); { return iUserUpdate; } }
            set { iUserUpdate = value; }
        }

        private UserController() { }

        public List<User>? LoadUserList()
        {

            string fileName = "..\\..\\..\\Json\\User.json";
            string jsonString = File.ReadAllText(fileName);
            UserData userList = JsonSerializer.Deserialize<UserData>(jsonString)!;

            return userList.Users;
        }
        public bool SaveManage(string name)
        {
            string fileName = "..\\..\\..\\Json\\Manage.json";
            string jsonString = File.ReadAllText(fileName);
            User Manage = JsonSerializer.Deserialize<User>(jsonString)!;
            
            if(Manage != null)
            {
                Manage.Name = name;
            }
            else
            {
                Manage = new User();
                Manage.Name = name;
            }
            string newJson = JsonSerializer.Serialize(Manage);
            File.WriteAllText(fileName, newJson);
            return true;
        }
        public void ResetManage()
        {
            string fileName = "..\\..\\..\\Json\\Manage.json";
            string jsonString = File.ReadAllText(fileName);
            User Manage = JsonSerializer.Deserialize<User>(jsonString)!;
            if(Manage != null)
            {
                Manage.Name = null;
            }
            string newJson = JsonSerializer.Serialize(Manage);
            File.WriteAllText(fileName, newJson);
        }
        public string GetManageName()
        {
            string fileName = "..\\..\\..\\Json\\Manage.json";
            string jsonString = File.ReadAllText(fileName);
            User Manage = JsonSerializer.Deserialize<User>(jsonString)!;

            if(Manage != null)
            {
                return Manage.Name;
            }
            return null;
        }
    }
}

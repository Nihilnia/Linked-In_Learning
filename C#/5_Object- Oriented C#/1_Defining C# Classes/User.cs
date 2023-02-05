namespace Defining
{
    public class User
    {
        string _UserName;
        protected string _Password;
        bool _isActive;

        public User(string UserName, string Password, bool isActive)
        {
            _UserName = UserName;
            _Password = Password;
            _isActive = isActive;
        }

        public void Introduce()
        {
            System.Console.WriteLine($"Username: {_UserName}, Password: {_Password}, Active: {_isActive}");
        }

        public void changeActivity()
        {
            _isActive = !_isActive;
        }

        public void changeUserName(string newUserName)
        {
            System.Console.WriteLine(_UserName == newUserName ? "New User Name cannot be the same with old one." : "User Name changed.");
            _UserName = _UserName == newUserName ? _UserName : newUserName;
        }

        public void changePassword(string newPass)
        {
            System.Console.WriteLine(_Password == newPass ? "New password cannot be the same with old one." : "Password changed.");
            _Password = _Password == newPass ? _Password : newPass;

        }
    }
}
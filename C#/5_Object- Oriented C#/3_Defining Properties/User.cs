namespace Defining
{
    public class User
    {
        string _UserName;
        protected string _Password;
        bool _isActive;
        string _bio;

        public User(string UserName, string Password, bool isActive, string bio)
        {
            _UserName = UserName;
            _Password = Password;
            _isActive = isActive;
            _bio = bio;
        }

        //Props
        public string Name { get => _UserName; set => _UserName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public bool Activity { get => _isActive; set => _isActive = value; }
        public string Bio { get => _bio; set => _bio = value; }
        public string Introduce { get => $"Name: {_UserName} Pass: {_Password} Activity: {_isActive} Bio: {_bio}"; }

        public int LoneDigger { get; set; }

    }
}
namespace Defining
{
    public class BioMachine : User
    {
        public int _Age { get; set; }

        public BioMachine(int Age, string UserName, string Password, bool isActive, string bio) : base(UserName, Password, isActive, bio)
        {
            _Age = Age;
        }

        //Override
        public override string Introduce { get => $"Name: {_UserName} Age: {_Age} Pass: {_Password} Activity: {_isActive} Bio: {_bio}"; }
    }
}
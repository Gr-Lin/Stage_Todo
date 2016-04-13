namespace ModelViewTodo.Model
{
    public class User
    {
        public string Login { get; set; }
    
        public string Password { get; set; }

        public bool Remember { get; set; }

        public User()
        {
            Login = "";
            Password = "";
            Remember = false;
        }

        public User(string l, string p, bool r)
        {
            Login = l;
            Password = p;
            Remember = r;
        }
    }

}
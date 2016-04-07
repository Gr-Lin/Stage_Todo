namespace ModelView.Model
{
    public class Todo
    {
        private string _name;
        private string _des;

        public Todo(string n)
        {
            _name = n;
            _des = "";
        }

        public Todo (string n, string d)
        {
            _name = n;
            _des = d;
        }

        public string Name {
            get { return _name;}
            set { _name = value;} 
        }

        public string Description
        {
            get { return _des; }
            set { _des = value; }
        }

       public override string ToString()
        {
            return Name + ":" + Description;
        }
    }
}

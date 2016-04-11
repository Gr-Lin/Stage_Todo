namespace ModelViewTodo.Model
{
    public class Todo
    {
        private string _name;
        private string _des;
        private int _index;

        public Todo()
        {
            _name = "";
            _des = "";
            _index = 0;
        }

        public Todo(string n, string d, int i)
        {
            _name = n;
            _des = d;
            _index = i;
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

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

       public override string ToString()
        {
            return Name + ":" + Description;
        }
    }
}

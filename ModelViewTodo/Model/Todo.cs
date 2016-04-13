namespace ModelViewTodo.Model
{
    public class Todo
    {
        public Todo()
        {
            Name = "";
            Description = "";
            Index = 0;
        }

        public Todo(string n, string d)
        {
            Name = n;
            Description = d;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Index { get; set; }

        public override string ToString()
        {
            return Name + ":" + Description;
        }
    }
}

using Newtonsoft.Json;

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
        [JsonProperty("title")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Index { get; set; }

        public override string ToString()
        {
            return Name + ":" + Description;
        }
    }
}

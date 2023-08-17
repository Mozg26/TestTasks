namespace TestTasks.Models
{
    public class Element
    {
        private int _id;
        private int _data;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
        public int data
        {
            get => _data;
            set
            {
                _data = value;
            }
        }
        public Element()
        {
            Id = 0;
            data = 0;
        }
    }
}
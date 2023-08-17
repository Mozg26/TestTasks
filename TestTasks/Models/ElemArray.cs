namespace TestTasks.Models
{
    public class ElemArray
    {
        private Element[] elements;

        public ElemArray()
        {
            elements = new Element[1];
            elements[0] = new Element();
        }

        private void AddId()
        {
            int id = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i].Id = id;
                id++;
            }
        }

        public void AddElement()
        {
            Element[] temp_array = new Element[elements.Length + 1];
            temp_array[elements.Length] = new Element();
            for (int i = 0; i < elements.Length; i++)
                temp_array[i] = elements[i];
            elements = temp_array;
            elements[elements.Length - 1].Id = elements.Length - 1;
        }

        public void DeleteElement(int id)
        {
            Element[] temp = new Element[elements.Length - 1];

            for (int i = 0; i < elements.Length - 1; i++)
            {
                temp[i] = new Element();
            }

            for (int i = 0; i < id; i++)
            {
                temp[i].data = elements[i].data;
            }

            for (int i = id + 1, j = id; i < elements.Length; i++, j++)
            {
                temp[j].data = elements[i].data;
            }

            elements = temp;
            AddId();
        }

        public int GetLength()
        {
            return elements.Length;
        }

        public int GetElement(int i)
        {
            return elements[i].data;
        }
        public Element[] GetArray()
        {
            return elements;
        }

        public string GetArrayString()
        {
            string str = string.Empty;

            for (int i = 0; i < elements.Length; i++)
                str += elements[i].data.ToString() + ' ';

            return str;
        }
    }
}


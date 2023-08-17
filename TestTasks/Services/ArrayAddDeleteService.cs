using TestTasks.Models;

namespace TestTasks.Services
{
    public class ArrayAddDeleteService
    {
        private ElemArray elemArray;

        public ArrayAddDeleteService()
        {
            elemArray = new ElemArray();
        }

        public void addElement()
        {
            elemArray.AddElement();
        }

        public void deleteElement(int id)
        {
            elemArray.DeleteElement(id);
        }

        public ElemArray getElemArray()
        {
            return elemArray;
        }

    }
}


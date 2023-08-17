using TestTasks.Models;

namespace TestTasks.Services
{
    public class ListAddDeleteService
    {
        private List list;

        public ListAddDeleteService() 
        {
            list = new List();
        }

        public void AddNode()
        {
            list.AddElement();
        }

        public Node GetHead()
        {
            return list.head;
        }

        public List GetList()
        {
            return list;
        }

        public int GetCount()
        {
            return list.GetCount();
        }

        public void DeleteNode(int Id)
        {
            list.DeleteElementById(Id);
        }
    }
}

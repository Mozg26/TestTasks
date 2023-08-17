using TestTasks.Models;

namespace TestTasks.Services
{
    public class SortListService
    {
        public void SortList(List list)
        {
            for (int i = 0; i < list.GetCount(); i++)
            {
                for (int j = i + 1; j < list.GetCount(); j++)
                {
                    if (list.GetValueById(i) > list.GetValueById(j))
                    {
                        list.SwapNodes(list.GetNodeById(i), list.GetNodeById(j));
                    }
                }
            }
        }
    }
}

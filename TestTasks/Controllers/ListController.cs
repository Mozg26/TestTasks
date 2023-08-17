using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using TestTasks.Models;
using TestTasks.Services;

namespace TestTasks.Controllers
{
    public class ListController
    { 
        public void AddInList([FromServices] ListAddDeleteService listAddDeleteService)
        {
            listAddDeleteService.AddNode();
        }

        public List GetList([FromServices] ListAddDeleteService listAddDeleteService)
        {
            return listAddDeleteService.GetList();
        }

        public string ViewList([FromServices] ListAddDeleteService listAddDeleteService)
        {
            return listAddDeleteService.GetList().ListToString();
        }

        public void SortList([FromServices] ListAddDeleteService listAddDeleteService, [FromServices] SortListService sortListService)
        { 
            sortListService.SortList(listAddDeleteService.GetList());
        }

        public int GetCount([FromServices] ListAddDeleteService listAddDeleteService)
        {
            return listAddDeleteService.GetCount();
        }

        public void DeleteNode([FromServices] ListAddDeleteService listAddDeleteService, int Id)
        {
            listAddDeleteService.DeleteNode(Id);
        }
        
    }
}

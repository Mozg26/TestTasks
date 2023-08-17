using Microsoft.AspNetCore.Mvc;
using TestTasks.Models;
using TestTasks.Services;

namespace TestTasks.Controllers
{
    public class ArrayController
    {
        public int arraySum([FromServices] ArrayProcessingService arrayProcessingService, [FromServices] ArrayAddDeleteService addDeleteService)
        {

            return arrayProcessingService.moduloSumEverySecondOddNumber(addDeleteService.getElemArray());
        }

        public void addInArray([FromServices] ArrayAddDeleteService addDeleteService)
        {
            addDeleteService.addElement();
        }

        public void deleteFromArray([FromServices] ArrayAddDeleteService addDeleteService, int id)
        {
            addDeleteService.deleteElement(id);
        }

        public string viewArray([FromServices] ArrayProcessingService arrayProcessingService, [FromServices] ArrayAddDeleteService addDeleteService)
        {
            return arrayProcessingService.getArrayString(addDeleteService.getElemArray());
        }

        public Element[] getArray([FromServices] ArrayAddDeleteService addDeleteService)
        {
            return addDeleteService.getElemArray().GetArray();
        }
    }
}


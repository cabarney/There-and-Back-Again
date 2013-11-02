namespace Todo.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Breeze.WebApi;
    using Breeze.WebApi.EF;
    using Models;
    using Newtonsoft.Json.Linq;

    [BreezeController]
    public class TodosController : ApiController
    {
        private readonly EFContextProvider<TodosContext> _contextProvider =
            new EFContextProvider<TodosContext>();

        // ~/breeze/todos/Metadata 
        [HttpGet]
        public string Metadata()
        {
            return _contextProvider.Metadata();
        }

        // ~/breeze/todos/Todos
        // ~/breeze/todos/Todos?$filter=IsArchived eq false&$orderby=CreatedAt 
        [HttpGet]
        public IQueryable<TodoItem> Todos()
        {
            return _contextProvider.Context.Todos;
        }

        // ~/breeze/todos/SaveChanges
        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }

        // ~/breeze/todos/purge
        [HttpPost]
        public string Purge()
        {
            TodoDatabaseInitializer.PurgeDatabase(_contextProvider.Context);
            return "purged";
        }

        // ~/breeze/todos/reset
        [HttpPost]
        public string Reset()
        {
            Purge();
            TodoDatabaseInitializer.SeedDatabase(_contextProvider.Context);
            return "reset";
        }
    }
}
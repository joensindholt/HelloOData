using System.Linq;
using System.Web.OData;
using HelloOData.Models;

namespace HelloOData.Controllers
{
    public class PeopleController : ODataController
    {
        DatabaseContext db = new DatabaseContext();

        [EnableQuery]
        public IQueryable<Person> Get()
        {
            return db.People;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}

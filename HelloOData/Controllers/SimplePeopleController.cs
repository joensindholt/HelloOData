using System.Linq;
using System.Web.OData;
using HelloOData.Projections;

namespace HelloOData.Controllers
{
    public class SimplePeopleController : ODataController
    {
        DatabaseContext db = new DatabaseContext();

        [EnableQuery]
        public IQueryable<SimplePerson> Get()
        {
            return db.People.Select(p => new SimplePerson
            {
                Id = p.Id,
                Name = p.Name,
                BestFriendName = p.BestFriend != null ? p.BestFriend.Name : null
            });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}

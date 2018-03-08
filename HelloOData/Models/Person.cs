using System.Collections.Generic;

namespace HelloOData.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Person BestFriend { get; set; }

        public virtual ICollection<Person> Friends { get; set; }
    }
}

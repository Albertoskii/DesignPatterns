using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Relationships : IRelationshipBrowser // low-level
    {
        // no longer public!
        private List<(Person, Relationship, Person)> relations
          = new List<(Person, Relationship, Person)>();

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
              .Where(x => x.Item1.Name == name
                       && x.Item2 == Relationship.Parent)
              .Select(r => r.Item3);
        }
    }
}

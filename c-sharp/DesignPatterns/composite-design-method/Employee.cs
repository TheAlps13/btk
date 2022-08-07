using System;
using System.Collections;
using System.Collections.Generic;

namespace composite_design_method
{
    public class Employee : IPerson, IEnumerable<IPerson>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }
        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (IPerson subordinate in _subordinates)
                yield return subordinate;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

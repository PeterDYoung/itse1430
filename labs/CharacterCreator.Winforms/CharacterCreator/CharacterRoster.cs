using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class CharacterRoster : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            if (character==null)
            {
                throw new ArgumentNullException();
            }
            

        }
        public Character Get ( int id ) => throw new NotImplementedException ();
        public IEnumerable<Character> GetAll () => throw new NotImplementedException ();
        public void Remove ( int id ) => throw new NotImplementedException ();
        public void Update ( int id, Character character ) => throw new NotImplementedException ();
    }
}

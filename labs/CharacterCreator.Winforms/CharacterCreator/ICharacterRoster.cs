using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    interface ICharacterRoster
    {
        /// <exception cref="ArgumentNullException"><paramref name="character"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="character"/> is not unique.</exception>
        ///// <exception cref="ValidationException"><paramref name="character"/> is invalid.</exception>
        Character Add ( Character character );

        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to zero.</exception>
        Character Get ( int id );

        IEnumerable<Character> GetAll ();

        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to zero.</exception>
        void Remove ( int id );

        /// <exception cref="ArgumentNullException"><paramref name="character"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="id"/> is less than or equal to zero.</exception>
        /// <exception cref="ArgumentException"><paramref name="character"/> is not unique.</exception>
        /// <exception cref="ValidationException"><paramref name="character"/> is invalid.</exception>
        void Update ( int id, Character character );

    }
}

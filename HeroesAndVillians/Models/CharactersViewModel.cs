using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroesAndVillians.Models
{
    public class CharactersViewModel
    {
        //Using IEnumerable as view models do not require the functionality
        //of the List collection type and allows for other collection types
        private List<Characters> _characters;

        //default constructor
        public CharactersViewModel(List<Characters> characters)
        {

            _characters = characters;
        }

        public bool FavsChecked { get; set; }

        public List<Characters> Characters
        {
            get
            {
                return _characters.ToList();
            }
        }


    }
}
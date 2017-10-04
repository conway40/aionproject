using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Traveler : Character
    {
        #region ENUMERABLES
        public enum SkinTone
        {
            None,
            White,
            Brown,
            Purple,
            Red,
            Green,
            Gray
        }

        #endregion

        #region FIELDS

        private string _homePlanet;

        private bool _isLiving;

        private SkinTone _skin;

        #endregion


        #region PROPERTIES

        public string HomePlanet
        {
            get { return _homePlanet; }
            set { _homePlanet = value; }
        }

        public bool IsLiving
        {
            get { return _isLiving; }
            set { _isLiving = value; }
        }

        public SkinTone Skin
        {
            get { return _skin; }
            set { _skin = value; }
        }


        #endregion


        #region CONSTRUCTORS

        public Traveler()
        {

        }

        public Traveler(string name, RaceType race, int spaceTimeLocationID) : base(name, race, spaceTimeLocationID)
        {

        }

        #endregion


        #region METHODS
        public override string Greeting()
        {
            return $"Hello, my name is {base.Name}, I am a {base.Race}, and I am from {_homePlanet}.";
        }

        public override string Catchphrase()
        {
            return $"Eat my shorts!";
        }

        #endregion
    }
}

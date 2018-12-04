using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    class FavoriteGames
    {
        public enum GameCriticReception
        {
            good,
            average,
            bad,

        }







        #region FIELDS 
        private string _gameName;
        private double _gameReleaseYear;
        private string _developer;
        private GameCriticReception _gameCriticReception;
        private double _personalRating;

        











        #endregion

        #region PROPERTIES

        public string GameName
        {
            get { return _gameName; }
            set { _gameName = value; }
        }

        public double GameReleaseYear
        {
            get { return _gameReleaseYear; }
            set { _gameReleaseYear = value; }
        }

        public string Developer
        {
            get { return _developer; }
            set { _developer = value; }
        }

        public GameCriticReception CriticReception
        {
            get { return _gameCriticReception; }
            set { _gameCriticReception = value; }
        }

        public double PersonalRating
        {
            get { return _personalRating; }
            set { _personalRating = value; }
        }
        #endregion

        #region METHODS

        public string FavoriteGameReception()
        {
            return _gameName + "is" + _gameCriticReception + ".";
           
        }
        #endregion





    }
}

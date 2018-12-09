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

            masterpiece,
            good,
            average,
            bad,

        }







        #region FIELDS 
        private string _gameName;
        private int _gameReleaseYear;
        private string _developer;
        private string _publisher;
        private bool _multiplayer;
        private string _memories;
        private GameCriticReception _gameCriticReception;
        private int _personalRating;
        

        











        #endregion

        #region PROPERTIES

        public string GameName
        {
            get { return _gameName; }
            set { _gameName = value; }
        }

        public int GameReleaseYear
        {
            get { return _gameReleaseYear; }
            set { _gameReleaseYear = value; }
        }

        public string Developer
        {
            get { return _developer; }
            set { _developer = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public bool Multiplayer
        {
            get { return _multiplayer; }
            set { _multiplayer = value; }
        }

        public GameCriticReception CriticReception
        {
            get { return _gameCriticReception; }
            set { _gameCriticReception = value; }
        }

        public int PersonalRating
        {
            get { return _personalRating; }
            set { _personalRating = value; }
        }

        public string Memories
        {
            get { return _memories; }
            set { _memories = value; }
        }
        #endregion

        #region METHODS

        public string FavoriteGameReception()
        {
            return _gameName + ".";
           
        }
        #endregion





    }
}

using Engine.Models;

namespace Engine.ViewModels
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Models.Player();
            CurrentPlayer.Name = "Jeff";
            CurrentPlayer.Gold = 1000000;
        }
    }
}

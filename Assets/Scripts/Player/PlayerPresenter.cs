using Management;

namespace Game.Player
{
    public class PlayerPresenter
    {
        private PlayerModel _playerModel;
        private IPlayerView _playerView;

        public PlayerPresenter()
        {
            _playerModel = PlayerManager.GetPlayerModel();
            _playerView = PlayerManager.GetPlayerView();
        }
    }
}
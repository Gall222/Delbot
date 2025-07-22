using UnityEngine;
using Game.Player;

namespace Management
{
    public class PlayerManager 
    {
        private static IPlayerView _playerView;
        private static PlayerModel _playerModel;
        private static PlayerPresenter _playerPresenter;
        
        public static IPlayerView GetPlayerView()
        {
            if (_playerView == null)
            {
                var prefab = Resources.Load<PlayerView>(nameof(PlayerView));
                _playerView = Object.Instantiate<PlayerView>(prefab, Vector3.zero, Quaternion.identity);
            }

            return _playerView;
        }

        public static PlayerModel GetPlayerModel()
        {
            if (_playerModel == null)
            {
                _playerModel = new PlayerModel();
            }

            return _playerModel;
        }

        public static PlayerPresenter GetPlayerPresenter()
        {
            if (_playerPresenter == null)
            {
                _playerPresenter = new PlayerPresenter();
            }

            return _playerPresenter;
        }
    }
}
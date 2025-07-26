using System;
using Management;
using UI;

namespace Player
{
    public class PlayerPresenter
    {
        private PlayerModel _playerModel;
        private IPlayerView _playerView;
        private IButton _jumpButton;

        public PlayerPresenter()
        {
            _playerModel = PlayerManager.GetPlayerModel();
            _playerView = PlayerManager.GetPlayerView();
        }

        public void Initiate(CanvasHandler canvasHandler,  SceneData sceneData)
        {
            _jumpButton = canvasHandler.jumpButton;
            _jumpButton.Clicked += OnJumpButtonClicked;
            
            _playerView.Transform.position = sceneData.playerSpawnPoint.transform.position;
            sceneData.playerCamera.Follow = _playerView.Transform;
        }
        
        private void OnJumpButtonClicked(object sender, EventArgs e)
        {
            _playerModel.Jump(); // вызов метода прыжка у модели
        }
    }
}
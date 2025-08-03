using UI;
using UnityEngine;

namespace Management
{
    public class Starter : MonoBehaviour
    {
        public CanvasHandler canvasHandler;
        public SceneData sceneData;
        
        private void Awake()
        {
            CreatePlayerPresenter();
            
            var joystickPresenter = JoystickManager.GetPlayerPresenter();
        }

        private void CreatePlayerPresenter()
        {
            SceneManager.Initiate(canvasHandler, sceneData);
            
            var playerPresenter = PlayerManager.GetPlayerPresenter();
            playerPresenter.Initiate(canvasHandler, sceneData);
        }
    }
}
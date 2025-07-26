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
        }

        private void CreatePlayerPresenter()
        {
            var playerPresenter = PlayerManager.GetPlayerPresenter();
            playerPresenter.Initiate(canvasHandler, sceneData);
        }
    }
}
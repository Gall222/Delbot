using UnityEngine;
using Game.Player;

namespace Management
{
    public class Starter : MonoBehaviour
    {
        private void Awake()
        {
            CreatePlayerPresenter();
        }

        private void CreatePlayerPresenter()
        {
            var playerPresenter = PlayerManager.GetPlayerPresenter();
        }
    }
}
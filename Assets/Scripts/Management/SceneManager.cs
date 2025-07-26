using Player;
using UI;
using UnityEngine;

namespace Management
{
    public class SceneManager 
    {
        private static IButton _jumpButton;
        
        public static IButton GetJumpButton()
        {
            if (_jumpButton == null)
            {
                //var prefab = Resources.Load<PlayerView>(nameof(PlayerView));
            }

            return _jumpButton;
        }
    }
}

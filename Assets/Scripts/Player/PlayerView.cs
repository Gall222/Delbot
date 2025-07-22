using UnityEngine;
using Game;

namespace Game.Player
{
    public interface IPlayerView : IView
    {
        
    }
    
    public class PlayerView : MonoBehaviour, IPlayerView
    {
        public void Enable()
        {
            gameObject.SetActive(true);
        }
    
        public void Disable()
        {
            gameObject.SetActive(false);
        }
    }
}


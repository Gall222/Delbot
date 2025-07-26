using UnityEngine;

namespace Player
{
    public class PlayerView : MonoBehaviour, IPlayerView
    {
        public Transform Transform => transform;
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


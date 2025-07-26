using UnityEngine;

namespace Player
{
    public interface IPlayerView : IView
    {
        public Transform Transform { get; }
    }
}

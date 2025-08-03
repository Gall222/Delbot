using UnityEngine;
using UI.Buttons;
using UnityEngine.Serialization;

namespace UI
{
    public class CanvasHandler : MonoBehaviour
    {
        [FormerlySerializedAs("jumpButton")] [SerializeField]
        public Jump jump;
    }
}


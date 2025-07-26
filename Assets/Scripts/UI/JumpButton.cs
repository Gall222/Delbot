using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class JumpButton : MonoBehaviour, IButton, IPointerClickHandler
    {
        public event EventHandler Clicked;
        
        public void Enable()
        {
            gameObject.SetActive(true);
        }
    
        public void Disable()
        {
            gameObject.SetActive(false);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Clicked(this, EventArgs.Empty);
        }
    }
}

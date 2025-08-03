using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Buttons
{
    public class Jump : MonoBehaviour, IButton, IPointerClickHandler
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

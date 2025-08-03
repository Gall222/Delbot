using UnityEngine;

namespace UI.Joystick
{
    public class View : MonoBehaviour
    {
        private Transform _joystickBack;
        private Transform _joystickInner;

        public void Awake()
        {
            _joystickBack = GetComponent<Transform>();
            _joystickInner = transform.GetChild(0);
        }
        
        public void SetBackPosition(Vector2 position)
        {
            _joystickBack.position = position;
        }
        
        public void SetInnerPosition(Vector2 position)
        {
            _joystickInner.position = position;
        }

        public void ChangeActivity(bool visible)
        {
            _joystickBack.gameObject.SetActive(visible);
            _joystickInner.gameObject.SetActive(visible);
        }
    }
}
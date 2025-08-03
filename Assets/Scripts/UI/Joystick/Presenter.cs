using Management;
using UnityEngine;

namespace UI.Joystick
{
    public class Presenter
    {
        private Model _model;
        private View _view;
        private float _joystickRadius = 1f;
        private Vector2 _startPosition; 
        
        public Presenter()
        {
            _view = JoystickManager.GetView();
            _model = JoystickManager.GetModel();
            
            _model.OnPointerPress += OnPointerPress;
            _model.OnPointerMove += OnPointerMove;
            _model.OnPointerRelease += OnPointerRelease;
            
            _joystickRadius = _view.GetComponent<RectTransform>().rect.height / 4;
            _view.ChangeActivity(false);
        }
        
        private void OnPointerPress(Vector2 position)
        {
            _startPosition = position;
                        
            _view.SetBackPosition(_startPosition);
            _view.SetInnerPosition(_startPosition);
            _view.ChangeActivity(true);
        }

        private void OnPointerMove(Vector2 position)
        {
            if (_view.isActiveAndEnabled == false)
            {
                return;
            }
            
            Vector2 direction = position - _startPosition;
            if (direction.magnitude > _joystickRadius)
            {
                direction = direction.normalized * _joystickRadius;
            }
            
            Vector2 innerPosition = _startPosition + direction;

            _view.SetInnerPosition(innerPosition);
        }
        
        private void OnPointerRelease()
        {
            _view.ChangeActivity(false);
        }
    }
}
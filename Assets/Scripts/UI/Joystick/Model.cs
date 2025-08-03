using UnityEngine;
using PlayerInput = Management.PlayerInput;

namespace UI.Joystick
{
    public class Model
    {
        public delegate void PointerPressEvent(Vector2 position);
        public delegate void PointerEvent(Vector2 position);
        public delegate void PointerEventVoid();

        public event PointerPressEvent OnPointerPress;
        public event PointerEvent OnPointerMove;
        public event PointerEventVoid OnPointerRelease;
        
        public Model(PlayerInput playerInput)
        {
            playerInput.Joystick.Press.performed += ctx =>
            {
                Vector2 position = playerInput.Joystick.Move.ReadValue<Vector2>();
                OnPointerPress?.Invoke(position);
            };
            playerInput.Joystick.Move.performed += ctx => OnPointerMove?.Invoke(ctx.ReadValue<Vector2>());
            playerInput.Joystick.Press.canceled += ctx => OnPointerRelease?.Invoke();
        }
    }
}
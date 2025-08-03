
using UnityEngine;

namespace Management
{
    public class PlayerInputSystem
    {
        private static PlayerInput _playerInput;
        
        public static PlayerInput GetPlayerInput()
        {
            _playerInput ??= new PlayerInput();
            _playerInput.Enable();
            
            return _playerInput;
        }
    }
}
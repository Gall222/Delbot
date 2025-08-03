using UI.Joystick;
using UnityEngine;

namespace Management
{
    public class JoystickManager
    {
        private static Model _model;
        private static View _view;
        private static Presenter _presenter;
        
        public static View GetView()
        {
            if (_view == null)
            {
                var prefab = Resources.Load<View>("Prefabs/Joystick");
                _view = Object.Instantiate(prefab, Vector3.zero, Quaternion.identity);
                _view.transform.SetParent(GameObject.Find("Canvas").transform);
            }

            return _view;
        }
        
        public static Model GetModel()
        {
            return _model ?? (_model = new Model(PlayerInputSystem.GetPlayerInput()));
        }
        
        public static Presenter GetPlayerPresenter()
        {
            if (_presenter == null)
            {
                _presenter = new Presenter();
            }

            return _presenter;
        }
    }
}
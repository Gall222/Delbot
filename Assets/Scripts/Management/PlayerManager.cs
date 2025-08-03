using Data;
using UnityEngine;
using Player;
using Unity.VisualScripting;
using CargoView = Player.Cargo.View;

namespace Management
{
    public class PlayerManager 
    {
        private static IPlayerView _playerView;
        private static Model _model;
        private static Presenter _presenter;
        private static CargoView _activeCargo;
        
        public static IPlayerView GetPlayerView()
        {
            if (_playerView != null) return _playerView;
            
            var prefab = Resources.Load<View>("Prefabs/Player");
            if (prefab == null)
            {
                Debug.LogError("Player prefab not loaded");
            }
            _playerView = Object.Instantiate(prefab, Vector3.zero, Quaternion.identity);

            return _playerView;
        }

        public static Model GetPlayerModel()
        {
            if (_model == null)
            {
                _model = new Model();
            }

            return _model;
        }

        public static Presenter GetPlayerPresenter()
        {
            if (_presenter == null)
            {
                _presenter = new Presenter();
            }

            return _presenter;
        }

        public static CargoView GetActiveCargo()
        {
            if (_activeCargo != null) return _activeCargo;
            
            var cargoData = Resources.Load<Cargo>("StaticData/Cargo");
            if (cargoData != null && cargoData.сargoList != null && cargoData.сargoList.Length > 0)
            {
                var prefab = cargoData.сargoList[0];
                var playerView = GetPlayerView();
                Transform cargoDownPositionTransform = playerView.CargoDownPosition;

                if (cargoDownPositionTransform == null)
                {
                    Debug.LogError("Cargo down position not found");
                }
                else
                {
                    _activeCargo = Object.Instantiate(prefab, cargoDownPositionTransform.position, Quaternion.identity);
                }
            }
            else
            {
                Debug.LogError("Cargo data error");
            }

            return _activeCargo;
        }
    }
}
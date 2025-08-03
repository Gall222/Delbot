using System;
using Management;
using UI;
using Unity.VisualScripting;
using UnityEngine;
using CargoView = Player.Cargo.View;

namespace Player
{
    public class Presenter
    {
        private Model _model;
        private IPlayerView _playerView;
        private IButton _jumpButton;
        private CargoView _activeCargo;
        private MuscleController _muscleController = new MuscleController();

        public Presenter()
        {
            _model = PlayerManager.GetPlayerModel();
            _playerView = PlayerManager.GetPlayerView();
        }

        public void Initiate(CanvasHandler canvasHandler,  SceneData sceneData)
        {
            _jumpButton = canvasHandler.jump;
            _jumpButton.Clicked += OnJumpButtonClicked;
            
            _playerView.Transform.position = sceneData.playerSpawnPoint.transform.position;
            sceneData.playerCamera.Follow = _playerView.Transform;
            
            _playerView.FixedUpdateEvent += OnFixedUpdate;

            CollectBonesAndCreateMuscles();
            //CreateCargo();
        }
        
        public void CollectBonesAndCreateMuscles()
        {
            foreach (var bone in _playerView.Bones)
            {
                var rb = bone.GetComponent<Rigidbody2D>();
                var joint = bone.GetComponent<HingeJoint2D>();
                if (joint != null)
                {
                    float restAngle = bone.transform.localRotation.eulerAngles.z;
                    _muscleController.AddMuscle(rb, joint, restAngle, springStrength: 50f, damping: 5f);
                }
            }
        }
        
        private void OnFixedUpdate()
        {
            _muscleController.UpdateMuscles();
        }
        
        private void CreateCargo()
        {
            _activeCargo = PlayerManager.GetActiveCargo();
            _activeCargo.transform.SetParent(_playerView.Transform);
            _activeCargo.leftFootMover.legTarget = _playerView.LeftLegTarget.transform;
            _activeCargo.rightFootMover.legTarget = _playerView.RightLegTarget.transform;
            
            _playerView.LeftHandLimb.GetChain(0).target =  _activeCargo.leftHandTarget;
            _playerView.RightHandLimb.GetChain(0).target =  _activeCargo.rightHandTarget;
            _playerView.BodyLimb.GetChain(0).target =  _activeCargo.rightHandTarget;
        }
        
        private void OnJumpButtonClicked(object sender, EventArgs e)
        {
            _model.Jump(); // вызов метода прыжка у модели
        }
        
        private void OnJoystickMove(object sender, EventArgs e)
        {
            _model.Move();
        }
    }
}
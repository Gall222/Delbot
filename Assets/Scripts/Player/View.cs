using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.U2D.IK;

namespace Player
{
    public class View : MonoBehaviour, IPlayerView
    {
        [Header("Cargo")]
        [SerializeField] private Transform cargoDownPosition;
        [Header("Limbs in cargo influence")]
        [SerializeField] private LimbSolver2D leftHandLimb;
        [SerializeField] private LimbSolver2D rightHandLimb;
        [SerializeField] private CCDSolver2D bodyLimb;
        [Header("Foot move targets")]
        [SerializeField] private Transform leftLegTarget;
        [SerializeField] private Transform rightLegTarget;
        [Header("Bones with muscles")]
        [SerializeField] private List<GameObject> bones;

        public Transform Transform => transform;
        public Transform CargoDownPosition => cargoDownPosition;
        public LimbSolver2D LeftHandLimb => leftHandLimb;
        public LimbSolver2D RightHandLimb => rightHandLimb;
        public CCDSolver2D BodyLimb => bodyLimb;
        public Transform LeftLegTarget => leftLegTarget;
        public Transform RightLegTarget => rightLegTarget;
        public List<GameObject> Bones=> bones;
        
        public event Action FixedUpdateEvent;
        
        public void Enable()
        {
            gameObject.SetActive(true);
        }
        
        public void Disable()
        {
            gameObject.SetActive(false);
        }

        public void FixedUpdate()
        {
            FixedUpdateEvent?.Invoke();
        }
    }
}

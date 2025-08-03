using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;

namespace Player
{
    public interface IPlayerView : IView
    {
        public Transform Transform { get; }
        public Transform CargoDownPosition { get; }
        public LimbSolver2D LeftHandLimb { get; }
        public LimbSolver2D RightHandLimb { get; }
        public CCDSolver2D BodyLimb { get; }
        public Transform LeftLegTarget { get; }
        public Transform RightLegTarget { get; }
        public List<GameObject> Bones { get; }
        
        public event Action FixedUpdateEvent;
    }
}

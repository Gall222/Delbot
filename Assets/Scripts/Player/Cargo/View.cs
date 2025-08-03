using System;
using UnityEngine;

namespace Player.Cargo
{
    [Serializable]
    public class View: MonoBehaviour
    {
        public LegMover leftFootMover;
        public LegMover rightFootMover;
        public Transform leftHandTarget;
        public Transform rightHandTarget;
    }
}
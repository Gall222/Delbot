using UnityEngine;
using System.Collections.Generic;

namespace Player
{
    public class MuscleController
    {
        private struct Muscle
        {
            public Rigidbody2D rb;
            public HingeJoint2D joint;
            public float restAngle;
            public float springStrength;
            public float damping;
        }

        private List<Muscle> _muscles = new List<Muscle>();

        public void AddMuscle(Rigidbody2D rb, HingeJoint2D joint, float restAngle, float springStrength = 100f, float damping = 50f)
        {
            _muscles.Add(new Muscle
            {
                rb = rb,
                joint = joint,
                restAngle = restAngle,
                springStrength = springStrength,
                damping = damping
            });
        }

        public void UpdateMuscles()
        {
            foreach (var muscle in _muscles)
            {
                float currentAngle = muscle.rb.transform.localEulerAngles.z;
                if (currentAngle > 180) currentAngle -= 360f;
                float angleDiff = Mathf.DeltaAngle(currentAngle, muscle.restAngle);
                float torque = angleDiff * muscle.springStrength - muscle.rb.angularVelocity * muscle.damping;
                muscle.rb.AddTorque(torque);
            }
        }
    }
}
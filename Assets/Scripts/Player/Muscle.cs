using System;
using UnityEngine;

namespace Player
{
    public class Muscle : MonoBehaviour
    {
        public float restAngle = 0f;
        public float springStrength = 50f;
        public float damping = 5f;
        private Rigidbody2D rb;
        private HingeJoint2D joint;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            joint = GetComponent<HingeJoint2D>();
            restAngle = transform.localRotation.eulerAngles.z;
        }

        void FixedUpdate()
        {
            float currentAngle = transform.localEulerAngles.z;
            if (currentAngle > 180) currentAngle -= 360; // для Signed angle

            float angleDiff = Mathf.DeltaAngle(currentAngle, restAngle);
            float torque = angleDiff * springStrength - rb.angularVelocity * damping;
            rb.AddTorque(torque);
        }
    }
}
using UnityEngine;

namespace Player
{
    public class BodyMover: MonoBehaviour
    {
        public Rigidbody2D body;
        public Transform cargo;
        public float pullForce = 10f;

        void FixedUpdate()
        {
            if (cargo)
            {
                Vector2 direction = (cargo.position - body.transform.position).normalized;
                body.AddForce(direction * pullForce, ForceMode2D.Force);
            }
        }
    }
}
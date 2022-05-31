using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour, ICharacterController
    {
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody2D _rigidbody;

        public GameObject GetCharacter() => gameObject;

        private void FixedUpdate()
        {
            HandleInputs();
        }

        private void HandleInputs()
        {
            var finalVel = Vector2.zero;
        
            if(Input.GetKeyDown(KeyCode.LeftArrow))
                finalVel+=Vector2.left;
            if(Input.GetKeyDown(KeyCode.RightArrow))
                finalVel+=Vector2.right;
            if(Input.GetKeyDown(KeyCode.UpArrow))
                finalVel+=Vector2.up;
            if(Input.GetKeyDown(KeyCode.DownArrow))
                finalVel+=Vector2.down;

            Move(finalVel);
        }

        private void Move(Vector2 vel)
        {
            _rigidbody.velocity = vel*_speed;
            
            //todo check for borders
        }
    }
}

using Common;
using UnityEngine;

namespace Enemies
{
    public abstract class EnemyController : MonoBehaviour, ICharacterController
    {
        [SerializeField] private Health _health;

        public GameObject GetCharacter() => gameObject;
    }
}

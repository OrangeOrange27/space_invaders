using Common;
using UnityEngine;

namespace Player
{
    public class PlayerSystem : MonoBehaviour, IPlayerSystem
    {
        [SerializeField] private PlayerController _controller;
        [SerializeField] private Health _health;

        public void SpawnPlayer(Transform parent)
        {
            Instantiate(_controller.GetCharacter(), parent);
        }

        public void KillPlayer()
        {
            throw new System.NotImplementedException();
        }

        private void Awake()
        {
            _health.OnZeroHealth += KillPlayer;
        }

        private void OnDestroy()
        {
            _health.OnZeroHealth -= KillPlayer;
        }
    }
}

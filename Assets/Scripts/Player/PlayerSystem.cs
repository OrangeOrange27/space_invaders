using Common;
using UnityEngine;

namespace Player
{
    public class PlayerSystem : MonoBehaviour, IPlayerSystem
    {
        [SerializeField] private PlayerController _controller;

        public void SpawnPlayer(Transform parent)
        {
            Instantiate(_controller.GetCharacter(), parent);
        }

        public void KillPlayer()
        {
            throw new System.NotImplementedException();
        }
    }
}

using Enemies;
using Player;
using UI;
using UnityEngine;

namespace System
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PlayerSystem _playerSystem;
        [SerializeField] private EnemiesSystem _enemiesSystem;
        [SerializeField] private UISystem _uiSystem;

        [SerializeField] private Transform _playerSpawnPoint;

        private int _score;
        private event Action<int> OnScoreChanged;

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                OnScoreChanged?.Invoke(value);
            }
        }

        private void Awake()
        {
            OnScoreChanged += _uiSystem.UpdateScore;
        }

        public void StartGame()
        {
            Score = 0;
            _playerSystem.SpawnPlayer(_playerSpawnPoint);
            
            //todo spawn enemies
            //todo 3 2 1
            
            _uiSystem.UpdateLife();
            
            UnPauseGame();
        }
    
        public void PauseGame()
        {
            Time.timeScale = 0;
        }

        public void UnPauseGame()
        {
            Time.timeScale = 1;
        }

        public void OnGameWin()
        {
            OnEndGame();
            
            _uiSystem.ShowWinPopUp();
            PauseGame();
        }
    
        public void OnGameLose()
        {
            OnEndGame();
            
            _uiSystem.ShowLosePopUp();
            PauseGame();
        }

        private void OnEndGame()
        {
            //todo clean up
        }

        private void OnDestroy()
        {
            OnScoreChanged -= _uiSystem.UpdateScore;
        }
    }
}

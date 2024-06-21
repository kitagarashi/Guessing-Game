using _Project.Scripts.Gameplay.Cell;
using _Project.Services;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Project.Scripts.Gameplay
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private CellLine[] _lines;
        [SerializeField] private GameObject _winScreen;
        [SerializeField] private GameObject _loseScreen;
        private int _score;

        private void Start()
        {
            foreach (var line in _lines)
                line.SetupLine();
        }

        private void OnEnable()
        {
            Cell.Cell.OnClicked += OnCellClicked;
        }

        private void OnDisable()
        {
            Cell.Cell.OnClicked -= OnCellClicked;
        }

        private void OnCellClicked(bool isntBomb)
        {
            if (isntBomb)
                Win();
            else
                Lose();
        }

        private void Win()
        {
            _score++;
            Debug.Log(_score);

            if (_score >= 6)
            {
                _winScreen.SetActive(true);
            }
        }

        private void Lose()
        {
            Debug.Log("lose");
            _loseScreen.SetActive(true);
        }
    }
}

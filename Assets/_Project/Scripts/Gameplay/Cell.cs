using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.Gameplay.Cell
{
    [RequireComponent(typeof(Button))]
    public class Cell : MonoBehaviour
    {
        public static Action<bool> OnClicked;

        [SerializeField] private Image _cellImage;
        private Button _cellButton;
        private CellData _cellData;

        public void Setup(CellData cellData)
        {
            _cellData = cellData;

            _cellImage.sprite = cellData.Sprite;
            _cellImage.gameObject.SetActive(false);
        }

        private void Awake()
        {
            _cellButton = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _cellButton.onClick.AddListener(CellButtonOnClicked);
        }

        private void OnDisable()
        {
            _cellButton.onClick?.RemoveListener(CellButtonOnClicked);
        }

        private void CellButtonOnClicked()
        {
            _cellImage.gameObject.SetActive(true);
            InvokeData();
        }

        private void InvokeData()
        {
            if (_cellData.Type == CellType.Bomb)
                OnClicked?.Invoke(false);
            else
                OnClicked?.Invoke(true);
        }
    }
}

using UnityEngine;

namespace _Project.Scripts.Gameplay.Cell
{
    [CreateAssetMenu(menuName = "new cell data", fileName = "ScriptableObjects/New cell data")]
    public class CellData : ScriptableObject
    {
        [SerializeField] private CellType _cellType;
        [SerializeField] private Sprite _sprite;

        public CellType Type => _cellType;
        public Sprite Sprite => _sprite;
    }
}

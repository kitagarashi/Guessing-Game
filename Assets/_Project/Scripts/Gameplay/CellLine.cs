using System.Linq;
using UnityEngine;

namespace _Project.Scripts.Gameplay.Cell
{
    public class CellLine : MonoBehaviour
    {
        [SerializeField] private Cell[] _cells;
        [SerializeField] private CellData[] _datas;

        public void SetupLine()
        {
            var bomb = _datas.Where(data => data.Type == CellType.Bomb).FirstOrDefault();
            var other = _datas.Where(data => data.Type == CellType.Other).ToArray();

            var bombIndex = Random.Range(0, _cells.Length);
            _cells[bombIndex].Setup(bomb);

            for (int i = 0; i < _cells.Length; i++)
            {
                if (i != bombIndex)
                {
                    var randomData = other[Random.Range(0, other.Length)];
                    _cells[i].Setup(randomData);
                }
            }
        }
    }
}

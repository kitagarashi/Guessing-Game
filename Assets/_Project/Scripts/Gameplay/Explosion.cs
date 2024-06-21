using UnityEngine;

namespace _Project.Gameplay
{
    public sealed class Explosion : MonoBehaviour
    {
        [SerializeField] private GameObject _smoke;

        public void Destroy()
        {
            Destroy(gameObject);
        }

        public void CreateSmoke()
        {
            Instantiate(_smoke, transform.position, Quaternion.identity);
        }
    }
}

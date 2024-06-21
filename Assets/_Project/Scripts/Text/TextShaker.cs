using UnityEngine;
using TMPro;

namespace _Project.TextExtentions
{
    [RequireComponent(typeof(TMP_Text))]
    public class TextShaker : MonoBehaviour
    {
        [SerializeField] private float _horizontalValue = 3.0f;
        [SerializeField] private float _verticalValue = 2.5f;

        private TMP_Text _text;
        private Mesh _mesh;
        private Vector3[] _vertices;

        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            _text.ForceMeshUpdate();
            _mesh = _text.mesh;
            _vertices = _mesh.vertices;

            for (int i = 0; i < _text.textInfo.characterCount; i++)
            {
                var info = _text.textInfo.characterInfo[i];
                int index = info.vertexIndex;
                Vector3 offset = Shake(Time.time + i);

                for (int j = 0; j < 4; j++)
                {
                    _vertices[index + j] += offset;
                }
            }

            _mesh.vertices = _vertices;
            _text.canvasRenderer.SetMesh(_mesh);
        }

        Vector2 Shake(float time)
        {
            return new Vector2(
                Mathf.Sin(time * _horizontalValue),
                Mathf.Cos(time * _verticalValue)
            );
        }
    }
}

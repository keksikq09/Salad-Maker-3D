using Game.Data;
using UnityEngine;

namespace Game.Core.Grater
{
    public class GraterObjectView : MonoBehaviour
    {
        private MeshFilter _meshFilter;
        private MeshRenderer _meshRenderer;
        private Material _material;

        private void Awake()
        {
            _meshFilter = GetComponent<MeshFilter>();
            _meshRenderer = GetComponent<MeshRenderer>();
            _material = _meshRenderer.material;
        }

        public void UpdateView(GraterData fruitData)
        {
            _meshFilter.mesh = fruitData.MainMesh;
        }

        public void UpdateRubbering(float rubberValue)
        {
            _material.SetFloat("_Scaler", rubberValue);
            Debug.Log(_material.GetFloat("_Scaler"));
        }
    }
}
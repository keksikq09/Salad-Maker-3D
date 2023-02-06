using UnityEngine;

namespace Game.Data
{
    [CreateAssetMenu(fileName = "New FruitData", menuName = "Fruit/FruitData")]
    public class FruitData : ScriptableObject
    {
        [SerializeField]
        private Mesh _mainMesh;

        [SerializeField]
        private float _startGraterValue;

        [SerializeField]
        private Color _particleColor;

        public Mesh MainMesh { get => _mainMesh; }

        public float StartGraterValue { get => _startGraterValue; }

        public Color ParticleColor { get => _particleColor; }
    }
}
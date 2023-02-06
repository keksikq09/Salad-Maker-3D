using UnityEngine;

namespace Game.Data
{
    [CreateAssetMenu(fileName = "New FruitData", menuName = "Fruit/FruitData")]
    public class GraterData : ScriptableObject
    {
        [SerializeField]
        private Mesh _mainMesh;

        [SerializeField]
        private float _startGraterValue;

        [SerializeField]
        private GameObject[] _gratedObjectPrefabs;

        public Mesh MainMesh { get => _mainMesh; }

        public float StartGraterValue { get => _startGraterValue; }

        public GameObject[] GratedObjectPrefabs { get => _gratedObjectPrefabs; }
    }
}
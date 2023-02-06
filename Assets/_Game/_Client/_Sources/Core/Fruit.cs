using Game.Data;
using UnityEngine;


namespace Game.Core
{
    public class Fruit : MonoBehaviour
    {
        [SerializeField]
        private FruitData[] _fruits;

        private FruitData _currentFruit;

        private void Start()
        {
            _currentFruit = _fruits[Random.Range(0, _fruits.Length)];
        }
    }
}
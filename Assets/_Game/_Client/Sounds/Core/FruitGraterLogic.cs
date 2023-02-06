using Game.Data;
using UnityEngine;
using UnityEngine.Events;

/*
    Note:
    Скриптик не готов или даже не работает
    Взял его из 2д версии
    Она наверное уже залита
    Етот можешь не смотерть
*/

namespace Game
{
    public class FruitGraterLogic : MonoBehaviour
    {
        [Header("Fruit Settings")]
        [SerializeField]
        private FruitData[] _fruits;

        [SerializeField]
        private FruitView _objectView;

        [SerializeField]
        private Transform _resetGamePosition;

        [Header("On Game Reset")]
        [SerializeField]
        private UnityEvent _onGameReset;


        private FruitData _currentFruit;

        private BoxCollider2D _boxCollider;

        private Vector3 _oldPosition;

        private float _rubbingValue;

        private bool _inGrather;


        //private void Start()
        //{
        //    _currentFruit = SetNewFruit();
        //    _boxCollider = GetComponent<BoxCollider2D>();
        //    _rubbingValue = _currentFruit.StartGraterValue;
        //    _oldPosition = transform.position;
        //    _objectView.UpdateView(_currentFruit);
        //}

        private void Update()
        {
            if (_inGrather && _oldPosition != transform.position)
            {
                Debug.Log("Can be sliced");
                _oldPosition = transform.position;
            }
        }


        private FruitData SetNewFruit()
        {
            return _fruits[Random.Range(0, _fruits.Length)];
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Grater"))
            {
                _inGrather = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Grater"))
            {
                _inGrather = false;
            }
        }

    }
}
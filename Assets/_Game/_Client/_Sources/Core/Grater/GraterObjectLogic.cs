using Game.Data;
using UnityEngine;

namespace Game.Core.Grater
{
    public class GraterObjectLogic : MonoBehaviour
    {
        [Header("Fruit Settings")]
        [SerializeField]
        private GraterData[] _graterObjectsData;

        private GraterObjectView _objectView;
        private GraterData _currentData;

        private BoxCollider _collider;

        private Vector3 _oldPosition;

        private float _rubbingValue;

        private bool _inGrather;

        private const float _removedRubbingValue = 0.0145f;
        private const float _colliderMovementOffset = 0.00240f;

        private void Start()
        {
            InitComponents();
            _oldPosition = transform.position;           
            _objectView.UpdateView(_currentData);
            _rubbingValue = _currentData.StartGraterValue;        
        }

        private void Update()
        {
            if (_inGrather && _oldPosition != transform.position)
            {
                Slicing();
                _oldPosition = transform.position;
            }
        }

        private void Slicing()
        {
            _rubbingValue -= _removedRubbingValue;

            _collider.center =
                new Vector3(_collider.center.x,
                _collider.center.y,
                _collider.center.z - _colliderMovementOffset);

            _objectView.UpdateRubbering(_rubbingValue);

            if(_rubbingValue > -0.1)
            {
                //reset game.
            }
        }


        private GraterData SetNewFruit()
        {
            return _graterObjectsData[Random.Range(0, _graterObjectsData.Length)];
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

        private void InitComponents()
        {
            _currentData = SetNewFruit();
            _collider = gameObject.AddComponent<BoxCollider>();
            _objectView = GetComponent<GraterObjectView>();
        }
    }
}
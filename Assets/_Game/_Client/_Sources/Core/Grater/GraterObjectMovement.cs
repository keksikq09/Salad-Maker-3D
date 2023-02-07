using UnityEngine;

namespace Game.Core.Grater
{
    public class GraterObjectMovement : MonoBehaviour
    {
        private Transform _transform;
        private Vector3 _offset;
        private float _distance;
        private bool _canMoving = true;

        private void Start()
        {
            _transform = GetComponent<Transform>();
        }

        public void Select()
        {
            _canMoving = true;
        }

        public void Deselect()
        {
            _canMoving = false;
        }

        private void Update()
        {
            if(_canMoving) 
            {
                if (Input.GetMouseButtonDown(0))
                {
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.gameObject.CompareTag("Player"))
                        {
                            _transform = hit.transform;
                            _offset = _transform.position - hit.point;
                            _distance = hit.distance;
                        }
                    }
                }
                if (Input.GetMouseButton(0) && !Input.GetMouseButtonDown(0) && _transform != null)
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    _transform.position = ray.origin + ray.direction * _distance + _offset;
                }

                if (Input.GetMouseButtonUp(0))
                    _transform = null;
            }          
        }
    }
}
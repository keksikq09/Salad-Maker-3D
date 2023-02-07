using Game.Data;
using UnityEngine;

namespace Game.Core.Grater
{
    public class GrattingReset : MonoBehaviour
    {
        [Header("Fields")]
        [SerializeField]
        private Transform _graterTransform;

        [SerializeField]
        private Transform _originPosition;
        [SerializeField]
        private Animation _resetAnimation;

        [SerializeField]
        private GraterObjectView _graterView;

        [SerializeField]
        private GraterObjectMovement _movement;

        [SerializeField]
        private GraterObjectLogic _logic;


        public void ResetGrater()
        {
            _movement.Deselect();
            _graterView.HideObject();
            _graterTransform.position = _originPosition.position;
            _resetAnimation.Play("Show");
        }

        public void ContinueGrater(GraterData newData)
        {
            _resetAnimation.Play("Hide");
            _logic.ResetRubbing(newData);
            _graterView.UpdateView(newData);
            _graterView.UpdateRubbering(newData.StartGraterValue);
            _graterView.ShowObject();
            _movement.Select();
        }
    }
}
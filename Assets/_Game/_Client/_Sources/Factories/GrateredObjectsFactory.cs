using Game.Data;
using UnityEngine;

namespace Game.Core.Factories
{
    public class GrateredObjectsFactory : MonoBehaviour
    {
        public void CreateGrateredObject(GraterData data)
        {
            var createdObject =
                Instantiate(data.GratedObjectPrefabs[Random.Range(0, data.GratedObjectPrefabs.Length)],
                transform.position, Quaternion.identity);
        }
    }
}
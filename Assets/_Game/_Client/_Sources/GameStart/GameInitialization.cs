using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Initialization
{
    /*
     * По мере розростание проекта , нужно будет добавить асинхронную загрузку 
     * пока дефолтная 
     * P.S пометку в obsidian сделал
    */
    public class GameInitialization : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.LoadSceneAsync(1);
        }
    }
}
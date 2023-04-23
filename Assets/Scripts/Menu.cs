using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nextScene;

    public void StartGame()
    {
        SceneManager.LoadScene(nextScene);
    }
}

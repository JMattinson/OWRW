using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeBehavior : MonoBehaviour
{

    public void GameStart()
    {
        
    }

    public void GameReturn()
    {
        
    }
    public void GameOver()
    {
        SceneManager.LoadScene("Scenes/GameOverScene");
        
    }
    public void MainMenu()
    {
        
    }

}

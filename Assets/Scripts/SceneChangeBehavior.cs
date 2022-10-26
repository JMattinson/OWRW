using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeBehavior : MonoBehaviour
{

    public void GameStart()
    {
        SceneManager.LoadScene("Scenes/GameScene");
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

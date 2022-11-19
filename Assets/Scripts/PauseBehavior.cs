
using UnityEngine;

public class PauseBehavior : MonoBehaviour
{
    
    public bool gamePaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TogglePauseGame()
        {
            //freeze the game timer, if the game is paused
            gamePaused = !gamePaused;
            Time.timeScale = gamePaused == true ? 0.0f : 1.0f;
        }

}

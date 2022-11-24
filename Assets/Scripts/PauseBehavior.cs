
using UnityEngine;

public class PauseBehavior : MonoBehaviour
{
    
    public BoolData gamePaused;
 
    public void TogglePauseGame()
        {
            //freeze the game timer, if the game is paused
            gamePaused.value = !gamePaused.value;
            Time.timeScale = gamePaused.value == true ? 0.0f : 1.0f;
        }

}

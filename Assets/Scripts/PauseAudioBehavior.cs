using UnityEngine;
using UnityEngine.Events;

public class PauseAudioBehavior : MonoBehaviour
{
    public BoolData gamePaused;
    public AudioSource aud;
    public UnityEvent PauseEvent, UnpauseEvent;

    public void PauseSwitch()
    {
        if(gamePaused.value)
            PauseEvent.Invoke();
        else
        {
            UnpauseEvent.Invoke();
        }
    }
    
    

}

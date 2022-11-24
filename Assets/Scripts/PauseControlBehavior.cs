
using UnityEngine;

public class PauseControlBehavior : MonoBehaviour
{
    public BoolData gamePaused;
    public GameObject ControlArea;

    private void Start()
    {
        ControlArea.gameObject.SetActive(true);
    }

    public void pauseControlBehavior()
    {
        ControlArea.gameObject.SetActive(!gamePaused.value);
    }
}

using UnityEngine;
using UnityEngine.UI;



public class PauseUIBehavior : MonoBehaviour
{

    public BoolData gamePaused;
    private Text Pauselabel;

    private void Start()
    {
        Pauselabel = GetComponent<Text>();
        Pauselabel.enabled = false;

    }

    public void pauseUIBehavior()
    {
        Pauselabel.enabled = gamePaused.value;
    }


}

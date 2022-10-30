using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Android;

public class ControlBehavior : MonoBehaviour
{
    public bool draggable;
    public BoolData stopCheck;
    public UnityEvent startEvent, startDragEvent, endDragEvent;
    
    void Start()
    {
        startEvent.Invoke();
    }

    
//Look I had a nice clean version of this code that didn't rely on Update:

/*public void OnMouseDown()
    {
        
        startDragEvent.Invoke();
        
    }
    

    public void OnMouseUp()
    {
        if (!stopCheck.value)
            endDragEvent.Invoke();
        
    }
    
    
 */

//But there's no OnMouseDown alternative that I know of for mobile. so here we are, stuck with update. 
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startDragEvent.Invoke();
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                if (!stopCheck.value)
                    endDragEvent.Invoke();
            }
        }
    }
    public void ForceGo()
    {
        endDragEvent.Invoke();
        
    }

    
    
}
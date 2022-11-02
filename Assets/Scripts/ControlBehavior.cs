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

    


public void OnMouseDown()
    {
        
        startDragEvent.Invoke();
        
    }
    

    public void OnMouseUp()
    {
        if (!stopCheck.value)
            endDragEvent.Invoke();
        
    }
    
    public void ForceGo()
    {
        if (!stopCheck.value)
            endDragEvent.Invoke();
        
    }

    
    
}
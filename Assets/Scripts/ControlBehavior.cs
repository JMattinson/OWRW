using System;
using UnityEngine;
using UnityEngine.Events;

public class ControlBehavior : MonoBehaviour
{
    public bool draggable;
    public BoolData stopCheck{ get; set; }
    public UnityEvent startEvent, startDragEvent, endDragEvent;
    void Start()
    {
        startEvent.Invoke();
    }

    public void OnMouseDown()
    {
        startDragEvent.Invoke();
    }

    private void OnMouseUp()
    {
        endDragEvent.Invoke();
    }
}
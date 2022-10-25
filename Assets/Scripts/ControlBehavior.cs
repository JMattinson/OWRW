using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Android;

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

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            startDragEvent.Invoke();
        }
    }
}
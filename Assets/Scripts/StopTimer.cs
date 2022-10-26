using System;
using UnityEngine;
using UnityEngine.Events;

public class StopTimer : MonoBehaviour
{
   public IntData stopTime;
   public BoolData stopCheck;

   public UnityEvent startEvent,outOfTimeEvent,TickEvent;

   public void Start()
   {
       startEvent.Invoke();
   }


   public void FixedUpdate()
   {
       if (stopCheck.value)
       {
           if (stopTime.value < 100)
           {
               stopTime.value++;
               TickEvent.Invoke();
           }
       }
       else
       {
           stopTime.value--;
           
       }

       if (stopTime.value < 0)
       {
           outOfTimeEvent.Invoke();
       }
       
       TickEvent.Invoke();
   }
}


using UnityEngine;
using UnityEngine.Events;

public class StopTimer : MonoBehaviour
{
   public FloatData stopTime;
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
           if (stopTime.value <= 99.75f)
           {
               stopTime.value += .75f;
               if (stopTime.value> 100f)
               {
                   stopTime.value = 100f;
               }
               TickEvent.Invoke();
           }
       }
       else
       {
           stopTime.value-= 0.75f;
           
       }

       if (stopTime.value < 0)
       {
           outOfTimeEvent.Invoke();
       }
       
       TickEvent.Invoke();
   }
}

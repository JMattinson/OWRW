using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RetryBehavior : MonoBehaviour
{
    public UnityEvent canRetryEvent, cannotRetryEvent;

    public IntData coinCheck;
    // Start is called before the first frame update
    void Start()
    {
        if (coinCheck.value == 10 || coinCheck.value > 10)
        {
            canRetryEvent.Invoke();
        }
        else
        {
            cannotRetryEvent.Invoke();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScrollBehavior : MonoBehaviour
{
    [Range (-1f,0f)]
    public float speed;
    // Update is called once per frame
    public void Move()
    {
        gameObject.transform.position = new Vector2 (transform.position.x + (speed), transform.position.y);    
    }
}

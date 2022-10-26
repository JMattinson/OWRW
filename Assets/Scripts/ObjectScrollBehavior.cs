
using UnityEngine;

public class ObjectScrollBehavior : MonoBehaviour
{
    public BoolData stopCheck;
    [Range (-1f,1f)]
    public float speed;


    public void Move()
    {
        if (stopCheck.value == true)
        {
            gameObject.transform.position = new Vector2(transform.position.x + (speed), transform.position.y);
        }
    }
}

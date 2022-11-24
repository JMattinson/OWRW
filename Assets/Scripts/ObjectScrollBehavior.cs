
using UnityEngine;

public class ObjectScrollBehavior : MonoBehaviour
{
    public BoolData stopCheck;
    public FloatData speed;


    public void Move()
    {
        if (stopCheck.value == true)
        {
            gameObject.transform.position = new Vector2(transform.position.x + (speed.value), transform.position.y);
        }
    }
}

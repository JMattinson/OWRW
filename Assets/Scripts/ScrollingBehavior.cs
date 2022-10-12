using UnityEngine;
using UnityEngine.Events;
public class ScrollingBehavior : MonoBehaviour
{
    //This is all Rough and terrible, modify this to use scriptable objects soon.
    public UnityEvent startEvent;
    
    [Range (-1f,1f)]
    public float speed;

    public bool CanRun;
    private float offset;
    private Material mat;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    private void Update()
    {
        
            offset += (Time.deltaTime * speed);
            mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        
    }
}

using UnityEngine;
public class ScrollingBehavior : MonoBehaviour
{

    [Range (-1f,1f)]
    public float speed;
    
    private float offset;
    private Material mat;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        
    }
    
    
    public void BGScroll()
    {
        offset += (speed* Time.deltaTime);
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}

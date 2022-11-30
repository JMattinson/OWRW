using UnityEngine;
public class ScrollingBehavior : MonoBehaviour
{

    [Range(-1f, 1f)]
    public float speed;

    private float offset;
    private Material mat;
    public BoolData stopCheck;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;

    }


    public void BGScroll()
    {
        if (stopCheck)
        {
            offset += (speed * Time.deltaTime);
            mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }

    }
}
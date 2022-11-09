
using UnityEngine;
[CreateAssetMenu]

public class Debugger : MonoBehaviour
{
    
    public void OnDebug(string obj)
    {
        Debug.Log(obj);
    }
    public void OnDebug(int obj)
    {
        Debug.Log(obj);
    }
    public void OnDebug(float obj)
    {
        Debug.Log(obj);
    }

}

using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject[] prefabList;
    public BoolData stopCheck;
    
    public void CreateInstanceRandomly(Vector3Data obj)
    {
        if (stopCheck)
        {
            Instantiate(prefabList[(UnityEngine.Random.Range(1, prefabList.Length))], obj.value, Quaternion.identity);
        }
    }

}

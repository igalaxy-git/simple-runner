using UnityEngine;
using Random = UnityEngine.Random;

public class RoadController : MonoBehaviour
{

    public GameObject road;
    public GameObject crystal;
    private Vector3 lastPos = new Vector3(0f, -1.75f, 0f);
    private Vector3 offset = new Vector3(0f, 0f, 0f);
    public static bool stopInvoking = false;
    private float TimeToLive = 4f;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject _platform = Instantiate(road, transform) as GameObject;
            _platform.transform.position = lastPos + new Vector3(-1f, 0f, 0f);
            lastPos = _platform.transform.position;
        }
        InvokeRepeating("SpawnPlatform", 1f, 0.2f);
    }
    
    void SpawnPlatform()
    {
        int random = Random.Range(0, 2);
        int rand = Random.Range(0, 5);

        GameObject _platform = Instantiate(road, transform) as GameObject;
        if (random == 0)
        {
            offset = new Vector3(-1f, 0f, 0f);
        }
        else
        {
            offset = new Vector3(0f, 0f, -1f);
        }
        _platform.transform.position = lastPos + offset;
        if (rand == 3)
        {
            GameObject _crystal = Instantiate(crystal, transform) as GameObject;
            _crystal.transform.position = lastPos + offset + new Vector3 (0f, 1.75f, 0f);
            Destroy(_crystal, 5f);
            
        }
        
        lastPos = _platform.transform.position;
        Destroy(_platform, TimeToLive);
    }

    void Update()
    {
        if (stopInvoking)
        {
            CancelInvoke();
            stopInvoking = false;
        }
    }
}
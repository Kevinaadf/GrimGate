using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject go;

    public bool waitToSpawn = false;
    public float timeToWait;



    private void Start()
    {
        if (!waitToSpawn)
        {
            Instantiate(go, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            Wait(timeToWait);
            Instantiate(go, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }



    IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }

}

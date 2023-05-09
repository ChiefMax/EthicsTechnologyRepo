using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSpawnerHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToSpawn;
    [SerializeField]
    private GameObject parantObject;
    int objectToSpawnCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            float parentX = parantObject.transform.position.x + 0.5f;
            float parentY = parantObject.transform.position.y + 0.5f;
            float parantZ = parantObject.transform.position.z + 0.5f;

            Vector3 randomnSpawn = new Vector3(parentX + Random.Range(1,2), parentY + Random.Range(1,2), parantZ + Random.Range(1,2));

            Instantiate(objectToSpawn,randomnSpawn,Quaternion.identity);
        }

        

        if (objectToSpawnCount < 5)
        {
            objectToSpawnCount++;
            Debug.Log(objectToSpawnCount);
            float parentX = parantObject.transform.position.x;
            float parentY = parantObject.transform.position.y;
            float parantZ = parantObject.transform.position.z;

            Vector3 randomnSpawn = new Vector3(parentX + Random.Range(1, 2), parentY + Random.Range(1, 3), parantZ + Random.Range(1, 2));

            var Object = Instantiate(objectToSpawn, randomnSpawn, Quaternion.identity);
            Object.transform.parent = transform;
            //SelfDestruct();

        }
        //else 
        //{
        //    Destroy(objectToSpawn);
        //}
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(5f);
        DestroyImmediate(objectToSpawn,true);
        objectToSpawnCount--;
    }
}

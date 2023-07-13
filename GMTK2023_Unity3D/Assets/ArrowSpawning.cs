using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawning : MonoBehaviour
{
    public GameObject objectToSpawn;

    public GameObject SpawnArrow()
    {
        GameObject newObject = Instantiate(objectToSpawn, transform.position, transform.rotation);

        newObject.GetComponent<Rigidbody>().velocity = new Vector3(
            5f,
            Random.Range(-1f, 2f),
            Random.Range(-2f, 2f)
        );

        return newObject;
    }
}

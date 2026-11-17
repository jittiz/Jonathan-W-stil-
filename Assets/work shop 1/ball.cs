using System;
using Unity.VisualScripting;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Transform SpawnPoint;
    

    

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "DeathBox")
        {
            Debug.Log("hallå");
            transform.position = SpawnPoint.position;

        }
    }
}

using UnityEngine;

public class SpawnMover : MonoBehaviour
{

    
    public Transform transform;
    public float rotateSpeed;
    public bool rotateDirection;
    private float rorer;

    void Start()
    {
        if (rotateDirection == true)
        {
            rorer = 1;
        }
        else
        {
            rorer = -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rorer, rotateSpeed * Time.deltaTime);
        
    }
}

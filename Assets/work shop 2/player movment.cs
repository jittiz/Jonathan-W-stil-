using UnityEngine;



public class playermovment : MonoBehaviour
{

    public float MoveSpeed;
    Rigidbody2D rb;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       


        
        
    }
    private void FixedUpdate()
    {
        Vector3 move_input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        rb.MovePosition(transform.position + move_input * Time.fixedDeltaTime * MoveSpeed);
    }
}

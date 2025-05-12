using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed ;
    public float jumpForce;
    public Rigidbody rb;
    public float rotateSpeed;
    private bool canJump = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        

        transform.Rotate(0, 
            Input.GetAxisRaw("Horizontal") * rotateSpeed * Time.deltaTime, 
            0);
        transform.Translate(0, 0, 
            Input.GetAxis("Vertical") * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space) && canJump )
        {
            rb.AddForce(0, jumpForce, 0);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            canJump = true;
            jumpForce = 300;
            speed = 10;
        }
        if (collision.gameObject.CompareTag("grounder"))
        {
            canJump = true;
            jumpForce = 600;
            speed = 15;
        }

        Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
        Debug.Log(collision.gameObject.name);
    }

}



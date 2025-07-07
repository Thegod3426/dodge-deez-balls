using Unity.VisualScripting;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float rotatesp=200.0f;
    private float horizontalInput; 
    private float verticalInput;
    public float jumpForce = 15;
    public bool isOnGround = true;
    private Rigidbody playerRb;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       playerRb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        transform.Rotate(Vector3.up * speed * horizontalInput * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space)&&isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        transform.Rotate(Vector3.up * rotatesp * horizontalInput * Time.deltaTime);

    }
}

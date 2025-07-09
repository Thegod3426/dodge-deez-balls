using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float rotatesp = 200.0f;
    private float horizontalInput;
    private float verticalInput;
    public float jumpForce = 300.0f;
    public bool isOnGround = true;
    public Rigidbody playerRb;
    private Vector3 offset;
    private float zCoord;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);


        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up * rotatesp * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        //playerRb.linearVelocity = ((verticalInput * speed) * transform.forward) + ((horizontalInput * speed) * transform.right);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
   
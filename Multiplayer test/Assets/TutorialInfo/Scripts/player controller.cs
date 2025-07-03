using Unity.VisualScripting;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float rotatesp;
    private float horizontalInput; 
    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * rotatesp * horizontalInput * Time.deltaTime);
    }
}

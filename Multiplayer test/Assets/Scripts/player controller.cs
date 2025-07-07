using Unity.VisualScripting;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float rotatesp;
    private float horizontalInput; 
    private float verticalInput;
    public float jumpForce = 150;


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
<<<<<<< HEAD:Multiplayer test/Assets/Scripts/player controller.cs
        transform.Rotate(Vector3.up * speed * horizontalInput * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {

        }
=======
        transform.Rotate(Vector3.up * rotatesp * horizontalInput * Time.deltaTime);
>>>>>>> adb45b834ae8508069eb0a980a6d4105b2c9d752:Multiplayer test/Assets/TutorialInfo/Scripts/player controller.cs
    }
}

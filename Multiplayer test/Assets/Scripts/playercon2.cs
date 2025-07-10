using UnityEngine;
using UnityEngine.UIElements;

public class playercon2 : MonoBehaviour
{
    private float HorizontalInput;
    private float VerticalInput;
    public float Speed;
    public float Rotatesp;
    public bool IsOnGround = true;
    public Rigidbody p2RB;
    public float JumpForce = 300.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontalp2");
        VerticalInput = Input.GetAxis("Verticalp2");
        transform.Translate(Vector3.forward*Speed*VerticalInput*Time.deltaTime);
        transform.Rotate(Vector3.up * Rotatesp * HorizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.O) && IsOnGround)
        {
            p2RB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsOnGround = false;
        }
    }
}

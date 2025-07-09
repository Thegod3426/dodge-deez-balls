using UnityEngine;

public class balllanch : MonoBehaviour
{

    public Rigidbody BRB;
    public GameObject PLAYER;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = PLAYER.transform.rotation;
       
    }
    private void OnMouseDown()
    {
       
        BRB.AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }
}

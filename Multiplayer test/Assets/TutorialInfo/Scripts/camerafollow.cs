using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 camplace=new Vector3(0,4,-5);
    private Vector3 camrot = new Vector3(20, 0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        transform.rotation = player.transform.rotation;
    }
}

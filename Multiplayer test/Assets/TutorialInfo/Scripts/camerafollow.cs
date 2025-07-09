using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        player = transform.parent;
    }

    // Update is called once per frame
    public void Update()
    {
        transform.position = player.position+new Vector3(0,3,0);
         transform.rotation = player.rotation;
    }
}

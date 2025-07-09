using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject player;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
     
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = player.transform.position+new Vector3(0,3,0);
         transform.rotation = player.transform.rotation;
    }
}

using System.Drawing;
using Unity.Netcode;
using Unity.VisualScripting;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    private Rigidbody rb;
    private bool draging = false;//origion false
    private Vector3 offset;
    private float zCoord;
    private Camera cam;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;
        return Camera.main.WorldToScreenPoint(mousePoint);
    }


    private void FixedUpdate()
    {
        if (draging)
        {
            Vector3 targetPos = GetMouseWorldPosition();
            rb.MovePosition(targetPos);
        }
    }

    private void OnMouseDown()
    {
        zCoord = Camera.main.WorldToScreenPoint(transform.position).z;
        offset = transform.position - GetMouseWorldPosition();
        draging = true;
        rb.useGravity = false;
    }

    private void OnMouseUp()
    {
        draging = false;
        rb.useGravity = true;
    }

    

    //public void OnMouseDrag()
    //{
        //was private
        //Vector3 mousePos= Input.mousePosition;
        //Vector3 point = new Vector3();
        //transform.position = GetMouseWorldPosition();//offset was here
        //Vector3.Normalize(offset);
        //point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
       
    }
   
//}


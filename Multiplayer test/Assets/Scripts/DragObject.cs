using Unity.VisualScripting;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Rigidbody rb;
    private bool draging = false;
    private Vector3 offset;
    private float zCoord;

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
            Vector3 targetPos = GetMouseWorldPosition() + offset;
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

    

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + offset;
    }

   

    


}

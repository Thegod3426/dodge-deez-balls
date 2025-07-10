using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;



public class demo : MonoBehaviour

{
    public Transform armx2;
    private Vector3 mOffset;
    public float Speed;
    public bool ballcheck=true; 



    private float mZCoord;



    void OnMouseDown()

    {
       
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;



        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
                                                                  

    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen

        mousePoint.z = mZCoord;



        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint()+ mOffset;
        ballcheck = true;

    }
    private void FixedUpdate()
    {
        var distance=Speed*Time.deltaTime;
        if (Input.GetMouseButton(1)&&Input.GetMouseButton(0)&&ballcheck)
        {
            transform.position = Vector3.MoveTowards(transform.position, armx2.position, distance);
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Debug.Log("hit");
            SceneManager.LoadScene("StartGame");
        }
    }
}
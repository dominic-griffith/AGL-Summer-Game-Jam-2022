using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{

    //private Vector3 mOffset;
    //private float mZCoord;

    //private void OnMouseDown()
    //{
    //    mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

    //    // store offset = gameobject world pos - mouse world pos
    //    mOffset = gameObject.transform.position - getMouseWorldPos();
    //}

    //private Vector3 getMouseWorldPos()
    //{
    //    // pixel coordinates
    //    Vector3 mousePoint = Input.mousePosition;

    //    // z coordinates of game object on screen
    //    mousePoint.z = mZCoord;

    //    return Camera.main.ScreenToWorldPoint(mousePoint);
    //}

    //private void OnMouseDrag()
    //{
    //    transform.position = getMouseWorldPos() + mOffset;
    //}

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + transform.position.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        rb.isKinematic = true;
    }

    private void OnMouseUp()
    {
        rb.isKinematic = false;
    }
}

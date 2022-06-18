using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorMovement : MonoBehaviour
{
    private SpriteRenderer rend;
    [SerializeField] private Sprite openCursor;
    [SerializeField] private Sprite closeCursor;

    private void Start()
    {
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z + transform.position.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        //Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = cursorPos;
    }

    public void dragOn()
    {
        rend.sprite = closeCursor;
    }

    public void dragOff()
    {
        rend.sprite = openCursor;
    }
}

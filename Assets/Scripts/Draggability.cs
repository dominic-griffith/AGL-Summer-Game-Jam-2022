using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggability : MonoBehaviour
{
    public bool draggable;

    private void Start()
    {
        draggable = true;
    }

    public void MakeDraggable()
    {
        draggable = true;
    }

    public void MakeUndraggable()
    {
        draggable = false;
    }

}

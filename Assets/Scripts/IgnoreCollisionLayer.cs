using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionLayer : MonoBehaviour
{
    private void Start()
    {
        Physics.IgnoreLayerCollision(8, 8);
    }
}

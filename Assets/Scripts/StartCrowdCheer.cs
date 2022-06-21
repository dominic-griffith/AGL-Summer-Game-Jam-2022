using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCrowdCheer : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Cheering");
    }
}

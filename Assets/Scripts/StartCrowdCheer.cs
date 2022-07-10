using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCrowdCheer : MonoBehaviour
{
    public void Start()
    {
        FindObjectOfType<AudioManager>().Play("Cheering");
    }
    public void Stop()
    {
        FindObjectOfType<AudioManager>().Stop("Cheering");
    }
}

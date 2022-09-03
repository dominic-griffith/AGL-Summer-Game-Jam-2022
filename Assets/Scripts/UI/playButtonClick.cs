using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playButtonClick : MonoBehaviour
{
    public void playButtonSound()
    {
        FindObjectOfType<AudioManager>().Play("Button Click");
    }
}

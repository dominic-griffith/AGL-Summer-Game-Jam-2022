using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleOverlay : MonoBehaviour
{
    public GameObject wallImage;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            wallImage.SetActive(!wallImage.activeSelf);
        }
    }
}

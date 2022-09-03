using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeOverlay : MonoBehaviour
{
    public GameObject escapeOverlay;
    public GameObject crowdSound;
    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escapeOverlay.SetActive(!escapeOverlay.activeSelf);
            if(isPaused)
            {
                Time.timeScale = 1f;
                crowdSound.GetComponent<StartCrowdCheer>().Start();
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0f;
                crowdSound.GetComponent<StartCrowdCheer>().Stop();
                isPaused = true;
            }
        }
    }
}

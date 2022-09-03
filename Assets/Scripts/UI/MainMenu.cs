using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator canvas;


    public void PlayGame() {
       canvas.SetBool("PanToPlay", true);
    }

    public void GoToSettings() {
        canvas.SetBool("PanToSetting", true);
    }

    public void GoToCredits() {
        canvas.SetBool("PanToCredits", true);
    }


    public void PlayToMain() {
        canvas.SetBool("PanToPlay", false);
    }

    public void SettingsToMain() {
       canvas.SetBool("PanToSetting", false);
    }

    public void CreditsToMain() {
        canvas.SetBool("PanToCredits", false);
    }

    public void QuitGame() {
        Application.Quit();
    }

}


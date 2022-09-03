using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour
{

        public void ReturnToMenu() {
        SceneManager.LoadScene(Global.SCENES.MAINMENU.ToString());
    }
        public void QuitGame() {
        Debug.Log("QUIT2!");
        Application.Quit();
    }
}

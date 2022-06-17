using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    public void GoToLevel(int lvl) {
        SceneManager.LoadScene(Global.SCENES.GAME.ToString());




    }
}

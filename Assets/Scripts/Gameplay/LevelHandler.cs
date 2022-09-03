using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    public void GoToLevel(int lvl) {
        SceneManager.LoadScene(Global.SCENES.PLAY.ToString());
        DeployWalls dw = Camera.main.GetComponent(typeof(DeployWalls)) as DeployWalls;
        dw.SetWallIndex(lvl);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnStart : MonoBehaviour
{
    [SerializeField] private int sceneToLoad;
    private void Start()
    {
        loadScene(sceneToLoad);
    }

    public void loadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}

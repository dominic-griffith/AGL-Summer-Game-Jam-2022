using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WallMovement : MonoBehaviour // the instantiation of a wall
{
    public float speed = 1f;
    public GameObject progressBar;
    public float initDist;

    // Start is called before the first frame update
    void Start()
    {
        initDist = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = gameObject.transform.position.z;

        if (distance > 0f) {
           transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        ProgressBar pb = progressBar.GetComponent(typeof(ProgressBar)) as ProgressBar;
        pb.GetComponent<Slider>().value = 1 - distance / initDist;

    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "Player") {

            Debug.Log("poop");
            SceneManager.LoadScene(Global.SCENES.GAMEOVER.ToString());

        }

    }



}
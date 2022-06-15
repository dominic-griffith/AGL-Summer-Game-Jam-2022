using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallMovement : MonoBehaviour // the instantiation of a wall
{

    public static float difficulty = 0f;
    private float speed = (float)(1f + (difficulty * 0.025f));

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Person") {

            Debug.Log("poop");
            SceneManager.LoadScene(Global.SCENES.GAMEOVER.ToString());

        }

    }

    public void SetDifficulty(float d) {
        difficulty = d;
    }

    public float GetSpeed() {
        return speed;
    }

}
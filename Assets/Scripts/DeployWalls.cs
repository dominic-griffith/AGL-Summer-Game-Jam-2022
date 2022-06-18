using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeployWalls : MonoBehaviour
{




    public int numParts = 4;

    public GameObject wallHolder;

    public Sprite wall;

    public List<Sprite> wallPrefabs; // prefabs allow us to make clones of the original without destorying the original (since the og is not in the game) (factory method?)
    
    public GameObject progressBar;

   private float secondsCount = 0;

   

    public void GoToLevel(int lvl) {
        SceneManager.LoadScene(Global.SCENES.PLAY.ToString());
        DeployWalls dw = Camera.main.GetComponent(typeof(DeployWalls)) as DeployWalls;
        dw.SetWallIndex(lvl);
    }



    // Start is called before the first frame update
    void Start()
    {
     //   time = new Timer();

        StartCoroutine(SpawnWall());
        // starts the looping of walls
    }

    // Update is called once per frame
    void Update()
    {
        secondsCount += Time.deltaTime;
        
    }

    public void SetWallIndex(int i) {
        wall = wallPrefabs[i - 1];
    }

    IEnumerator SpawnWall() {
        while(true) {
    
            float spd = 0f;
            int wallIndex = Random.Range(0, 7);
            GameObject wh = Instantiate(wallHolder) as GameObject;


                SpriteRenderer r = wh.GetComponent<SpriteRenderer>();
                r.sprite = wall;

                WallMovement wm = wh.GetComponent(typeof(WallMovement)) as WallMovement;
         



                ProgressBar pb = progressBar.GetComponent(typeof(ProgressBar)) as ProgressBar;

                



                pb.StartProgress(spd / 12f);

        


/*

            for (int i = 0; i < numParts; i++) {

                GameObject currentWall = Instantiate(wallPrefab[i], new Vector3(0, 2.5f, 10), Quaternion.identity) as GameObject; // abstractify this
                
                
                WallMovement wm = currentWall.GetComponent(typeof(WallMovement)) as WallMovement;
                wm.SetDifficulty(secondsCount);
                
                
                
                currentWall.transform.parent = wall.transform;


                spd = wm.GetSpeed();


        
            }

            */


        yield return new WaitForSeconds(12f / spd);

        if (wh != null) {
            Destroy(wh);
            pb.reset();

        }
    }

    }

}

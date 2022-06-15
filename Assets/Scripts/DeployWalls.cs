using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployWalls : MonoBehaviour
{

    public int numParts = 4;

    public List<GameObject> wallPrefab; // prefabs allow us to make clones of the original without destorying the original (since the og is not in the game) (factory method?)
    

   private float secondsCount = 0;


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

    IEnumerator SpawnWall() {
        while(true) {

            GameObject wall = new GameObject();
            float spd = 0f;

            // can you put it in a loop?

            // z-axis is the distance between the player and the wall at spawn

            GameObject wallLeft = Instantiate(wallPrefab[0]) as GameObject;
            GameObject wallRight = Instantiate(wallPrefab[0]) as GameObject;
            GameObject wallUp = Instantiate(wallPrefab[0]) as GameObject;
            GameObject wallDown = Instantiate(wallPrefab[0]) as GameObject;


    


                // hole boundaries
                float x1 = Random.Range(0f, 10.0f);
                float x2 = Random.Range(0f, 10.0f);
                float y1 = Random.Range(0f, 5.0f);
                float y2 = Random.Range(0f, 5.0f);

                if (Mathf.Abs(x2-x1) < 1.5f) {
                    x1 = Random.Range(0f, 8.5f);
                    x2 = x1 + 1.5f;
                }

                
                if (Mathf.Abs(y2-y1) < 1.5f) {
                    y1 = Random.Range(0f, 3.5f);
                    y2 = y1 + 1.5f;

                }

                if (x1 < x2) {

                    wallLeft.transform.localScale = new Vector3(x1, 5f, 1f);
                    wallRight.transform.localScale = new Vector3(10f-x2, 5f, 1f);


                } else { // x1 < x2 (SHOULD BE) idk if need == case


                    wallLeft.transform.localScale = new Vector3(x2, 5f, 1f);
                    wallRight.transform.localScale = new Vector3(10f-x1, 5f, 1f);

                }

                if (y1 < y2) {

                    wallUp.transform.localScale = new Vector3(Mathf.Abs(x2-x1), 5f-y2, 1f);
                    wallDown.transform.localScale = new Vector3(Mathf.Abs(x2-x1), y1, 1f);


                } else { // y1 < y2 (SHOULD BE)


                    wallUp.transform.localScale = new Vector3(Mathf.Abs(x2-x1), 5f-y1, 1f);
                    wallDown.transform.localScale = new Vector3(Mathf.Abs(x2-x1), y2, 1f);
                    
                }




                if ((x1 < x2) && (y1 < y2)) {

                     wallLeft.transform.Translate(new Vector3(x1/2f-5f, 5f/2f, 10f));
                     wallRight.transform.Translate(new Vector3(x2/2f, 5f/2f, 10f));

                     wallUp.transform.Translate(new Vector3(x1/2f+x2/2f-5f, 5f/2f+y2/2f, 10f));
                     wallDown.transform.Translate(new Vector3(x1/2f+x2/2f-5f, y1/2f, 10f));

                     //x1/2 - 5 + x2/
                } else if ((x1 < x2) && (y1 > y2)) {

                        wallLeft.transform.Translate(new Vector3(x1/2f-5f, 5f/2f, 10f));
                     wallRight.transform.Translate(new Vector3(x2/2f, 5f/2f, 10f));

                     wallUp.transform.Translate(new Vector3(x1/2f+x2/2f-5f, 5f/2f+y1/2f, 10f));
                     wallDown.transform.Translate(new Vector3(x1/2f+x2/2f-5f, y2/2f, 10f));


                                        
                } else if ((x1 > x2) && (y1 < y2)) {

                                         wallLeft.transform.Translate(new Vector3(x2/2f-5f, 5f/2f, 10f));
                     wallRight.transform.Translate(new Vector3(x1/2f, 5f/2f, 10f));

                     wallUp.transform.Translate(new Vector3(x2/2f+x1/2f-5f, 5f/2f+y2/2f, 10f));
                     wallDown.transform.Translate(new Vector3(x2/2f+x1/2f-5f, y1/2f, 10f));


                } else if ((x1 > x2) && (y1 > y2)) {

                    wallLeft.transform.Translate(new Vector3(x2/2f-5f, 5f/2f, 10f));
                     wallRight.transform.Translate(new Vector3(x1/2f, 5f/2f, 10f));

                     wallUp.transform.Translate(new Vector3(x2/2f+x1/2f-5f, 5f/2f+y1/2f, 10f));
                     wallDown.transform.Translate(new Vector3(x2/2f+x1/2f-5f, y2/2f, 10f));

                }



                wallLeft.transform.parent = wall.transform;
                wallRight.transform.parent = wall.transform;
                wallUp.transform.parent = wall.transform;
                wallDown.transform.parent = wall.transform;


                WallMovement wm1 = wallLeft.GetComponent(typeof(WallMovement)) as WallMovement;
                 WallMovement wm2 = wallRight.GetComponent(typeof(WallMovement)) as WallMovement;
                  WallMovement wm3 = wallUp.GetComponent(typeof(WallMovement)) as WallMovement;
                   WallMovement wm4 = wallDown.GetComponent(typeof(WallMovement)) as WallMovement;


                wm1.SetDifficulty(secondsCount);
                wm2.SetDifficulty(secondsCount);
                wm3.SetDifficulty(secondsCount);
                wm4.SetDifficulty(secondsCount);
                
                
                
                wallLeft.transform.parent = wall.transform;
                wallRight.transform.parent = wall.transform;
                wallUp.transform.parent = wall.transform;
                wallDown.transform.parent = wall.transform;


                spd = wm1.GetSpeed();

        


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

        if (wall != null) {
            Destroy(wall);
        }
    }

    }

}

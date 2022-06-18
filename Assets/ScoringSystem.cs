using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    public List<string> bodyParts;
    private int scoreGood = 0;
    private int scoreNeutral = 0;
    private int scoreBad = 0;

    public void waitForScore()
    {
        Invoke("calculateScore", 1);
    }

    public void calculateScore()
    {
        int totScore = 9 - bodyParts.Count;
        int tempPoints = totScore;

        if (tempPoints >= 3)
        {
            scoreGood = 3;
            tempPoints -= 3;
        }
        else
        {
            scoreGood = tempPoints;
            tempPoints -= tempPoints;
        }
        if (tempPoints >= 3)
        {
            scoreNeutral = 3;
            tempPoints -= 3;
        }
        else
        {
            scoreNeutral = tempPoints;
            tempPoints -= tempPoints;
        }
        scoreBad = tempPoints;

        Debug.Log(totScore);
        Debug.Log(scoreGood);
        Debug.Log(scoreNeutral);
        Debug.Log(scoreBad);
    }
}

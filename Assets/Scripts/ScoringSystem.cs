using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    [SerializeField] private TextMeshPro textGood;
    [SerializeField] private TextMeshPro textNeutral;
    [SerializeField] private TextMeshPro textBad;

    public List<string> bodyParts;
    public int scoreGood = 0;
    public int scoreNeutral = 0;
    public int scoreBad = 0;
    public int totScore;

    public void waitForScore()
    {
        Invoke("calculateScore", 1);
    }

    public void calculateScore()
    {
        totScore = 9 - bodyParts.Count;
        int tempPoints = totScore;

        if (tempPoints >= 3)
        {
            scoreGood = 3 * 3 + 1;
            tempPoints -= 3;
        }
        else
        {
            scoreGood = tempPoints * 3 + 1;
            tempPoints -= tempPoints;
        }
        if (tempPoints >= 3)
        {
            scoreNeutral = 3 * 3 + 1;
            tempPoints -= 3;
        }
        else
        {
            scoreNeutral = tempPoints * 3 + 1;
            tempPoints -= tempPoints;
        }
        scoreBad = tempPoints * 3 + 1;

        textGood.text = scoreGood.ToString();
        textNeutral.text = scoreNeutral.ToString();
        textBad.text = scoreBad.ToString();
    }
}

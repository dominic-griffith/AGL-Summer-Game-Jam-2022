using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    [SerializeField] private Animator animCam;
    [SerializeField] private Animator animGood;
    [SerializeField] private Animator animNeutral;
    [SerializeField] private Animator animBad;
    [SerializeField] private GameObject wallImage;
    [SerializeField] private PolygonCollider2D polygonCollider2D;
    [SerializeField] private ScoringSystem scoring;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject cursor;


    public void endLevel()
    {
        FindObjectOfType<AudioManager>().Stop("Cheering");
        FindObjectOfType<AudioManager>().Play("Drum Roll");
        cursor.SetActive(false);
        animCam.SetBool("PanCamera", true);
        wallImage.SetActive(false);
        player.GetComponent<Draggability>().MakeUndraggable();
        polygonCollider2D.enabled = true;
        scoring.waitForScore();
        Invoke("LiftSignGood", 1);
        Invoke("LiftSignNeutral", 3);
        Invoke("LiftSignBad", 5);
    }

    private void LiftSignGood()
    {
        animGood.SetBool("LiftScore", true);
        if (scoring.scoreGood < 7)
        {
            FindObjectOfType<AudioManager>().Play("Crowd Aw");
        }
    }

    private void LiftSignNeutral()
    {
        animNeutral.SetBool("LiftScore", true);
        if (scoring.scoreNeutral < 7)
        {
            FindObjectOfType<AudioManager>().Play("Crowd Aw");
        }
    }

    private void LiftSignBad()
    {
        animBad.SetBool("LiftScore", true);
        if(scoring.scoreBad < 7)
        {
            FindObjectOfType<AudioManager>().Play("Crowd Aw");
        }
        if(scoring.totScore == 9)
        {
            FindObjectOfType<AudioManager>().Play("Crowd Cheer");
        }
    }
}

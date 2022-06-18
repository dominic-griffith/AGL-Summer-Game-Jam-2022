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


    public void endLevel()
    {
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
    }

    private void LiftSignNeutral()
    {
        animNeutral.SetBool("LiftScore", true);
    }

    private void LiftSignBad()
    {
        animBad.SetBool("LiftScore", true);
    }
}

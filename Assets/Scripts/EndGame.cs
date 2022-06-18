using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    [SerializeField] private Animator anim;
    [SerializeField] private GameObject wallImage;
    [SerializeField] private PolygonCollider2D polygonCollider2D;
    //[SerializeField] private ScoringSystem scoring;


    public void endLevel()
    {
        anim.SetBool("PanCamera", true);
        wallImage.SetActive(false);
        polygonCollider2D.enabled = true;
        //scoring.calculateScore();
    }
}

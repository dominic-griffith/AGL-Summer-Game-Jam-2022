using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    [SerializeField] ScoringSystem score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.bodyParts.Add(collision.transform.name);
    }
}

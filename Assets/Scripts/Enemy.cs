using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] int scorePerHit = 12;

    static Transform parent;

    ScoreBoard scoreBoard;

    private void Start()
    {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        GameObject FX = Instantiate(deathFX, transform.position, Quaternion.identity);
        if (parent == null)
        {
            parent = new GameObject().transform;
            parent.name = "Spawned FX";
        }
        FX.transform.SetParent(parent);
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        scoreBoard.ScoreHit(scorePerHit);
    }
}

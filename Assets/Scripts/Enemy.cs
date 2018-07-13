using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;

    static Transform parent;

    private void Start()
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
}

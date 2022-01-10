using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // IEnumerator LifeTime()
    // {
    //     yield return new WaitForSeconds(lifeTime);
    //     Destroy(this);
    // }

    private void OnCollisionEnter(Collision other)
    {
        if(!other.gameObject.CompareTag("Player"))
            Destroy(gameObject);
    }
}

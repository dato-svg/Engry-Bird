﻿using UnityEngine;

public class Brick : MonoBehaviour
{
    public float Health = 70f;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;

        float damage = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
        //don't play audio for small damages
        if (damage >= 10)
            GetComponent<AudioSource>().Play();
        //decrease health according to magnitude of the object that hit us
        Health -= damage;
        //if health is 0, destroy the block
        if (Health <= 0) Destroy(this.gameObject);
    }

  
}

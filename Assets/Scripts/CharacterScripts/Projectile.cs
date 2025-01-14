﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject owner;
    protected GameController gc;

    protected virtual void Start()
    {
        gc = GameObject.FindObjectOfType<GameController>();
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
 
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<CharacterAnimation>().Kill();
            if(gc)gc.UpdateScore(owner.GetComponent<Character>().playerID);
            owner.GetComponent<CharacterAnimation>().canAttack = false;
            owner.GetComponent<CharacterMovement>().canMove= false;

        }
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject != owner)
        {
            other.gameObject.GetComponent<CharacterAnimation>().Kill();
            if (gc) gc.UpdateScore(owner.GetComponent<Character>().playerID);
            //owner.GetComponent<CharacterAnimation>().canAttack = false;
            owner.GetComponent<CharacterMovement>().canMove = false;
            owner.GetComponent<CharacterAnimation>().canAttack = false;
            owner.GetComponent<CharacterMovement>().canMove = false;
            owner.GetComponent<Rigidbody>().velocity = (new Vector3(0, 0, 0));

            Destroy(gameObject);

        }



    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && collision.gameObject != owner)
        {
            collision.gameObject.GetComponent<CharacterAnimation>().Kill();
            if (gc) gc.UpdateScore(owner.GetComponent<Character>().playerID);
            //owner.GetComponent<CharacterAnimation>().canAttack = false;
            owner.GetComponent<CharacterMovement>().canMove = false;
            collision.gameObject.GetComponent<Rigidbody>().velocity  = (new Vector3(0, 0, 0));
            owner.GetComponent<CharacterAnimation>().canAttack = false;
            owner.GetComponent<CharacterMovement>().canMove = false;
            owner.GetComponent<Rigidbody>().velocity = (new Vector3(0, 0, 0));
            Destroy(gameObject);


        }
        Destroy(gameObject);


    }



    void RemoveObject()
    {
    }
}

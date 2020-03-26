﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 7.0f; 
    public int damage = 1; 
    
    void Update() { 
        transform.Translate(0, 0, speed * Time.deltaTime); 
    }
    void OnTriggerEnter(Collider other) {
        CharacterController player = other.GetComponent<CharacterController>(); 
        if (player != null) { 
            Debug.Log("Player hit"); 
        } 
        Destroy(this.gameObject); 
    }
}


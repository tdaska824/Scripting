using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC: MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;
    void Start()
    {
        health += level;
        // Updates the health of npc

        print("Updated health: " + health);
        //prints health to the console 
    }
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;


    }

}

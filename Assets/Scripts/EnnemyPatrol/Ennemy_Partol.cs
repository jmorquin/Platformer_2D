using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy_Partol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    public SpriteRenderer graphics ; 
    private Transform target;
    private int destPoint= 0 ; 

    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        

        //Si l'ennemie est quasiment arrivé à sa destination 
        if (Vector3.Distance(transform.position, target.position) < 0.3f) 
        
        {
        destPoint=(destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
            graphics.flipX = !graphics.flipX;
        }
    }
}

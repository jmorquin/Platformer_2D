using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public int health;
    public float speed;
    private float dazedTime;
    public Transform[] waypoints;
    public SpriteRenderer graphics;
    private Transform target;
    private int destPoint = 0;

    [SerializeField]private float startdazedTime;
     
    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {

        if(dazedTime<=0) 
        
        {
            speed = 1;
        }
        else 
        
        {
            speed = 0;
            dazedTime -= Time.deltaTime;
                
        }
        
        if (health <= 0) 
         
        { 
        Destroy(gameObject);
        }

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)

        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
            graphics.flipX = !graphics.flipX;

            

        }
    }

    public void TakeDamage(int damage) 
    {
        dazedTime = startdazedTime;
        health -= damage;
        Debug.Log("damage TAKEN");


    }
}

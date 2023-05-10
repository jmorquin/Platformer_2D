using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy_Partol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    public SpriteRenderer graphics ;
    public int health;
    private float dazedTime;
    [SerializeField] private float startdazedTime;

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
        if (dazedTime <= 0)

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
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed* Time.deltaTime,Space.World);

        //Si l'ennemie est quasiment arrivé à sa destination 
        if (Vector3.Distance(transform.position, target.position) < 0.3f) 
        
        {
        destPoint=(destPoint + 1) % waypoints.Length;
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

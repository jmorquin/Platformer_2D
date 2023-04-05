using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("coucou");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponentInChildren<Health>().pv += 10;
            Destroy(gameObject);
        }
    }
}

using UnityEngine;
using System.Collections; 

public class DeathZone : MonoBehaviour
{
    private Transform PlayerSpawn;
    private Animator fadeSysteme; 

    private void Awake()
    {
        PlayerSpawn = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
        fadeSysteme = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        
        {
            StartCoroutine(ReplacePlayer(collision)); 
        }
    }

    private IEnumerator ReplacePlayer(Collider2D collision) 
    
    {
        fadeSysteme.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f); 
        collision.transform.position = PlayerSpawn.position;
    }
}

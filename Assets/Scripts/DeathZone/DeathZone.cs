using UnityEngine;
using System.Collections; 

public class DeathZone : MonoBehaviour
{
    private Transform PlayerSpawn;
    private Animator fadeSystem; 

    private void Awake()
    {
        PlayerSpawn = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        
        {
            Debug.Log("Mort");
            StartCoroutine(ReplacePlayer(collision));
            fadeSystem.SetBool("FadeIn",true);
            fadeSystem.SetBool("respawn", false);

        }
    }

    private IEnumerator ReplacePlayer(Collider2D collision) 
    
    {
        
        yield return new WaitForSeconds(1f); 
        collision.transform.position = PlayerSpawn.position;
        fadeSystem.SetBool("respawn", true);
        fadeSystem.SetBool("FadeIn", false);
    }
}

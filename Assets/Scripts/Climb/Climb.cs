using UnityEngine;

public class Climb : MonoBehaviour
{
    private float vertical;
    private float speed = 8f;
    private bool isMur;
    private bool isClimbing;
    


    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");

        if (isMur && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Climbing", true);
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Climbing", true);
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
            
        }
        else
        {
            rb.gravityScale = 4f;
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Climbing", false);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mur"))
        { 
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Climbing", true);
            isMur = true;
           

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Mur"))
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("Climbing", false);
            isMur = false;
            isClimbing = false;
            

        }
    }
}


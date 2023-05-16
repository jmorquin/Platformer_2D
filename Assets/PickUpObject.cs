using UnityEngine;

public class PickUpObject : MonoBehaviour
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            //Inventory.instance.AddCoins(1);
            FindObjectOfType<Inventory>().AddCoins(1);
            //GetComponent<Inventory>().AddCoins(2);
            Destroy(gameObject);
        }
    }
}

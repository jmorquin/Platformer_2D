using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private int CoinsCount;
    [SerializeField] private Text CoinsCountText ;

    public static Inventory instance;

    private void Awake()
    {
        if (instance == null)
        {

            Debug.LogWarning("Il y a plus d'une instance de Inventory dans la scène");
            return;
        }
        instance = this; 
    }

    public void AddCoins (int count) 
    
    {
        CoinsCount += count;
        CoinsCountText.text = CoinsCount.ToString();
    }
}

using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public float coins = 0;
    public TMP_Text coinText;

    private void Start()
    {
        coinText.text = coins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins++;
            coinText.text = coins.ToString();
            Destroy(collision.gameObject);
        }
    }
}

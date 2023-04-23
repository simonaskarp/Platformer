using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    public Transform startPos;
    public float resetOnHeight = -10;
    public TMP_Text healthText;
    public AudioSource deathSound;

    private void Start()
    {
        healthText.text = health.ToString();
    }

    private void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("Death");
        }

        if (transform.position.y <= resetOnHeight)
        {
            gameObject.transform.position = startPos.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Enemy")) return;

        health--;
        deathSound.Play();
        gameObject.transform.position = startPos.position;
        healthText.text = health.ToString();
    }
}

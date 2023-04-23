using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTeleport : MonoBehaviour
{
    SpriteRenderer sprite;
    public float teleportTime = 1;
    public float teleportTimeLeft;
    public string nextLevel;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        teleportTimeLeft = teleportTime;
    }

    private void Update()
    {
        sprite.color = new Color(1, 1, 1, teleportTimeLeft);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.CompareTag("Teleporter")) return;

        teleportTimeLeft -= Time.deltaTime;
        if (teleportTimeLeft <= 0)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Teleporter")) return;

        teleportTimeLeft = teleportTime;
    }
}

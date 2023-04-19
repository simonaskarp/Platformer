using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public Collector playerCollector;
    public int coinsToTeleport = 3;
    CapsuleCollider2D coll;
    SpriteRenderer sprite;

    void Start()
    {
        //gameObject.SetActive(false);
        coll = GetComponent<CapsuleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        coll.enabled = false;
        sprite.enabled = false;
    }

    
    void Update()
    {
        if(playerCollector.coins >= coinsToTeleport)
        {
            coll.enabled = true;
            sprite.enabled = true;
        }
    }
}

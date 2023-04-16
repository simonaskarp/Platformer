using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public Collector playerCollector;
    public int nextLevelSceneNumber;
    CapsuleCollider2D coll;
    SpriteRenderer sprite;

    void Start()
    {
        coll = GetComponent<CapsuleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        coll.enabled = false;
        sprite.enabled = false;
    }

    
    void Update()
    {
        if(playerCollector.coins == 3)
        {
            coll.enabled = true;
            sprite.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextLevelSceneNumber);
    }
}

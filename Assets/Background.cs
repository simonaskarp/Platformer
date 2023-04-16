using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 1;

    private void Update()
    {
        var pos = Camera.main.transform.position;
        pos.z = 0;
        transform.position = pos * speed;
    }
}

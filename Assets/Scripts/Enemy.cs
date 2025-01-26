using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 3.0f;
    Vector2 direction = new Vector2(1, 1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "xWall")
        {
            direction.x *= -1;
        }
        else if (collision.gameObject.tag == "yWall")
        {
            direction.y *= -1;
        }
    }
}

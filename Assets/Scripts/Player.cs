using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour
{
    private float _speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector2 direction = new Vector2(horizontalInput, verticalInput);
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}

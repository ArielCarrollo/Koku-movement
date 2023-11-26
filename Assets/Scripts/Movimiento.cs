using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float Speed;
    public float Horizontal;
    public float Vertical;
    private SpriteRenderer _compSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        transform.position = new Vector2(transform.position.x + Speed * Horizontal * Time.deltaTime, transform.position.y + Speed * Vertical * Time.deltaTime);
    }
}

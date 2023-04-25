using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrao : MonoBehaviour
{
    private Rigidbody2D mi;
    private float movFu=150f;
    // Start is called before the first frame update
    void Start()
    {
        mi=GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float movX = 0;
        movX = caminar(movX);
        voltearPersonaje(movX);

    }

    float caminar(float movX)
    {
        movX= Input.GetAxisRaw("Horizontal");
        Vector2 posicionJug = transform.position;

        posicionJug = posicionJug + new Vector2(movX, 0f) * movFu * Time.deltaTime;

        transform.position = posicionJug;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mi.AddForce(new Vector2(0f, movFu), ForceMode2D.Impulse);
        }

        return movX;
    }

    void voltearPersonaje(float movX)
    {
        if (movX<0)
        {
            transform.localScale = new Vector3(-27f, 22, 1);
        }
        if (movX > 0)
        {
            transform.localScale = new Vector3(27f, 22, 1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJoys : MonoBehaviour
{
    public Joystick joystick;
    public int velocidad;
    public Rigidbody2D rb;
    public bool conFisica;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector2 direccion = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;

        if (conFisica)
        {
            rb.AddForce(direccion * velocidad * Time.deltaTime, ForceMode2D.Impulse);
        }
        else
        {
            gameObject.transform.Translate(direccion * velocidad * Time.deltaTime);
        }
    }
}

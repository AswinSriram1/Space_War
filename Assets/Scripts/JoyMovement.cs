using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyMovement : MonoBehaviour
{
    protected Joystick joystick;
    protected Joybutton joybutton;
    [SerializeField] float speed;
    [SerializeField] GameObject dot;
    [SerializeField] GameObject circle;
    Vector3 moveDirection;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        //rigidbody.velocity = new Vector3(joystick.Horizontal * speed, rigidbody.velocity.y, joystick.Vertical * speed);
        moveDirection = (dot.transform.position - circle.transform.position).normalized;
        rb.velocity = moveDirection * speed;

    }
}

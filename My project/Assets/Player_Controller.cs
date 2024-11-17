using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    int liczbacalkowita; // np. 1,2,54,76
    float liczbaprzecinkowa = 0.1f; // np, 4.32423, 56.23423

    public float speed = 5;

    public float forwardForce = 1000f;

    public Rigidbody rigidbody;

    public Transform startPoint;

    public int zebranePunkty;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();


        //Wszystko co tutaj zamiescimy wykonuje sie podczas staru gry/aplikacji

        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") != 0)
        {
            float directionHorizontal = Input.GetAxis("Horizontal");
            rigidbody.AddForce(directionHorizontal * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            float directionVertical = Input.GetAxis("Vertical");
            rigidbody.AddForce(0, 0, directionVertical * Time.deltaTime * speed, ForceMode.Impulse);
        }

        if (transform.position.y < -5)
        {
            transform.position = startPoint.position;
            rigidbody.velocity = Vector3.zero;
        }


    }
        



}


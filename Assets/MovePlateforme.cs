using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlateforme : MonoBehaviour
{
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector3 direction = new Vector3(0f, 0f, 1f);
        float speed = 2f;

  


        if (transform.position.z <= 4.5f)
        {
          direction = new Vector3(0f, 0f, -1f);
        }
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;


        rigidbody.MovePosition(newPosition);
    }
}

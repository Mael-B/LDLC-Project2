using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 spawn;
    
    void Start()
    {
        spawn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1)
        {
            transform.position = spawn;
        }

    }
}

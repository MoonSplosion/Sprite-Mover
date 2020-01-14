using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFacement : MonoBehaviour
{
    public Transform Transform;
    public float movementspeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * movementspeed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * movementspeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * movementspeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * movementspeed;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float JumpDistance = 1;
    public SpriteFacement SpriteFacement;
    // Start is called before the first frame update
    void Start()
    {
        SpriteFacement = GetComponent<SpriteFacement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += transform.up * JumpDistance;
            SpriteFacement.enabled = false;

        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyUp(KeyCode.UpArrow))
        {
            SpriteFacement.enabled = true;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position -= transform.up * JumpDistance;
            SpriteFacement.enabled = false;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyUp(KeyCode.DownArrow))
        {
            SpriteFacement.enabled = true;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * JumpDistance;
            SpriteFacement.enabled = false;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyUp(KeyCode.LeftArrow))
        {
            SpriteFacement.enabled = true;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += transform.right * JumpDistance;
            SpriteFacement.enabled = false;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyUp(KeyCode.RightArrow))
        {
            SpriteFacement.enabled = true;
        }

    }
}

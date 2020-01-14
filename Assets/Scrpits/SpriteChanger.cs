using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //Declare Variables before starting code
    public SpriteRenderer theRenderer;
    //Variable for color
    public Color spriteColor;
    //Variable for transform 
    public Transform tf;
    //Variable for the Speed of the object
    public float speedscale = .2f;
    //Speed of object on x axis
    public float speedx = 1;
    //Speed of object on y axis
    public float speedy = 1;
    //Speed of object on z axis
    public float speedz = 1;
    // Start is called before the first frame update
    void Start()
    {
                 //Change the color value of our SpriteRenderer component to red
                 //theRenderer.color = Color.red;
        //Change the color from our color picker to that the alpha is one
        spriteColor.a = 1.0f;
        if(theRenderer != null){
            //Change the color of sprite inside Unity
            theRenderer.color = spriteColor;
        }
        //load the SpriteRenderer component from the same object the component is on
        theRenderer = gameObject.GetComponent<SpriteRenderer>();
        //Get transform Component
        tf = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //Creates a new vector based on the magnitude given to it by the variables
        Vector3 myVector = new Vector3(speedx, speedy, speedz);
        //makes the vector shange it's speed based on the speed given to it by the speedscale variable
        tf.position = tf.position + (myVector * speedscale);
        //Move up a certain distance per frame
        //tf.position += Vector3.up * .02f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //Declare Variables before starting code
    public SpriteRenderer theRenderer;
    //Variable for color
    public Color spriteColor;
    // Start is called before the first frame update
    void Start()
    {
        //Change the color from our color picker to that the alpha is one
        spriteColor.a = 1.0f;
        if(theRenderer != null){
            //Change the color of sprite inside Unity
            theRenderer.color = spriteColor;
        }
        //load the SpriteRenderer component from the same object the component is on
        theRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

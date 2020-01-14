using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDisableMovement : MonoBehaviour
{
    public SpriteFacement SpriteFreeMove;
    public SpriteMovement SpriteJumpMove;
    public GameObject EasterEgg;
    // Start is called before the first frame update
    void Start()
    {
        SpriteFreeMove = GetComponent<SpriteFacement>();
        SpriteJumpMove = GetComponent<SpriteMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SpriteFreeMove.enabled = !SpriteFreeMove.enabled;
            SpriteJumpMove.enabled = !SpriteJumpMove.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            EasterEgg.SetActive(false);
        }
 
    }
}

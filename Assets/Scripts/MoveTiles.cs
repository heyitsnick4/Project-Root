using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTiles : MonoBehaviour
{
    private Globals global;
    private SpriteRenderer tile1;
    private SpriteRenderer tile2;
    private SpriteRenderer tile3;
    private SpriteRenderer tile4;

    private void Awake()
    {
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
        tile1 = transform.Find("MoveTile (1)").GetComponent<SpriteRenderer>();
        tile2 = transform.Find("MoveTile (2)").GetComponent<SpriteRenderer>();
        tile3 = transform.Find("MoveTile (3)").GetComponent<SpriteRenderer>();
        tile4 = transform.Find("MoveTile (4)").GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (global.playerCurrentPos <= 4)
        {
            tile1.enabled = false;
        }
        else
        {
            tile1.enabled = true;
        }

        if (global.playerCurrentPos % 4 == 0)
        {
            tile2.enabled = false;
        }
        else
        {
            tile2.enabled = true;
        }

        if (global.playerCurrentPos >= 17)
        {
            tile3.enabled = false;
        }
        else
        {
            tile3.enabled = true;
        }

        if (global.playerCurrentPos % 4 == 1)
        {
            tile4.enabled = false;
        }
        else
        {
            tile4.enabled = true;
        }
    }
}

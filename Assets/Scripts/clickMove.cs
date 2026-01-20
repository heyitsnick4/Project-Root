using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMove : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] private int tileNo;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject dead1;
    [SerializeField] private GameObject dead2;
    private Vector3 clickPos = new Vector3(-1.5f, -0.26f, -1f);
    private Globals global;
    private GameObject PlayerCharacter;
    private bool deadTile;

    private void Awake()
    {
        PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
        deadTile = false;
    }

    //checks for player input and moves player to correct tile taking away 1 ap
    void OnMouseOver()
    {
        if (global.playerTurn)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (global.moving && global.AP > 0)
                {
                    if (tileNo == global.playerCurrentPos - 1 || tileNo == global.playerCurrentPos + 1 || tileNo == global.playerCurrentPos - 4 || tileNo == global.playerCurrentPos + 4)
                    {
                        if (tileNo != global.enemy1CurrentPos && tileNo != global.enemy2CurrentPos)
                        {
                            clickPos = transform.position;
                            PlayerCharacter.transform.position = new Vector3(clickPos.x, clickPos.y, -2);
                            global.playerCurrentPos = tileNo;
                            PlayerCharacter.GetComponent<AudioSource>().Play();
                            global.AP--;
                            global.APCounter.text = "AP: " + global.AP;
                        }
                        
                    }
                }
            }
        }
    }

    void Update()
    {
        //if enemy dies on tile it becomes inactive
        if(tileNo == global.deathCheck1 || tileNo == global.deathCheck2)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            deadTile = true;
        }

        //if enemy moves onto a dead tile it calls for a different direction 
        if(deadTile)
        {
            if(enemy.transform.position.x == transform.position.x && enemy.transform.position.y == transform.position.y)
            {
                global.lastMove = true;
            }
            else if(enemy2.transform.position.x == transform.position.x && enemy2.transform.position.y == transform.position.y)
            {
                global.lastMove2 = true;
            }
        }
    }
}

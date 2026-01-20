using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHitdetection : MonoBehaviour
{
    private Globals global;
    private GameObject PlayerCharacter;
    private GameObject enemyCharacter1;
    private GameObject enemyCharacter2;
    private Vector3 enemyPos = new Vector3(-1.5f, -0.26f, -1f);
    [SerializeField]private GameObject dead1;
    [SerializeField]private GameObject dead2;
    [SerializeField]private GameObject text;

    private void Awake()
    {
        PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
        enemyCharacter1 = GameObject.Find("Enemy1");
        enemyCharacter2 = GameObject.Find("Enemy2");
        global = GameObject.FindGameObjectWithTag("GameController").GetComponent<Globals>();
    }


    // Update is called once per frame
    void Update()
    {
        if (global.shotCheck)
        {
            //checking if player can shoot enemy, shoots laser, kills enemy
            if (PlayerCharacter.transform.localPosition.y == enemyCharacter1.transform.localPosition.y && PlayerCharacter.transform.localPosition.x > enemyCharacter1.transform.localPosition.x && global.shotDirection == Globals.direction.left)
            {
                enemyPos = enemyCharacter1.transform.position;
                dead1.transform.position = new Vector3(enemyPos.x, enemyPos.y, -2);
                dead1.GetComponent<SpriteRenderer>().enabled = true;
                enemyCharacter1.GetComponent<SpriteRenderer>().enabled = false;
                enemyCharacter1.GetComponent<AudioSource>().Play();
                Destroy(text);
                global.enemiesLeft--;
                global.shotCheck = false;
                global.deathCheck1 = global.enemy1CurrentPos;
                global.playerTurn = true;
                global.death1 = true;
                global.AP++;
                global.APCounter.text = "AP: " + global.AP;
            }
            else if (PlayerCharacter.transform.localPosition.y == enemyCharacter1.transform.localPosition.y && PlayerCharacter.transform.localPosition.x < enemyCharacter1.transform.localPosition.x && global.shotDirection == Globals.direction.right)
            {
                enemyPos = enemyCharacter1.transform.position;
                dead1.transform.position = new Vector3(enemyPos.x, enemyPos.y, -2);
                dead1.GetComponent<SpriteRenderer>().enabled = true;
                enemyCharacter1.GetComponent<SpriteRenderer>().enabled = false;
                enemyCharacter1.GetComponent<AudioSource>().Play();
                Destroy(text);
                global.enemiesLeft--;
                global.shotCheck = false;
                global.deathCheck1 = global.enemy1CurrentPos;
                global.playerTurn = true;
                global.death1 = true;
                global.AP++;
                global.APCounter.text = "AP: " + global.AP;
            }
            else if (PlayerCharacter.transform.localPosition.x == enemyCharacter1.transform.localPosition.x && PlayerCharacter.transform.localPosition.y > enemyCharacter1.transform.localPosition.y && global.shotDirection == Globals.direction.down)
            {
                enemyPos = enemyCharacter1.transform.position;
                dead1.transform.position = new Vector3(enemyPos.x, enemyPos.y, -2);
                dead1.GetComponent<SpriteRenderer>().enabled = true;
                enemyCharacter1.GetComponent<SpriteRenderer>().enabled = false;
                enemyCharacter1.GetComponent<AudioSource>().Play();
                Destroy(text);
                global.enemiesLeft--;
                global.shotCheck = false;
                global.deathCheck1 = global.enemy1CurrentPos;
                global.playerTurn = true;
                global.death1 = true;
                global.AP++;
                global.APCounter.text = "AP: " + global.AP;
            }
            else if (PlayerCharacter.transform.localPosition.x == enemyCharacter1.transform.localPosition.x && PlayerCharacter.transform.localPosition.y < enemyCharacter1.transform.localPosition.y && global.shotDirection == Globals.direction.up)
            {
                enemyPos = enemyCharacter1.transform.position;
                dead1.transform.position = new Vector3(enemyPos.x, enemyPos.y, -2);
                dead1.GetComponent<SpriteRenderer>().enabled = true;
                enemyCharacter1.GetComponent<SpriteRenderer>().enabled = false;
                enemyCharacter1.GetComponent<AudioSource>().Play();
                Destroy(text);
                global.enemiesLeft--;
                global.shotCheck = false;
                global.deathCheck1 = global.enemy1CurrentPos;
                global.playerTurn = true;
                global.death1 = true;
                global.AP++;
                global.APCounter.text = "AP: " + global.AP;
            }
            if (PlayerCharacter.transform.localPosition.y == enemyCharacter2.transform.localPosition.y && PlayerCharacter.transform.localPosition.x > enemyCharacter2.transform.localPosition.x && global.shotDirection == Globals.direction.left)
            {
                enemyPos = enemyCharacter2.transform.position;
                dead2.transform.position = new Vector3(enemyPos.x, enemyPos.y, -2);
                dead2.GetComponent<SpriteRenderer>().enabled = true;
                Destroy(enemyCharacter2);
                enemyCharacter2.GetComponent<AudioSource>().Play();
                global.enemiesLeft--;
                global.shotCheck = false;
                global.deathCheck2 = global.enemy2CurrentPos;
                global.AP++;
                global.APCounter.text = "AP: " + global.AP;
            }
            else if (PlayerCharacter.transform.localPosition.y == enemyCharacter2.transform.localPosition.y && PlayerCharacter.transform.localPosition.x < enemyCharacter2.transform.localPosition.x && global.shotDirection == Globals.direction.right)
            {
                enemyPos = enemyCharacter2.transform.position;
                dead2.transform.position = new Vector3(enemyPos.x, enemyPos.y, -2);
                dead2.GetComponent<SpriteRenderer>().enabled = true;
                Destroy(enemyCharacter2);
                enemyCharacter2.GetComponent<AudioSource>().Play();
                global.enemiesLeft--;
                global.shotCheck = false;
                global.deathCheck2 = global.enemy2CurrentPos;
                global.AP++;
                global.APCounter.text = "AP: " + global.AP;
            }
            else if (PlayerCharacter.transform.localPosition.x == enemyCharacter2.transform.localPosition.x && PlayerCharacter.transform.localPosition.y > enemyCharacter2.transform.localPosition.y && global.shotDirection == Globals.direction.down)
            {
                enemyPos = enemyCharacter2.transform.position;
                dead2.transform.position = new Vector3(enemyPos.x, enemyPos.y, -2);
                dead2.GetComponent<SpriteRenderer>().enabled = true;
                Destroy(enemyCharacter2);
                enemyCharacter2.GetComponent<AudioSource>().Play();
                global.enemiesLeft--;
                global.shotCheck = false;
                global.deathCheck2 = global.enemy2CurrentPos;
                global.AP++;
                global.APCounter.text = "AP: " + global.AP;
            }
            else if (PlayerCharacter.transform.localPosition.x == enemyCharacter2.transform.localPosition.x && PlayerCharacter.transform.localPosition.y < enemyCharacter2.transform.localPosition.y && global.shotDirection == Globals.direction.up)
            {
                enemyPos = enemyCharacter2.transform.position;
                dead2.transform.position = new Vector3(enemyPos.x, enemyPos.y, -2);
                dead2.GetComponent<SpriteRenderer>().enabled = true;
                Destroy(enemyCharacter2);
                enemyCharacter2.GetComponent<AudioSource>().Play();
                global.enemiesLeft--;
                global.shotCheck = false;
                global.deathCheck2 = global.enemy2CurrentPos;
                global.AP++;
                global.APCounter.text = "AP: " + global.AP;
            }
            else
            {
                global.shotCheck = false;
                global.playerTurn = true;
            }
        }
        if (global.enemiesLeft == 0)
        {
            StartCoroutine(WaitForLaser());
        }
    }

    //waits for laser animation to finish before win screen
    IEnumerator WaitForLaser()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        global.win = true;
    }
}

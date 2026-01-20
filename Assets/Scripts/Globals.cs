using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Globals : MonoBehaviour
{
    public int playerCurrentPos;
    public int enemy1CurrentPos;
    public int enemy2CurrentPos;
    public int AP;
    public int turn;
    public int enemy1AP;
    public int enemy2AP;
    public int enemiesLeft;
    public int deathCheck1;
    public int deathCheck2;
    public int lastStore;
    public int lastStore2;
    [SerializeField] public Text APCounter;
    [SerializeField] public Text turnCounter;
    public bool moving;
    public enum direction { up, left, down, right };
    public direction shotDirection;
    public bool playerTurn;
    public bool shotCheck;
    public bool lose;
    public bool win;
    public bool death1;
    public bool lastMove;
    public bool lastMove2;
    private GameObject popup;
    private GameObject btnNext;
    private GameObject txtLose;

    private void Awake()
    {
        playerCurrentPos = 17;
        AP = 3;
        turn = 1;
        APCounter.text = "AP: " + AP.ToString();
        turnCounter.text = "Turn " + turn.ToString();
        moving = true;
        shotDirection = direction.up;
        enemy1CurrentPos = 4;
        enemy1AP = 1;
        enemy2CurrentPos = 2;
        enemy2AP = 1;
        enemiesLeft = 2;
        playerTurn = true;
        shotCheck = false;
        win = false;
        lose = false;
        popup = GameObject.Find("Popup");
        btnNext = GameObject.Find("btnNext");
        txtLose = GameObject.Find("txtLose");
        deathCheck1 = 0;
        deathCheck2 = 0;
        death1 = false;
        lastMove = false;
        lastStore = 0;
        lastMove2 = false;
        lastStore2 = 0;
    }

    private void Update()
    {
        if (win)
        {
            popup.SetActive(true);
            btnNext.SetActive(true);
            txtLose.SetActive(false);
        }
        else if (lose)
        {
            popup.SetActive(true);
            btnNext.SetActive(false);
            txtLose.SetActive(true);
        }
        else
        {
            popup.SetActive(false);
        }
    }
}

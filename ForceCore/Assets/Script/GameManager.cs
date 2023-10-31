using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("# Player Info")]
    public int health;
    public int maxHealth = 100;

    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = { 3, 5, 10, 100, 150, 210, 280, 360, 450, 600 };

    [Header("# Gmae Control")]
    public float gameTime;
    public float maxGameTime = 1 * 90f; //1 minutes 30 seconds

    [Header("# Gmae Object")]
    public PoolManager pool;
    public Player player;

    void Awake()
    {
        instance = this;    
    }

    void Start()
    {
        health = maxHealth;
    }

    //스테이지 진행시간
    void Update()
    {
        gameTime += Time.deltaTime;
        if (gameTime > maxGameTime)
        {
            gameTime = 0;
        }

    }

    public void GetExp()
    {
        exp++;

        if(exp == nextExp[level])
        {
            level++;
            exp = 0;
        }
    }

}

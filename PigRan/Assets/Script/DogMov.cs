using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DogMov : MonoBehaviour
{
    private Rigidbody2D Dog;
    public GameObject DogUp;
    public GameObject DogDaun;
    public GameObject DogLeft;
    public GameObject DogRiпрt;
    public float TaimLok;
    private float Tamer;


    void Start()
    {
        Dog = GetComponent<Rigidbody2D>();
        Tamer = TaimLok;
    }

    // Update is called once per frame
    void Update()
    {
        Tamer -= Time.deltaTime;
        if (Tamer < 0)
        {
            Mov();
            Tamer = TaimLok;
        }
        
    }
    //Генерирует скорасть и напровления движение бота
    private int Random()
    {
        System.Random rnd = new System.Random();
        return (rnd.Next(1, 5));
        
    }
    //Движение бота
    private void Mov()
    {
        switch (Random())
        {
            case 1:
                Res();
                DogUp.SetActive(true);
                Dog.velocity = new Vector2(0, Random());
                break;
            case 2:
                Res();
                DogDaun.SetActive(true);
                Dog.velocity = new Vector2(0,-Random());
                break;
            case 3:
                Res();
                DogLeft.SetActive(true);
                Dog.velocity = new Vector2(-Random(), 0);
                break;
            case 4:
                Res();
                DogRiпрt.SetActive(true);
                Dog.velocity = new Vector2(Random(), 0);
                break;

            default:
                break;
        }
    }
    //сбрасывает напровление бота
    public void Res()
    {
        DogUp.SetActive(false);
        DogDaun.SetActive(false);
        DogLeft.SetActive(false);
        DogRiпрt.SetActive(false);
    }
}

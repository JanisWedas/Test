using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomc : MonoBehaviour
{
    public GameObject BombOdj;
    public float TamerBomb;
    public float TamerEfect;
    public GameObject Bomb;
    public GameObject BombEfect;

    void Update()
    {
        if (TamerBomb > 0)
            TamerBomb -= Time.deltaTime;

        if (TamerBomb < 0 )
            Boom();

    }
    //Бомба
    private void Boom ()
    {
        TamerEfect -= Time.deltaTime;
        Bomb.SetActive(false);
        BombEfect.SetActive(true);
        if (TamerEfect < 0)
            Destroy(BombOdj);
    }
}

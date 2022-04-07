using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Bombs;
    public GameObject Bodi;

    public void Spavn()
    {
        Instantiate(Bombs[0],Bodi.transform.position, Quaternion.identity);
    }
}

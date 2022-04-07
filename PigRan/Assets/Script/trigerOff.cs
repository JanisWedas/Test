using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerOff : MonoBehaviour
{
    public GameObject Triger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Проверка на припятсявие
        if (collision.tag == "Ter")
        {
            Triger.SetActive(false);
        }
    }
}

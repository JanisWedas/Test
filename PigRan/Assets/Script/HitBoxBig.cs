using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxBig : MonoBehaviour
{
    public GameObject End;
    public GameObject Ui;
    private void OnTriggerStay2D(Collider2D collision)
    {
        //–кгистраци€ дамага и смерть
        if(collision.tag == "Boom")
        {
            Destroy(gameObject);
            End.SetActive(true);
            Ui.SetActive(false);

        }
    }
   
}

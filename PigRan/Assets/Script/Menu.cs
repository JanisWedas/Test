using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Ui;
    public GameObject Joustik;
    public GameObject Banons;
    public GameObject MenuOp;
    // Start is called before the first frame update
   public void OpenMenu()
    {
        MenuOp.SetActive(true);
        Time.timeScale = 0;
        Ui.SetActive(false);
    }
    // ВЫбор элемента упровления
    public void OnJouststik()
    {
        Ui.SetActive(true);
        Joustik.SetActive(true);
        Banons.SetActive(false);
        MenuOp.SetActive(false);
        Time.timeScale = 1;
    }
    public void OnBaton()
    {
        Ui.SetActive(true);
        Joustik.SetActive(false);
        Banons.SetActive(true);
        MenuOp.SetActive(false);
        Time.timeScale = 1;
    }
    // Рестарт сцены
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +0);
    }
}

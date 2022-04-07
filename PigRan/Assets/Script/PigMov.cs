using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigMov : MonoBehaviour
{
    public float TaimMov;
    public float TaimReset;
    public GameObject canvas;
    public float sped;
    public Joystick joystick;
    public GameObject Baton;
    private Rigidbody2D bodi;
    public GameObject PigUp;
    public GameObject PigDown;
    public GameObject PigLeft;
    public GameObject PigRiпрt;
    void Start()
    {
        bodi = GetComponent<Rigidbody2D>();
        canvas.SetActive(true);
    }

    void Update()
    {

        if (!Baton.activeInHierarchy)
        {
            Mov();
        }
        //блокировка движения персонажа при помощи кнопак
        TaimReset -= Time.deltaTime;
        if (TaimReset < 0 && Baton.activeInHierarchy)
        {
            bodi.velocity = new Vector2(0, 0);
        }
    }
    //движение при помощи джостика
    private void Mov()
    {
        bodi.velocity = new Vector2(joystick.Horizontal * sped, joystick.Vertical * sped);
        Rot();
    }
    //Выбор напровления персонажа при помощи джостика
    private void Rot()
    {
       
        if (joystick.Vertical > 0 && (joystick.Vertical > joystick.Horizontal && joystick.Vertical > joystick.Horizontal * -1))
        {
            ResetPig();
            PigUp.SetActive(true);
            return;
        }
        if (joystick.Vertical < 0 && (joystick.Vertical* -1 > joystick.Horizontal * -1 || joystick.Vertical > joystick.Horizontal))
        {
            ResetPig();
            PigDown.SetActive(true);
            return;
        }
        if (joystick.Horizontal < 0 && (joystick.Vertical * -1 < joystick.Horizontal * -1 || joystick.Vertical < joystick.Horizontal))
        {
            ResetPig();
            PigLeft.SetActive(true);
            return;
        }
        if (joystick.Horizontal > 0 && (joystick.Vertical* -1  < joystick.Horizontal * -1 || joystick.Vertical < joystick.Horizontal))
        {
            ResetPig();
            PigRiпрt.SetActive(true);
            return;
        }
    }
    //Движение при помощи кнопак
    public void Up()
    {
        ResetPig();
        PigUp.SetActive(true);
        bodi.velocity = new Vector2(0, sped);
        TaimReset = TaimMov;

    }
    public void Daun()
    {
        ResetPig();
        PigDown.SetActive(true);
        bodi.velocity = new Vector2(0, -sped);
        TaimReset = TaimMov;
    }
    public void Left()
    {
        ResetPig();
        PigLeft.SetActive(true);
        bodi.velocity = new Vector2(-sped, 0);
        TaimReset = TaimMov;
    }
    public void Rinpt()
    {
        ResetPig();
        PigRiпрt.SetActive(true);
        bodi.velocity = new Vector2(sped, 0);
        TaimReset = TaimMov;
    }
    //Сброс напровления персонажа
    private void ResetPig()
    { 
        PigUp.SetActive(false);
        PigDown.SetActive(false);
        PigLeft.SetActive(false);
        PigRiпрt.SetActive(false);
    }
}

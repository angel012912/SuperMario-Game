/*
Author: Jose Angel Garcia Gomez
Date: 01-04-2022
Description: Pause and resume the game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuPausa : MonoBehaviour
{
    [SerializeField]
    private GameObject panelPausa;
    public bool estaPausado = false;

    public static MenuPausa instance;

    private void Awake()
    {
        instance = this;
    }

    public void Pausar()
    {
        estaPausado = !estaPausado;
        panelPausa.SetActive(estaPausado);
        Time.timeScale = estaPausado ? 0 : 1;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pausar();
        }
    }

}

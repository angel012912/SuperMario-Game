using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Jose Angel Garcia Gomez
 * Objetivo: Pausar y Reaunudar el juego
 */

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

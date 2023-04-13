/*
Author: Jose Angel Garcia Gomez
Date: 01-04-2022
Description: Manipulate the life images to represent the life of the character
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    public static HUD instance;
    
    public Image imagen1;
    public Image imagen2;
    public Image imagen3;

    public TextMeshProUGUI txtMonedas;

    public void Awake()
    {
        instance = this;
    }

    //M�todo para refrescar las vidas
    public void ActualizarVidas()
    {
        int vidas = SaludPersonaje.instance.vidas;
        switch (vidas)
        {
            case 2:
                imagen1.enabled = false;
                break;
            case 1:
                imagen2.enabled = false;
                break;
            case 0:
                imagen3.enabled = false;
                break;
        }
    }

    public void ActualizarContadorMonedas()
    {
        int monedas = SaludPersonaje.instance.monedas;
        txtMonedas.text = monedas.ToString();
    }
    
    public void Reanudar()
    {
        MenuPausa.instance.Pausar();
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 Autor: Jose Angel Garcia Gomez
Objetivo: Manipular las imágenes de vida para que represente la vida del personaje
 */

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

    //Método para refrescar las vidas
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

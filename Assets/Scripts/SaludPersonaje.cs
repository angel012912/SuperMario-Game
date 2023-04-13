using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  Autor: Jose Angel Garcia Gomez
  Mantiene la información de la salud del personaje (vidas)
 */


public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 3;

    public int monedas = 0;

    public static SaludPersonaje instance;

    private void Awake()
    {
        //This se refiere al objeto que esta usando a clase cuando se llama al método
        instance = this;
    }
}

/*
Author: Jose Angel Garcia Gomez
Date: 01-04-2022
Description: Manages the information of the health of the character (lives)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 3;

    public int monedas = 0;

    public static SaludPersonaje instance;

    private void Awake()
    {
        //This se refiere al objeto que esta usando a clase cuando se llama al m�todo
        instance = this;
    }
}

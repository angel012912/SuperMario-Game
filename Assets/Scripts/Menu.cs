/*
Author: Jose Angel Garcia Gomez
Date: 01-04-2022
Description: Program that Loads the scene when the user clicks on the play button
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Se ejecuta cuando el usuario da click sobre el boton jugar
    public void Jugar()
    {
        //Cargar la escena de Mario
        SceneManager.LoadScene("SampleScene");
    }
}

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

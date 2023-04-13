/*
Author: Jose Angel Garcia Gomez
Date: 01-04-2022
Description: Detects the collisions with the object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : MonoBehaviour
{
    [SerializeField]
    private AudioSource efectoMoneda;
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.gameObject.CompareTag("Player"))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true); 
            //Se obtiene primero el transform del objeto, luego se obtiene el hijo (explosion), se obtiene el transform del hijo y se establece si esta activo o no 
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.4f);
            //Cuenta las monedas recolectadas
            SaludPersonaje.instance.monedas++;
            HUD.instance.ActualizarContadorMonedas();
            efectoMoneda.Play();
        }
    }
}

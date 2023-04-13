using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Jose Angel Garcia Gomez A01745865
 * Detecta las colisiones con el objeto
 */
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

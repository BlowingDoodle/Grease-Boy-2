using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Inventario inventario = other.GetComponent<Inventario>();

        if (inventario != null)
        {
            inventario.MonedaRecolectada();
            gameObject.SetActive(false);    
        }
    }
}

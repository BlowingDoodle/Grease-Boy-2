using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventario : MonoBehaviour
{
    public int NumeroMonedas { get; private set; }

    public UnityEvent<Inventario> EventoRecoleccion;

    public void MonedaRecolectada()
    {
        NumeroMonedas++;
        EventoRecoleccion.Invoke(this);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InentarioUI : MonoBehaviour
{
    private TextMeshProUGUI monedaTexto;

    // Start is called before the first frame update
    void Start()
    {
        monedaTexto= GetComponent<TextMeshProUGUI>();
    }

    public void ActualizarTextoMonedas(Inventario inventario)
    {
        monedaTexto.text = inventario.NumeroMonedas.ToString();
    }
}

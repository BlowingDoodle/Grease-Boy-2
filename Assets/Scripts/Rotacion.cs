using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{

    [SerializeField] float velocidadx;
    [SerializeField] float velocidady;
    [SerializeField] float velocidadz;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * velocidadx * Time.deltaTime, 360 * velocidady * Time.deltaTime, 360 * velocidadz * Time.deltaTime);
    }
}

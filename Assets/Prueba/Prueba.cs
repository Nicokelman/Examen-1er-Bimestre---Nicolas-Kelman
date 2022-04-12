

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public string producto1;
    public string producto2;
    public string producto3;

    public float precio1;
    public float precio2;
    public float precio3;

    public int cant1;
    public int cant2;
    public int cant3;

    float descuento1;
    float descuento2;
    float descuento3;
    float descuentos;

    float montototalSinDescuento;
    float montototalConDescuento;

    // Start is called before the first frame update
    void Start()
    {
        if (precio1 < 1 || precio2 < 1 || precio3 < 1 || cant1 < 1 || cant2 < 1 || cant3 < 1)
        {
            Debug.Log("Error");
        }
        if (cant1 > 3)
        {
            descuento1 = precio1 * 0.20f;
        }
        if (cant2 > 3)
        {
            descuento2 = precio2 * 0.20f;
        }
        if (cant3 > 3)
        {
            descuento3 = precio3 * 0.20f;
        }

        montototalSinDescuento = precio1 + precio2 + precio3;

        descuentos = descuento1 + descuento2 + descuento3;

        montototalConDescuento = (precio1 - descuento1) + (precio2 - descuento2) + (precio3 - descuento3);

        Debug.Log("El monto total sin descuento es : " + montototalSinDescuento);

        Debug.Log("El monto de los descuentos aplicados es : " + descuentos);

        Debug.Log(" El monto total con los descuentos aplicados es : " + montototalConDescuento);
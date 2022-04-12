

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public string prod1;
    public string prod2;
    public string prod3;

    public float prec1;
    public float prec2;
    public float prec3;

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
        if (prec1 < 1 || prec2 < 1 || prec3 < 1 || cant1 < 1 || cant2 < 1 || cant3 < 1)
        {
            Debug.Log("Error");
        }
        if (cant1 > 3)
        {
            descuento1 = prec1 * 0.20f;
        }
        if (cant2 > 3)
        {
            descuento2 = prec2 * 0.20f;
        }
        if (cant3 > 3)
        {
            descuento3 = prec3 * 0.20f;
        }

        montototalSinDescuento = prec1 + prec2 + prec3;

        descuentos = descuento1 + descuento2 + descuento3;

        montototalConDescuento = (prec1 - descuento1) + (prec2 - descuento2) + (prec3 - descuento3);

        Debug.Log("El monto total sin descuento es : " + montototalSinDescuento);

        Debug.Log("El monto de los descuentos aplicados es : " + descuentos);

        Debug.Log(" El monto total con los descuentos aplicados es : " + montototalConDescuento);
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeria : MonoBehaviour
{
    public string GustoHelado;
    public int CantidadHelado;


    float PrecioHelado;


    // Start is called before the first frame update
    void Start()
    {
        if (CantidadHelado < 250 || CantidadHelado > 3000)
        {
            Debug.Log("Cantidad de helado no válida");
            return;
        }

        if (GustoHelado != "CHO" && GustoHelado != "DDL" && GustoHelado != "FRU")
        {
            Debug.Log("Código no válido");
            return;
        }

        PrecioHelado = CantidadHelado * (500 / 1000);

        if (GustoHelado == "FRU")
        {
            PrecioHelado = PrecioHelado - PrecioHelado * 0.1f;
        }

        Debug.Log("Debe abonar " + PrecioHelado);
    }


}

// Update is called once per frame
void Update()
{

}
}

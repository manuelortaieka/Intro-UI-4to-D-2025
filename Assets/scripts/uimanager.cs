using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uimanager : MonoBehaviour
{
    public TextMeshProUGUI resultado;
    public TMP_InputField IngresarClave;
    string claveCorrecta = "algo";
    string claveIng;
    
    // Start is called before the first frame update
    void Start()
    {
        resultado.text = "";   
    }
    public void checkClave()
    {
        claveIng = IngresarClave.text;
        if(claveIng == claveCorrecta)
        {
            resultado.text = "Clave correcta";
        }
        else
        {
            resultado.text = "Clave Incorrecta";
        }
    }

}

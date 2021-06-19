using UnityEngine;

public class ComponentModifier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Mi antiguo nombre es: " + gameObject.name); // Concatenación
        // String = Cadena de texto, es decir elementos de tipo caracter en cadena y se identifica con "Texto"
        gameObject.name = "Cilindro modificado";

        // Accediendo a un componente
        // Mediante un GetComponent y asignandolo a una variable temporal
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

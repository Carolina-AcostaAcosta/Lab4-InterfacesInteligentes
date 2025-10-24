using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecolectorEscudos : MonoBehaviour
{
    public TMP_Text textoPuntuacion;
    public TMP_Text textoRecompensa;
    private int puntuacion = 0;
    private int siguienteRecompensa = 100;

    private void Start()
    {
        if (textoPuntuacion != null)
            textoPuntuacion.text = "Puntuación: 0";
        if (textoRecompensa != null)
            textoRecompensa.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        int puntos = 0;

        if (other.CompareTag("EscudoTipo1"))
            puntos = 50;
        else if (other.CompareTag("EscudoTipo2"))
            puntos = 75;

        if (puntos > 0)
        {
            puntuacion += puntos;
            Debug.Log($"Recolectaste {other.name}. Puntuación: {puntuacion}");

            if (textoPuntuacion != null) {
                textoPuntuacion.text = "Puntuación: " + puntuacion;
            }    
            if (puntuacion >= siguienteRecompensa) {
                if (textoRecompensa != null) {
                    textoRecompensa.text = $"¡Recompensa obtenida por {siguienteRecompensa} puntos!";
                }
                Debug.Log($"¡Recompensa obtenida por {siguienteRecompensa} puntos!");
                
                siguienteRecompensa += 100;
            }

            Destroy(other.gameObject);
        }
    }
}

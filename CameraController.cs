using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Referencia al GameObject del jugador.
    public GameObject jugador;

    // La distancia entre la cámara y el jugador.
    private Vector3 compensacion;

    // Start se llama antes del primer frame.
    void Start()
    {
        // Calcular la compensación inicial entre la posición de la cámara y la posición del jugador.
        compensacion = transform.position - jugador.transform.position;
    }

    // LateUpdate se llama una vez por frame después de que se hayan completado todas las funciones de actualización.
    void LateUpdate()
    {
        // Mantener la misma compensación entre la cámara y el jugador a lo largo del juego.
        transform.position = jugador.transform.position + compensacion;
    }
}

using UnityEngine;

public class Rotador : MonoBehaviour
{
    // Update se llama una vez por frame.
    void Update()
    {
        // Rotar el objeto en los ejes X, Y y Z por cantidades especificadas, ajustadas para la tasa de frames.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}

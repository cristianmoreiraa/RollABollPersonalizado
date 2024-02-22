using UnityEngine;

public class RotatorObstaculo : MonoBehaviour
{
    // Velocidad de rotación en el eje X
    public float rotateSpeedY = 15f;

    // Update se llama una vez por frame.
    void Update()
    {
        // Rotar el objeto en el eje X por la cantidad especificada, ajustada para la tasa de frames.
        transform.Rotate(new Vector3(0F, rotateSpeedY, 0f) * Time.deltaTime);
    }
}

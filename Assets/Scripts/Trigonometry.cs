using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigonometry : MonoBehaviour
{
    [SerializeField]
    private float frequency = 1.0f;   

    [SerializeField]
    private float waveLength = 1.0f;

    [SerializeField]
    private Text textResults;

    void Update()
    {
        // PI 3.141592653589793 -> half of a circle
        // PI 6.283185307179586 -> full circle
        float x = Mathf.Sin(2 * Mathf.PI * Time.time * frequency) * waveLength;
        float y = Mathf.Cos(2 * Mathf.PI * Time.time * frequency) * waveLength;
        transform.position = new Vector3(x, y, 0);

        textResults.text = $"Vector3: {transform.position}\n" +
            $"X = {x} Y = {y}\n" +
            $"PI = {Mathf.PI}\n" +
            $"PI = {Mathf.PI * 2}";
    }
}

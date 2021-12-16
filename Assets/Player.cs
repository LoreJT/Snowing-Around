using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10f;
    [SerializeField] float horizontalSpeed = 5f;

    private void Update()
    {
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * horizontalSpeed * Time.deltaTime;

        transform.Translate(0, speedAmount, 0);
        transform.Rotate(0, 0, rotationAmount);

    }
}

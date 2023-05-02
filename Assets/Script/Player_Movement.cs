using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject player;
    private float verticalInput;
    private float horizontalInput;

    private void Update()
    {
        PlayermMovement();
    }
    private void PlayermMovement()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(.0f, .0f, moveSpeed * verticalInput * Time.deltaTime));
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(moveSpeed * horizontalInput * Time.deltaTime,.0f, .0f));
    }
}

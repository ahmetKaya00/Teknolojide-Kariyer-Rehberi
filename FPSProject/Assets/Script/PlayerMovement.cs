using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;

    [Header("Hareket ve Fizik")]
    [SerializeField] private float _speed = 4f, _Xspeed = 6f, _gravity = -9.8f, _jump = 1f;

    [Header("Zemin Kontrol")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.3f;
    [SerializeField] private LayerMask grounMask;

    [Header("Yön ve Yer Çekimi")]
    Vector3 _velocity;
    private bool isGrounded;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, grounMask);

        if(isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        characterController.Move(move * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            characterController.Move(move * _Xspeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            _velocity.y = Mathf.Sqrt(_jump * -2f * _gravity);
        }

        _velocity.y += _gravity * Time.deltaTime;
        characterController.Move(_velocity * Time.deltaTime);
    }
}

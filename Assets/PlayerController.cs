using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    private CharacterController _controller;

    [SerializeField]
    private float gravity = -9.81f;

    [SerializeField] 
    private float jumpHeight = 3f;
    
    private Vector3 _velocity;
    
    
    public float moveSpeed;
    public float rotateSpeed;
    public GameObject projectile;
    
    private Vector2 m_Rotation;
    private Vector2 m_Look;
    private Vector2 m_Move;
    
    //Camera
    [SerializeField] private GameObject camera;
    
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private bool isGrounded;

    [SerializeField] private InputActionAsset controls;
    private InputActionMap _inputActionMap;
    
    //interaction event
    public delegate void InteractionInputHandler();
    public event InteractionInputHandler InteractPressed;

    public void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
        
        // Update orientation first, then move. Otherwise move orientation will lag
        // behind by one frame.
        Look(m_Look);
        Move(m_Move);
        
        _velocity.y += gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }
    
    public void Awake()
    {
        _controller = GetComponent<CharacterController>();
        GetComponent<PlayerInput>().SwitchCurrentControlScheme("Standard");
    }
    
    public void OnMove(InputAction.CallbackContext context)
    {
        m_Move = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        m_Look = context.ReadValue<Vector2>();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        //Debug.Log(context);
        if(context.started)
            Fire();
    }

    public void onCrouch(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            //transform.localScale =
            //   new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
            GetComponent<CharacterController>().height /= 2;
        } else if (context.canceled)
        {
            GetComponent<CharacterController>().height *= 2;
            GetComponent<CharacterController>().Move(new Vector3(0, 3, 0));

            // transform.localScale =
            //     new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);

        }
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump");
        if (context.started)
        {
            Debug.Log("started");
        }
        else if (context.performed)
        {
            Debug.Log("performed");
            if (isGrounded)
                _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        else if (context.canceled)
        {
            Debug.Log("canceled");
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            InteractPressed?.Invoke();
        }
    }



    private void Move(Vector2 direction)
    {
        if (direction.sqrMagnitude < 0.01)
            return;
        var scaledMoveSpeed = moveSpeed * Time.deltaTime;
        // For simplicity's sake, we just keep movement in a single plane here. Rotate
        // direction according to world Y rotation of player.
        var move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
        _controller.Move(move * scaledMoveSpeed);
        //transform.position += move * scaledMoveSpeed;
    }

    private void Look(Vector2 rotate)
    {
        if (rotate.sqrMagnitude < 0.01)
            return;
        var scaledRotateSpeed = rotateSpeed * Time.deltaTime;
        m_Rotation.y += rotate.x * scaledRotateSpeed;
        m_Rotation.x = Mathf.Clamp(m_Rotation.x - rotate.y * scaledRotateSpeed, -89, 89);
        camera.transform.localEulerAngles = new Vector3(m_Rotation.x, 0f, 0f);
        transform.rotation = Quaternion.Euler(0f, m_Rotation.y, 0f);
    }

    private IEnumerator BurstFire(int burstAmount)
    {
        for (var i = 0; i < burstAmount; ++i)
        {
            Fire();
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void Fire()
    {
        var transform = this.transform;
        var newProjectile = Instantiate(projectile);
        newProjectile.transform.position = camera.transform.position + transform.forward * 0.6f;
        newProjectile.transform.rotation = camera.transform.rotation;
        const int size = 1;
        newProjectile.transform.localScale *= size;
        newProjectile.GetComponent<Rigidbody>().mass = Mathf.Pow(size, 3);
        newProjectile.GetComponent<Rigidbody>().AddForce(camera.transform.forward * 50f, ForceMode.Impulse);
        newProjectile.GetComponent<MeshRenderer>().material.color =
            new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}

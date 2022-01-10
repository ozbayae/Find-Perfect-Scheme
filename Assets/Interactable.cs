using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private LayerMask playerLayer;

    private PlayerController _player;

    public delegate void InteractAction();
    public event InteractAction Interacted;

    public void Awake()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }

    public void OnEnable()
    {
        _player.InteractPressed += OnInteraction;
    }

    public void OnDisable()
    {
        _player.InteractPressed -= OnInteraction;
    }

    public void OnInteraction()
    {
        if (Physics.CheckSphere(transform.position, 5, playerLayer))
        {
            Interacted?.Invoke();
        }
    }
}

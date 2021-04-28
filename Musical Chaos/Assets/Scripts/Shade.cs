using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Shade : MonoBehaviour
{
    PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();
        controls.Gameplay.APressed.performed += ctx => Press();
    }

    void Press() 
    {
        transform.localScale *= 1.1f;
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
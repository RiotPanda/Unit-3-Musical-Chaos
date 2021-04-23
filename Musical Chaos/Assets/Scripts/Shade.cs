using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Shade : MonoBehaviour
{
    PlayerControls controls;

    public GameObject ButtonA;
    public bool ButtnA = false;

    void Awake()
    {
        controls = new PlayerControls();
        controls.Gameplay.APressed.performed += ctx => Press();
    }

    void Press() 
    {
        ButtnA = true;
        ButtonA.SetActive(true);
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

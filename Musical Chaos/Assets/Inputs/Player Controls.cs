// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Player Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""170831af-f6e8-4bf1-8ffb-1ee6635b9bd3"",
            ""actions"": [
                {
                    ""name"": ""APressed"",
                    ""type"": ""Button"",
                    ""id"": ""59b58bc1-a0d9-466a-9c21-caa74bff5af5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BPressed"",
                    ""type"": ""Button"",
                    ""id"": ""59c8f7d4-3741-405b-b510-2bf02aff0bda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26761cfc-2d37-4d92-a66c-03eceeb0b4af"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""APressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63b3c63a-bdad-46be-a1f8-bb3cac64a957"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_APressed = m_Gameplay.FindAction("APressed", throwIfNotFound: true);
        m_Gameplay_BPressed = m_Gameplay.FindAction("BPressed", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_APressed;
    private readonly InputAction m_Gameplay_BPressed;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @APressed => m_Wrapper.m_Gameplay_APressed;
        public InputAction @BPressed => m_Wrapper.m_Gameplay_BPressed;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @APressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAPressed;
                @APressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAPressed;
                @APressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAPressed;
                @BPressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBPressed;
                @BPressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBPressed;
                @BPressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBPressed;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @APressed.started += instance.OnAPressed;
                @APressed.performed += instance.OnAPressed;
                @APressed.canceled += instance.OnAPressed;
                @BPressed.started += instance.OnBPressed;
                @BPressed.performed += instance.OnBPressed;
                @BPressed.canceled += instance.OnBPressed;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnAPressed(InputAction.CallbackContext context);
        void OnBPressed(InputAction.CallbackContext context);
    }
}

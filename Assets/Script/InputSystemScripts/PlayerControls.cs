//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""BasicInput"",
            ""id"": ""53c85a61-1982-4de1-b072-5c75d7e9f46b"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Value"",
                    ""id"": ""7b5efb4d-ec9f-48b7-a296-5be3466ab523"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""26ae4177-27a0-4d89-8c63-5e67dc16ea6a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9c84980d-bfde-4f26-9f41-c4b9fd925ac9"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""24ff67ec-55b7-4ac9-b849-ebc3c5b68ebd"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicInput
        m_BasicInput = asset.FindActionMap("BasicInput", throwIfNotFound: true);
        m_BasicInput_Moving = m_BasicInput.FindAction("Moving", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // BasicInput
    private readonly InputActionMap m_BasicInput;
    private List<IBasicInputActions> m_BasicInputActionsCallbackInterfaces = new List<IBasicInputActions>();
    private readonly InputAction m_BasicInput_Moving;
    public struct BasicInputActions
    {
        private @PlayerControls m_Wrapper;
        public BasicInputActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moving => m_Wrapper.m_BasicInput_Moving;
        public InputActionMap Get() { return m_Wrapper.m_BasicInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicInputActions set) { return set.Get(); }
        public void AddCallbacks(IBasicInputActions instance)
        {
            if (instance == null || m_Wrapper.m_BasicInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BasicInputActionsCallbackInterfaces.Add(instance);
            @Moving.started += instance.OnMoving;
            @Moving.performed += instance.OnMoving;
            @Moving.canceled += instance.OnMoving;
        }

        private void UnregisterCallbacks(IBasicInputActions instance)
        {
            @Moving.started -= instance.OnMoving;
            @Moving.performed -= instance.OnMoving;
            @Moving.canceled -= instance.OnMoving;
        }

        public void RemoveCallbacks(IBasicInputActions instance)
        {
            if (m_Wrapper.m_BasicInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBasicInputActions instance)
        {
            foreach (var item in m_Wrapper.m_BasicInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BasicInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BasicInputActions @BasicInput => new BasicInputActions(this);
    public interface IBasicInputActions
    {
        void OnMoving(InputAction.CallbackContext context);
    }
}
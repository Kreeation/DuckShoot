//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/FPS_Control.inputactions
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

public partial class @FPS_Control : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPS_Control()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPS_Control"",
    ""maps"": [
        {
            ""name"": ""Player_map"",
            ""id"": ""b5805409-8356-474b-a706-6d8edd67a776"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c4f9a47e-0597-485d-b1b4-4057243ec938"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""85e5e0dc-71f5-4cbc-998f-ff68a82d7bba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""75d30922-44f6-47ac-9f86-178650fcdd83"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f766c297-20af-4982-8de9-fc0e75a48c85"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""283d15e2-8470-46c7-95d4-1169aa856797"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1fd62270-e4bf-4e2c-a12d-a445da6e11a1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a8656d30-aab0-4521-87b6-dc0a866e37e5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""51580c4e-8da1-4824-8818-5c1e4eaa3836"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b1d5d255-08b2-4e8f-8a06-0f3e188aa6c2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player_map
        m_Player_map = asset.FindActionMap("Player_map", throwIfNotFound: true);
        m_Player_map_movement = m_Player_map.FindAction("movement", throwIfNotFound: true);
        m_Player_map_jump = m_Player_map.FindAction("jump", throwIfNotFound: true);
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

    // Player_map
    private readonly InputActionMap m_Player_map;
    private IPlayer_mapActions m_Player_mapActionsCallbackInterface;
    private readonly InputAction m_Player_map_movement;
    private readonly InputAction m_Player_map_jump;
    public struct Player_mapActions
    {
        private @FPS_Control m_Wrapper;
        public Player_mapActions(@FPS_Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_Player_map_movement;
        public InputAction @jump => m_Wrapper.m_Player_map_jump;
        public InputActionMap Get() { return m_Wrapper.m_Player_map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_mapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_mapActions instance)
        {
            if (m_Wrapper.m_Player_mapActionsCallbackInterface != null)
            {
                @movement.started -= m_Wrapper.m_Player_mapActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_Player_mapActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_Player_mapActionsCallbackInterface.OnMovement;
                @jump.started -= m_Wrapper.m_Player_mapActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_Player_mapActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_Player_mapActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Player_mapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
            }
        }
    }
    public Player_mapActions @Player_map => new Player_mapActions(this);
    public interface IPlayer_mapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
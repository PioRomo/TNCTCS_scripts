//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""CatControls"",
            ""id"": ""6e8bdd8b-6fa8-4a69-a49d-53b599bc5935"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""fd0bba77-5831-496f-b8cd-5438e1a81ca1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sit"",
                    ""type"": ""Button"",
                    ""id"": ""831e73ff-696f-44bb-b049-2aa00f722a0a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch"",
                    ""type"": ""Button"",
                    ""id"": ""07217c31-5559-48e4-9b57-8503eed4e271"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""ef1d8833-91a1-4559-8f6a-68f16220c8b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d521dcc5-234e-4226-8b3f-235a1787746c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""931a6437-5fed-4257-879d-2427b2f34af3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1f5a85ad-a5c3-42b3-ba0d-2a50f09a012f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""be7575cc-b1e7-4e0d-add2-9761c8abc8a5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1b8b0ea3-36e1-4a86-b09b-6038bfa9c5de"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c6e3696a-1132-42d6-b3dd-6d7db80f0215"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2722601d-30c5-4359-8492-17052493e9f5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78a73e36-c37d-4be5-b235-3397175ac83d"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CatControls
        m_CatControls = asset.FindActionMap("CatControls", throwIfNotFound: true);
        m_CatControls_Walk = m_CatControls.FindAction("Walk", throwIfNotFound: true);
        m_CatControls_Sit = m_CatControls.FindAction("Sit", throwIfNotFound: true);
        m_CatControls_Switch = m_CatControls.FindAction("Switch", throwIfNotFound: true);
        m_CatControls_Run = m_CatControls.FindAction("Run", throwIfNotFound: true);
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

    // CatControls
    private readonly InputActionMap m_CatControls;
    private ICatControlsActions m_CatControlsActionsCallbackInterface;
    private readonly InputAction m_CatControls_Walk;
    private readonly InputAction m_CatControls_Sit;
    private readonly InputAction m_CatControls_Switch;
    private readonly InputAction m_CatControls_Run;
    public struct CatControlsActions
    {
        private @PlayerControls m_Wrapper;
        public CatControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_CatControls_Walk;
        public InputAction @Sit => m_Wrapper.m_CatControls_Sit;
        public InputAction @Switch => m_Wrapper.m_CatControls_Switch;
        public InputAction @Run => m_Wrapper.m_CatControls_Run;
        public InputActionMap Get() { return m_Wrapper.m_CatControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CatControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICatControlsActions instance)
        {
            if (m_Wrapper.m_CatControlsActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnWalk;
                @Sit.started -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnSit;
                @Sit.performed -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnSit;
                @Sit.canceled -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnSit;
                @Switch.started -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnSwitch;
                @Switch.performed -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnSwitch;
                @Switch.canceled -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnSwitch;
                @Run.started -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_CatControlsActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_CatControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Sit.started += instance.OnSit;
                @Sit.performed += instance.OnSit;
                @Sit.canceled += instance.OnSit;
                @Switch.started += instance.OnSwitch;
                @Switch.performed += instance.OnSwitch;
                @Switch.canceled += instance.OnSwitch;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public CatControlsActions @CatControls => new CatControlsActions(this);
    public interface ICatControlsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnSit(InputAction.CallbackContext context);
        void OnSwitch(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}

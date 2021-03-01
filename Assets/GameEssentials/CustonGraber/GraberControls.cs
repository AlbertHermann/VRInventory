// GENERATED AUTOMATICALLY FROM 'Assets/GameEssentials/CustonGraber/GraberControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GraberControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GraberControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GraberControls"",
    ""maps"": [
        {
            ""name"": ""LeftHand"",
            ""id"": ""ee96b269-b161-42f4-80df-e35fe06d3e2d"",
            ""actions"": [
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""4e127e96-3c78-417d-b854-c8ef9a86f3a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f14fe097-a5ee-4c7b-8c0f-2b0766f3d2fe"",
                    ""path"": ""<OculusTouchController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RightHand"",
            ""id"": ""3821b0c8-9a5b-46d9-a68c-9437b1761b60"",
            ""actions"": [
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""db106bd6-d596-407d-b13e-370fc771054b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f9cd018-a90b-43b3-94b1-48bbb3a160d0"",
                    ""path"": ""<OculusTouchController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LeftHand
        m_LeftHand = asset.FindActionMap("LeftHand", throwIfNotFound: true);
        m_LeftHand_Grab = m_LeftHand.FindAction("Grab", throwIfNotFound: true);
        // RightHand
        m_RightHand = asset.FindActionMap("RightHand", throwIfNotFound: true);
        m_RightHand_Grab = m_RightHand.FindAction("Grab", throwIfNotFound: true);
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

    // LeftHand
    private readonly InputActionMap m_LeftHand;
    private ILeftHandActions m_LeftHandActionsCallbackInterface;
    private readonly InputAction m_LeftHand_Grab;
    public struct LeftHandActions
    {
        private @GraberControls m_Wrapper;
        public LeftHandActions(@GraberControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grab => m_Wrapper.m_LeftHand_Grab;
        public InputActionMap Get() { return m_Wrapper.m_LeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftHandActions set) { return set.Get(); }
        public void SetCallbacks(ILeftHandActions instance)
        {
            if (m_Wrapper.m_LeftHandActionsCallbackInterface != null)
            {
                @Grab.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGrab;
            }
            m_Wrapper.m_LeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
            }
        }
    }
    public LeftHandActions @LeftHand => new LeftHandActions(this);

    // RightHand
    private readonly InputActionMap m_RightHand;
    private IRightHandActions m_RightHandActionsCallbackInterface;
    private readonly InputAction m_RightHand_Grab;
    public struct RightHandActions
    {
        private @GraberControls m_Wrapper;
        public RightHandActions(@GraberControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grab => m_Wrapper.m_RightHand_Grab;
        public InputActionMap Get() { return m_Wrapper.m_RightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightHandActions set) { return set.Get(); }
        public void SetCallbacks(IRightHandActions instance)
        {
            if (m_Wrapper.m_RightHandActionsCallbackInterface != null)
            {
                @Grab.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGrab;
            }
            m_Wrapper.m_RightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
            }
        }
    }
    public RightHandActions @RightHand => new RightHandActions(this);
    public interface ILeftHandActions
    {
        void OnGrab(InputAction.CallbackContext context);
    }
    public interface IRightHandActions
    {
        void OnGrab(InputAction.CallbackContext context);
    }
}

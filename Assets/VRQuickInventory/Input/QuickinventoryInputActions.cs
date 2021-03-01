// GENERATED AUTOMATICALLY FROM 'Assets/VRQuickInventory/Input/QuickinventoryInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @QuickinventoryInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @QuickinventoryInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""QuickinventoryInputActions"",
    ""maps"": [
        {
            ""name"": ""LeftHand"",
            ""id"": ""cd2f601c-3ad4-42ac-a65f-d53d001a6463"",
            ""actions"": [
                {
                    ""name"": ""Open"",
                    ""type"": ""Button"",
                    ""id"": ""938c3c68-12d2-465a-b87a-e6e34c5f0106"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49f93d93-4292-40ed-b7f8-b51b37c89ed8"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstickClicked"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce4db3c9-54b8-412c-bf13-dc729c90531b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RightHand"",
            ""id"": ""e541eae5-def6-4cc8-a240-7c9b3589c8f1"",
            ""actions"": [
                {
                    ""name"": ""Open"",
                    ""type"": ""Button"",
                    ""id"": ""7add67dc-8f82-442e-89d7-e4dc7839b68a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""411fc9ff-3bfe-4a28-ab62-b92991aad276"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstickClicked"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cf1e27d-5695-4740-9615-a56903d3c3ba"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftCircle"",
            ""id"": ""cabc2362-76e9-4e93-a549-265708f0b8b5"",
            ""actions"": [
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e935d22d-9187-4f9f-9307-b6545ff86cd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""e79d6be9-8791-4d9b-9eef-45ab561b335b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GrabChosenItem"",
                    ""type"": ""Button"",
                    ""id"": ""ca22588f-d26a-4605-bb13-091c6f8e5678"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FillInventory"",
                    ""type"": ""Button"",
                    ""id"": ""58b4fe83-951c-4897-9fa4-c15b2d6be432"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c15e6bb9-3d41-4750-b6f5-48690711563f"",
                    ""path"": ""<OculusTouchController>{LeftHand}/secondaryButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c610cf1-01c2-46b7-9e15-57faf2a3f29e"",
                    ""path"": ""<OculusTouchController>{LeftHand}/primaryButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02e0b06d-9c4f-4a6a-b410-0b420c344721"",
                    ""path"": ""<OculusTouchController>{LeftHand}/gripPressed"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabChosenItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c105eca6-cb50-46c1-b8d9-cdc67a8577dd"",
                    ""path"": ""<OculusTouchController>{LeftHand}/triggerPressed"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FillInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RightCircle"",
            ""id"": ""e11f9c7e-9891-472e-b4ac-02ac131143cc"",
            ""actions"": [
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c63ad249-32f3-46e3-84c1-e713d4806c49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""9ef62fe4-bdf9-4138-9325-d0d2cecf40af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GrabChosenItem"",
                    ""type"": ""Button"",
                    ""id"": ""e58b53a5-30d1-46b9-a829-1d2974ce2162"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FillInventory"",
                    ""type"": ""Button"",
                    ""id"": ""22be9ea8-40fe-4a23-a017-c7f164aad7f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a54c6302-840f-4c12-86a9-d60c918ba438"",
                    ""path"": ""<OculusTouchController>{RightHand}/secondaryButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a276d87e-7d1c-4ca5-9d9e-d00be168d985"",
                    ""path"": ""<OculusTouchController>{RightHand}/primaryButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da719c70-5243-4725-a59b-d6b0993f1335"",
                    ""path"": ""<OculusTouchController>{RightHand}/gripPressed"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabChosenItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbff2382-c21f-4b21-b665-ef922819b1fa"",
                    ""path"": ""<OculusTouchController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FillInventory"",
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
        m_LeftHand_Open = m_LeftHand.FindAction("Open", throwIfNotFound: true);
        // RightHand
        m_RightHand = asset.FindActionMap("RightHand", throwIfNotFound: true);
        m_RightHand_Open = m_RightHand.FindAction("Open", throwIfNotFound: true);
        // LeftCircle
        m_LeftCircle = asset.FindActionMap("LeftCircle", throwIfNotFound: true);
        m_LeftCircle_RotateLeft = m_LeftCircle.FindAction("RotateLeft", throwIfNotFound: true);
        m_LeftCircle_RotateRight = m_LeftCircle.FindAction("RotateRight", throwIfNotFound: true);
        m_LeftCircle_GrabChosenItem = m_LeftCircle.FindAction("GrabChosenItem", throwIfNotFound: true);
        m_LeftCircle_FillInventory = m_LeftCircle.FindAction("FillInventory", throwIfNotFound: true);
        // RightCircle
        m_RightCircle = asset.FindActionMap("RightCircle", throwIfNotFound: true);
        m_RightCircle_RotateLeft = m_RightCircle.FindAction("RotateLeft", throwIfNotFound: true);
        m_RightCircle_RotateRight = m_RightCircle.FindAction("RotateRight", throwIfNotFound: true);
        m_RightCircle_GrabChosenItem = m_RightCircle.FindAction("GrabChosenItem", throwIfNotFound: true);
        m_RightCircle_FillInventory = m_RightCircle.FindAction("FillInventory", throwIfNotFound: true);
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
    private readonly InputAction m_LeftHand_Open;
    public struct LeftHandActions
    {
        private @QuickinventoryInputActions m_Wrapper;
        public LeftHandActions(@QuickinventoryInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Open => m_Wrapper.m_LeftHand_Open;
        public InputActionMap Get() { return m_Wrapper.m_LeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftHandActions set) { return set.Get(); }
        public void SetCallbacks(ILeftHandActions instance)
        {
            if (m_Wrapper.m_LeftHandActionsCallbackInterface != null)
            {
                @Open.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnOpen;
                @Open.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnOpen;
                @Open.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnOpen;
            }
            m_Wrapper.m_LeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Open.started += instance.OnOpen;
                @Open.performed += instance.OnOpen;
                @Open.canceled += instance.OnOpen;
            }
        }
    }
    public LeftHandActions @LeftHand => new LeftHandActions(this);

    // RightHand
    private readonly InputActionMap m_RightHand;
    private IRightHandActions m_RightHandActionsCallbackInterface;
    private readonly InputAction m_RightHand_Open;
    public struct RightHandActions
    {
        private @QuickinventoryInputActions m_Wrapper;
        public RightHandActions(@QuickinventoryInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Open => m_Wrapper.m_RightHand_Open;
        public InputActionMap Get() { return m_Wrapper.m_RightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightHandActions set) { return set.Get(); }
        public void SetCallbacks(IRightHandActions instance)
        {
            if (m_Wrapper.m_RightHandActionsCallbackInterface != null)
            {
                @Open.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnOpen;
                @Open.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnOpen;
                @Open.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnOpen;
            }
            m_Wrapper.m_RightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Open.started += instance.OnOpen;
                @Open.performed += instance.OnOpen;
                @Open.canceled += instance.OnOpen;
            }
        }
    }
    public RightHandActions @RightHand => new RightHandActions(this);

    // LeftCircle
    private readonly InputActionMap m_LeftCircle;
    private ILeftCircleActions m_LeftCircleActionsCallbackInterface;
    private readonly InputAction m_LeftCircle_RotateLeft;
    private readonly InputAction m_LeftCircle_RotateRight;
    private readonly InputAction m_LeftCircle_GrabChosenItem;
    private readonly InputAction m_LeftCircle_FillInventory;
    public struct LeftCircleActions
    {
        private @QuickinventoryInputActions m_Wrapper;
        public LeftCircleActions(@QuickinventoryInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateLeft => m_Wrapper.m_LeftCircle_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_LeftCircle_RotateRight;
        public InputAction @GrabChosenItem => m_Wrapper.m_LeftCircle_GrabChosenItem;
        public InputAction @FillInventory => m_Wrapper.m_LeftCircle_FillInventory;
        public InputActionMap Get() { return m_Wrapper.m_LeftCircle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftCircleActions set) { return set.Get(); }
        public void SetCallbacks(ILeftCircleActions instance)
        {
            if (m_Wrapper.m_LeftCircleActionsCallbackInterface != null)
            {
                @RotateLeft.started -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnRotateRight;
                @GrabChosenItem.started -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnGrabChosenItem;
                @GrabChosenItem.performed -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnGrabChosenItem;
                @GrabChosenItem.canceled -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnGrabChosenItem;
                @FillInventory.started -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnFillInventory;
                @FillInventory.performed -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnFillInventory;
                @FillInventory.canceled -= m_Wrapper.m_LeftCircleActionsCallbackInterface.OnFillInventory;
            }
            m_Wrapper.m_LeftCircleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
                @GrabChosenItem.started += instance.OnGrabChosenItem;
                @GrabChosenItem.performed += instance.OnGrabChosenItem;
                @GrabChosenItem.canceled += instance.OnGrabChosenItem;
                @FillInventory.started += instance.OnFillInventory;
                @FillInventory.performed += instance.OnFillInventory;
                @FillInventory.canceled += instance.OnFillInventory;
            }
        }
    }
    public LeftCircleActions @LeftCircle => new LeftCircleActions(this);

    // RightCircle
    private readonly InputActionMap m_RightCircle;
    private IRightCircleActions m_RightCircleActionsCallbackInterface;
    private readonly InputAction m_RightCircle_RotateLeft;
    private readonly InputAction m_RightCircle_RotateRight;
    private readonly InputAction m_RightCircle_GrabChosenItem;
    private readonly InputAction m_RightCircle_FillInventory;
    public struct RightCircleActions
    {
        private @QuickinventoryInputActions m_Wrapper;
        public RightCircleActions(@QuickinventoryInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateLeft => m_Wrapper.m_RightCircle_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_RightCircle_RotateRight;
        public InputAction @GrabChosenItem => m_Wrapper.m_RightCircle_GrabChosenItem;
        public InputAction @FillInventory => m_Wrapper.m_RightCircle_FillInventory;
        public InputActionMap Get() { return m_Wrapper.m_RightCircle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightCircleActions set) { return set.Get(); }
        public void SetCallbacks(IRightCircleActions instance)
        {
            if (m_Wrapper.m_RightCircleActionsCallbackInterface != null)
            {
                @RotateLeft.started -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnRotateRight;
                @GrabChosenItem.started -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnGrabChosenItem;
                @GrabChosenItem.performed -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnGrabChosenItem;
                @GrabChosenItem.canceled -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnGrabChosenItem;
                @FillInventory.started -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnFillInventory;
                @FillInventory.performed -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnFillInventory;
                @FillInventory.canceled -= m_Wrapper.m_RightCircleActionsCallbackInterface.OnFillInventory;
            }
            m_Wrapper.m_RightCircleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
                @GrabChosenItem.started += instance.OnGrabChosenItem;
                @GrabChosenItem.performed += instance.OnGrabChosenItem;
                @GrabChosenItem.canceled += instance.OnGrabChosenItem;
                @FillInventory.started += instance.OnFillInventory;
                @FillInventory.performed += instance.OnFillInventory;
                @FillInventory.canceled += instance.OnFillInventory;
            }
        }
    }
    public RightCircleActions @RightCircle => new RightCircleActions(this);
    public interface ILeftHandActions
    {
        void OnOpen(InputAction.CallbackContext context);
    }
    public interface IRightHandActions
    {
        void OnOpen(InputAction.CallbackContext context);
    }
    public interface ILeftCircleActions
    {
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
        void OnGrabChosenItem(InputAction.CallbackContext context);
        void OnFillInventory(InputAction.CallbackContext context);
    }
    public interface IRightCircleActions
    {
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
        void OnGrabChosenItem(InputAction.CallbackContext context);
        void OnFillInventory(InputAction.CallbackContext context);
    }
}

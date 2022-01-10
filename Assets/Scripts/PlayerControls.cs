// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

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
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""1fccc519-134a-4f35-afe8-dfd59a9452a9"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""b652a742-9efe-4baf-93bb-ef170fd43747"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""afe10683-23a6-4363-b435-9b9ff584da1c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2db3b0f1-f3e3-40cc-95a6-2fae1882bd88"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bd38827e-2b89-4c6e-bc3b-b441f68b1628"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7efc4238-ab95-4829-b3ce-493781e6a099"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e71b7de-d1d2-4294-acf9-bc6aa777e397"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""14144a1a-58fd-42ae-b597-29f15ea0743a"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2905e52c-682d-490d-b57c-9d63e8e0426a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Speed"",
                    ""type"": ""Value"",
                    ""id"": ""d4ca33e0-8f03-4bf6-8ad2-938b965365b8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3388abd5-af8e-411c-aa9b-532912954307"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Multiplier"",
                    ""type"": ""Value"",
                    ""id"": ""8824cfeb-8a7b-4e91-bc0d-f8d70f3606bf"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""092a6538-29f5-417a-a4c3-8da014f921b3"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cff9493c-05ea-4d36-bf0b-fec81d334b63"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.001,max=0.999)"",
                    ""groups"": """",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""917c22b2-a89a-45b5-94f7-0f9aa32e652f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ccb64d57-f4dc-48d5-a952-f65c92fd383f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.125,max=0.999)"",
                    ""groups"": """",
                    ""action"": ""Multiplier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraFixed"",
            ""id"": ""d1f6f1af-b8f0-45cc-8e56-0f7603aef9aa"",
            ""actions"": [
                {
                    ""name"": ""RightStick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fe78484f-9fa6-41ed-b992-739d0b946983"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f3c40e6-de2e-4e8f-a966-59fd4e8e0311"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""0b1236e2-9356-45aa-8445-f9c7f4e2fc25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Value"",
                    ""id"": ""ff47479a-0125-4921-b4da-8ac8d91d06d3"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""335ac3d1-6e0f-457e-a842-8f407d2f481f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Value"",
                    ""id"": ""a9021039-56a0-4a7d-86bc-8476f2bba050"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L3"",
                    ""type"": ""Button"",
                    ""id"": ""e9fd00db-5c0d-4511-9b5a-cc7d61aa3be8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6831d977-ecef-42fe-99d0-cf7bff7b824a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52ca04b6-2121-4089-83f7-5450f2a9552b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97ae22fc-d57f-4f19-85dc-c2dc582d1155"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84a73e69-1a26-4c21-a5a3-1d9b2b810520"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0513b958-b385-4865-8692-7327a5604134"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13d3dceb-7e40-4ea5-851c-d4bc16f561a3"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38788826-8a54-45c6-8cf1-620f43e155c8"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L3"",
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
        m_Gameplay_Grow = m_Gameplay.FindAction("Grow", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Rotate = m_Gameplay.FindAction("Rotate", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Direction = m_Camera.FindAction("Direction", throwIfNotFound: true);
        m_Camera_Speed = m_Camera.FindAction("Speed", throwIfNotFound: true);
        m_Camera_Newaction = m_Camera.FindAction("New action", throwIfNotFound: true);
        m_Camera_Multiplier = m_Camera.FindAction("Multiplier", throwIfNotFound: true);
        // CameraFixed
        m_CameraFixed = asset.FindActionMap("CameraFixed", throwIfNotFound: true);
        m_CameraFixed_RightStick = m_CameraFixed.FindAction("RightStick", throwIfNotFound: true);
        m_CameraFixed_LeftStick = m_CameraFixed.FindAction("LeftStick", throwIfNotFound: true);
        m_CameraFixed_L1 = m_CameraFixed.FindAction("L1", throwIfNotFound: true);
        m_CameraFixed_L2 = m_CameraFixed.FindAction("L2", throwIfNotFound: true);
        m_CameraFixed_R1 = m_CameraFixed.FindAction("R1", throwIfNotFound: true);
        m_CameraFixed_R2 = m_CameraFixed.FindAction("R2", throwIfNotFound: true);
        m_CameraFixed_L3 = m_CameraFixed.FindAction("L3", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Grow;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Rotate;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grow => m_Wrapper.m_Gameplay_Grow;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rotate => m_Wrapper.m_Gameplay_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Grow.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Grow.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Grow.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grow.started += instance.OnGrow;
                @Grow.performed += instance.OnGrow;
                @Grow.canceled += instance.OnGrow;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Direction;
    private readonly InputAction m_Camera_Speed;
    private readonly InputAction m_Camera_Newaction;
    private readonly InputAction m_Camera_Multiplier;
    public struct CameraActions
    {
        private @PlayerControls m_Wrapper;
        public CameraActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_Camera_Direction;
        public InputAction @Speed => m_Wrapper.m_Camera_Speed;
        public InputAction @Newaction => m_Wrapper.m_Camera_Newaction;
        public InputAction @Multiplier => m_Wrapper.m_Camera_Multiplier;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Direction.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnDirection;
                @Speed.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnSpeed;
                @Speed.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnSpeed;
                @Speed.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnSpeed;
                @Newaction.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnNewaction;
                @Multiplier.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMultiplier;
                @Multiplier.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMultiplier;
                @Multiplier.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMultiplier;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @Speed.started += instance.OnSpeed;
                @Speed.performed += instance.OnSpeed;
                @Speed.canceled += instance.OnSpeed;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
                @Multiplier.started += instance.OnMultiplier;
                @Multiplier.performed += instance.OnMultiplier;
                @Multiplier.canceled += instance.OnMultiplier;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // CameraFixed
    private readonly InputActionMap m_CameraFixed;
    private ICameraFixedActions m_CameraFixedActionsCallbackInterface;
    private readonly InputAction m_CameraFixed_RightStick;
    private readonly InputAction m_CameraFixed_LeftStick;
    private readonly InputAction m_CameraFixed_L1;
    private readonly InputAction m_CameraFixed_L2;
    private readonly InputAction m_CameraFixed_R1;
    private readonly InputAction m_CameraFixed_R2;
    private readonly InputAction m_CameraFixed_L3;
    public struct CameraFixedActions
    {
        private @PlayerControls m_Wrapper;
        public CameraFixedActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightStick => m_Wrapper.m_CameraFixed_RightStick;
        public InputAction @LeftStick => m_Wrapper.m_CameraFixed_LeftStick;
        public InputAction @L1 => m_Wrapper.m_CameraFixed_L1;
        public InputAction @L2 => m_Wrapper.m_CameraFixed_L2;
        public InputAction @R1 => m_Wrapper.m_CameraFixed_R1;
        public InputAction @R2 => m_Wrapper.m_CameraFixed_R2;
        public InputAction @L3 => m_Wrapper.m_CameraFixed_L3;
        public InputActionMap Get() { return m_Wrapper.m_CameraFixed; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraFixedActions set) { return set.Get(); }
        public void SetCallbacks(ICameraFixedActions instance)
        {
            if (m_Wrapper.m_CameraFixedActionsCallbackInterface != null)
            {
                @RightStick.started -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnRightStick;
                @LeftStick.started -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnLeftStick;
                @L1.started -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL1;
                @L2.started -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL2;
                @R1.started -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnR1;
                @R2.started -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnR2;
                @L3.started -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL3;
                @L3.performed -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL3;
                @L3.canceled -= m_Wrapper.m_CameraFixedActionsCallbackInterface.OnL3;
            }
            m_Wrapper.m_CameraFixedActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @L3.started += instance.OnL3;
                @L3.performed += instance.OnL3;
                @L3.canceled += instance.OnL3;
            }
        }
    }
    public CameraFixedActions @CameraFixed => new CameraFixedActions(this);
    public interface IGameplayActions
    {
        void OnGrow(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnSpeed(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
        void OnMultiplier(InputAction.CallbackContext context);
    }
    public interface ICameraFixedActions
    {
        void OnRightStick(InputAction.CallbackContext context);
        void OnLeftStick(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnL3(InputAction.CallbackContext context);
    }
}

// GENERATED AUTOMATICALLY FROM 'Assets/ControllableAvatar/InputManagers/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Play"",
            ""id"": ""01371eeb-ecc0-434c-bc95-03be9eb44a3d"",
            ""actions"": [
                {
                    ""name"": ""AttackL"",
                    ""type"": ""Button"",
                    ""id"": ""b91c26f5-f404-40d2-b7cc-bc8ea3d75075"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackR"",
                    ""type"": ""Button"",
                    ""id"": ""0aa0e6c2-b11b-47d7-a268-b23c6e7d0851"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""2b0923ef-997d-4591-a443-5c0b7e103264"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SteerRight"",
                    ""type"": ""Value"",
                    ""id"": ""52bcb2aa-1a7b-4a78-b47d-4971d1ae1026"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""SteerLeft"",
                    ""type"": ""Value"",
                    ""id"": ""9e1c239d-761f-403a-8d33-c5e21df2c565"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""a28b3b7d-7245-4c47-8256-f9e5c443dd22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""20bab562-3d55-4bba-963f-276c8e3827e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DiveRoll"",
                    ""type"": ""Button"",
                    ""id"": ""89a12e33-4255-4110-b4eb-3a841ef4c2b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""a0dbbbb4-2bb1-435b-87df-75b63c9ab694"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Equip"",
                    ""type"": ""Button"",
                    ""id"": ""00f4a276-b2f3-4272-b68c-49a4859dfab9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""9fcb40cd-d299-46de-b28d-f8e7d25a6b8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ThumbstickIn"",
                    ""type"": ""Button"",
                    ""id"": ""a1696fe5-0f5d-40e2-b879-0e7f746ca763"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""SquareInteract"",
                    ""type"": ""Button"",
                    ""id"": ""b16b08ae-6448-4c22-a15f-1c6cbf047b34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa9cefcd-ccf1-4ea5-9b5b-7c80e45859cb"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1270410f-94f6-4eee-a52e-9effbac79624"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.125,max=0.925)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d88699ee-08c4-454f-95ba-7f42e386be1b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(max=1)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SteerRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60766f48-17dd-4fa6-bcad-b75c47dbda49"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SteerLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f88596c6-9c23-4cf0-ad31-07902286c4af"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press(pressPoint=0.5,behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c73050ec-5fe1-4599-9c46-fc6a59109d1d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dca7471f-a659-45de-ac87-f98ffddbf7fb"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DiveRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1217724-c7c9-445f-a01f-b5309bae1e8f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b0404c9-1290-4719-af6d-9353cd78acb4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6ff3199-830b-4b03-85fd-fe1b8c75ba00"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd1f9261-a0ed-417d-a367-36b73c923a2f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61020b99-1343-41b3-90e8-3907b23cb374"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThumbstickIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae47a2be-72f9-4ae3-8501-db371ecf96af"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SquareInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""76edea5c-20e8-4567-8c01-2dfcd1ca00c4"",
            ""actions"": [
                {
                    ""name"": ""DpadDown"",
                    ""type"": ""Button"",
                    ""id"": ""7ad2ebdd-b9c6-47d2-9587-59302e85c710"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DpadUp"",
                    ""type"": ""Button"",
                    ""id"": ""ffe3851f-2e45-4361-9910-eca36c430941"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""be46bdc0-2cfa-4442-93eb-763ae44e11a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""344b2cb5-1445-4748-a77f-8eb113084ffc"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DpadDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8409dcc5-0003-4029-9201-5a258cbbd920"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DpadUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d85f5534-e5dd-423d-94ce-0c3be58257bc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""changeDimension"",
            ""id"": ""a53cb97b-86c8-499c-82ca-f88e50addc95"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Value"",
                    ""id"": ""91d00864-ea55-4490-94c9-8553c6b5e9d4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Value"",
                    ""id"": ""4e9a6720-d004-4899-be54-49df6b7b49ec"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""384409dd-b2be-44f1-a38c-fc76628e48cc"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74824708-e7f3-4de4-9715-ae5c6f4550d5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Play
        m_Play = asset.FindActionMap("Play", throwIfNotFound: true);
        m_Play_AttackL = m_Play.FindAction("AttackL", throwIfNotFound: true);
        m_Play_AttackR = m_Play.FindAction("AttackR", throwIfNotFound: true);
        m_Play_Move = m_Play.FindAction("Move", throwIfNotFound: true);
        m_Play_SteerRight = m_Play.FindAction("SteerRight", throwIfNotFound: true);
        m_Play_SteerLeft = m_Play.FindAction("SteerLeft", throwIfNotFound: true);
        m_Play_Menu = m_Play.FindAction("Menu", throwIfNotFound: true);
        m_Play_Jump = m_Play.FindAction("Jump", throwIfNotFound: true);
        m_Play_DiveRoll = m_Play.FindAction("DiveRoll", throwIfNotFound: true);
        m_Play_Camera = m_Play.FindAction("Camera", throwIfNotFound: true);
        m_Play_Equip = m_Play.FindAction("Equip", throwIfNotFound: true);
        m_Play_Action = m_Play.FindAction("Action", throwIfNotFound: true);
        m_Play_ThumbstickIn = m_Play.FindAction("ThumbstickIn", throwIfNotFound: true);
        m_Play_SquareInteract = m_Play.FindAction("SquareInteract", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_DpadDown = m_Menu.FindAction("DpadDown", throwIfNotFound: true);
        m_Menu_DpadUp = m_Menu.FindAction("DpadUp", throwIfNotFound: true);
        m_Menu_Select = m_Menu.FindAction("Select", throwIfNotFound: true);
        // changeDimension
        m_changeDimension = asset.FindActionMap("changeDimension", throwIfNotFound: true);
        m_changeDimension_Left = m_changeDimension.FindAction("Left", throwIfNotFound: true);
        m_changeDimension_Right = m_changeDimension.FindAction("Right", throwIfNotFound: true);
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

    // Play
    private readonly InputActionMap m_Play;
    private IPlayActions m_PlayActionsCallbackInterface;
    private readonly InputAction m_Play_AttackL;
    private readonly InputAction m_Play_AttackR;
    private readonly InputAction m_Play_Move;
    private readonly InputAction m_Play_SteerRight;
    private readonly InputAction m_Play_SteerLeft;
    private readonly InputAction m_Play_Menu;
    private readonly InputAction m_Play_Jump;
    private readonly InputAction m_Play_DiveRoll;
    private readonly InputAction m_Play_Camera;
    private readonly InputAction m_Play_Equip;
    private readonly InputAction m_Play_Action;
    private readonly InputAction m_Play_ThumbstickIn;
    private readonly InputAction m_Play_SquareInteract;
    public struct PlayActions
    {
        private @Controls m_Wrapper;
        public PlayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @AttackL => m_Wrapper.m_Play_AttackL;
        public InputAction @AttackR => m_Wrapper.m_Play_AttackR;
        public InputAction @Move => m_Wrapper.m_Play_Move;
        public InputAction @SteerRight => m_Wrapper.m_Play_SteerRight;
        public InputAction @SteerLeft => m_Wrapper.m_Play_SteerLeft;
        public InputAction @Menu => m_Wrapper.m_Play_Menu;
        public InputAction @Jump => m_Wrapper.m_Play_Jump;
        public InputAction @DiveRoll => m_Wrapper.m_Play_DiveRoll;
        public InputAction @Camera => m_Wrapper.m_Play_Camera;
        public InputAction @Equip => m_Wrapper.m_Play_Equip;
        public InputAction @Action => m_Wrapper.m_Play_Action;
        public InputAction @ThumbstickIn => m_Wrapper.m_Play_ThumbstickIn;
        public InputAction @SquareInteract => m_Wrapper.m_Play_SquareInteract;
        public InputActionMap Get() { return m_Wrapper.m_Play; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayActions instance)
        {
            if (m_Wrapper.m_PlayActionsCallbackInterface != null)
            {
                @AttackL.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnAttackL;
                @AttackL.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnAttackL;
                @AttackL.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnAttackL;
                @AttackR.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnAttackR;
                @AttackR.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnAttackR;
                @AttackR.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnAttackR;
                @Move.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnMove;
                @SteerRight.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnSteerRight;
                @SteerRight.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnSteerRight;
                @SteerRight.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnSteerRight;
                @SteerLeft.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnSteerLeft;
                @SteerLeft.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnSteerLeft;
                @SteerLeft.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnSteerLeft;
                @Menu.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnMenu;
                @Jump.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnJump;
                @DiveRoll.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnDiveRoll;
                @DiveRoll.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnDiveRoll;
                @DiveRoll.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnDiveRoll;
                @Camera.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnCamera;
                @Equip.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnEquip;
                @Equip.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnEquip;
                @Equip.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnEquip;
                @Action.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnAction;
                @ThumbstickIn.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnThumbstickIn;
                @ThumbstickIn.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnThumbstickIn;
                @ThumbstickIn.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnThumbstickIn;
                @SquareInteract.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnSquareInteract;
                @SquareInteract.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnSquareInteract;
                @SquareInteract.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnSquareInteract;
            }
            m_Wrapper.m_PlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AttackL.started += instance.OnAttackL;
                @AttackL.performed += instance.OnAttackL;
                @AttackL.canceled += instance.OnAttackL;
                @AttackR.started += instance.OnAttackR;
                @AttackR.performed += instance.OnAttackR;
                @AttackR.canceled += instance.OnAttackR;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @SteerRight.started += instance.OnSteerRight;
                @SteerRight.performed += instance.OnSteerRight;
                @SteerRight.canceled += instance.OnSteerRight;
                @SteerLeft.started += instance.OnSteerLeft;
                @SteerLeft.performed += instance.OnSteerLeft;
                @SteerLeft.canceled += instance.OnSteerLeft;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @DiveRoll.started += instance.OnDiveRoll;
                @DiveRoll.performed += instance.OnDiveRoll;
                @DiveRoll.canceled += instance.OnDiveRoll;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Equip.started += instance.OnEquip;
                @Equip.performed += instance.OnEquip;
                @Equip.canceled += instance.OnEquip;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @ThumbstickIn.started += instance.OnThumbstickIn;
                @ThumbstickIn.performed += instance.OnThumbstickIn;
                @ThumbstickIn.canceled += instance.OnThumbstickIn;
                @SquareInteract.started += instance.OnSquareInteract;
                @SquareInteract.performed += instance.OnSquareInteract;
                @SquareInteract.canceled += instance.OnSquareInteract;
            }
        }
    }
    public PlayActions @Play => new PlayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_DpadDown;
    private readonly InputAction m_Menu_DpadUp;
    private readonly InputAction m_Menu_Select;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @DpadDown => m_Wrapper.m_Menu_DpadDown;
        public InputAction @DpadUp => m_Wrapper.m_Menu_DpadUp;
        public InputAction @Select => m_Wrapper.m_Menu_Select;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @DpadDown.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDpadDown;
                @DpadDown.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDpadDown;
                @DpadDown.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDpadDown;
                @DpadUp.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDpadUp;
                @DpadUp.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDpadUp;
                @DpadUp.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDpadUp;
                @Select.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DpadDown.started += instance.OnDpadDown;
                @DpadDown.performed += instance.OnDpadDown;
                @DpadDown.canceled += instance.OnDpadDown;
                @DpadUp.started += instance.OnDpadUp;
                @DpadUp.performed += instance.OnDpadUp;
                @DpadUp.canceled += instance.OnDpadUp;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // changeDimension
    private readonly InputActionMap m_changeDimension;
    private IChangeDimensionActions m_ChangeDimensionActionsCallbackInterface;
    private readonly InputAction m_changeDimension_Left;
    private readonly InputAction m_changeDimension_Right;
    public struct ChangeDimensionActions
    {
        private @Controls m_Wrapper;
        public ChangeDimensionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_changeDimension_Left;
        public InputAction @Right => m_Wrapper.m_changeDimension_Right;
        public InputActionMap Get() { return m_Wrapper.m_changeDimension; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChangeDimensionActions set) { return set.Get(); }
        public void SetCallbacks(IChangeDimensionActions instance)
        {
            if (m_Wrapper.m_ChangeDimensionActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_ChangeDimensionActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_ChangeDimensionActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_ChangeDimensionActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_ChangeDimensionActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_ChangeDimensionActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_ChangeDimensionActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_ChangeDimensionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public ChangeDimensionActions @changeDimension => new ChangeDimensionActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayActions
    {
        void OnAttackL(InputAction.CallbackContext context);
        void OnAttackR(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnSteerRight(InputAction.CallbackContext context);
        void OnSteerLeft(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDiveRoll(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnEquip(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnThumbstickIn(InputAction.CallbackContext context);
        void OnSquareInteract(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnDpadDown(InputAction.CallbackContext context);
        void OnDpadUp(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IChangeDimensionActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}

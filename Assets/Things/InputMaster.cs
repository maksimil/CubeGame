// GENERATED AUTOMATICALLY FROM 'Assets/Things/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Cube"",
            ""id"": ""9c6d4223-840b-43cb-93c4-f186cae9e532"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""d14f2549-1521-48b8-b0fa-325a34978205"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveH"",
                    ""type"": ""Value"",
                    ""id"": ""7848d201-b00b-4d56-a173-29a9a337c8ee"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""MoveV"",
                    ""type"": ""Value"",
                    ""id"": ""867b9aff-6ba1-4e0f-830a-bae311d5786c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dc42de59-70be-48ed-9a38-6b05b2c85b58"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""fade214f-9a0b-460d-a6d2-4c1614dcd500"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveH"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""773c7535-99e8-47f1-86d0-88a05c31180a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0ae9416b-ae14-4d03-887e-22a31c7fe1c5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MoveH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""SW"",
                    ""id"": ""4f50ccf8-ba8a-4998-830b-06ece6094ab8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""91f84e46-4285-4394-a53e-363d88ac0359"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""910a3590-ecb4-4bd4-ba1b-213d06542678"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MoveV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Cube
        m_Cube = asset.FindActionMap("Cube", throwIfNotFound: true);
        m_Cube_Interact = m_Cube.FindAction("Interact", throwIfNotFound: true);
        m_Cube_MoveH = m_Cube.FindAction("MoveH", throwIfNotFound: true);
        m_Cube_MoveV = m_Cube.FindAction("MoveV", throwIfNotFound: true);
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

    // Cube
    private readonly InputActionMap m_Cube;
    private ICubeActions m_CubeActionsCallbackInterface;
    private readonly InputAction m_Cube_Interact;
    private readonly InputAction m_Cube_MoveH;
    private readonly InputAction m_Cube_MoveV;
    public struct CubeActions
    {
        private @InputMaster m_Wrapper;
        public CubeActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Cube_Interact;
        public InputAction @MoveH => m_Wrapper.m_Cube_MoveH;
        public InputAction @MoveV => m_Wrapper.m_Cube_MoveV;
        public InputActionMap Get() { return m_Wrapper.m_Cube; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CubeActions set) { return set.Get(); }
        public void SetCallbacks(ICubeActions instance)
        {
            if (m_Wrapper.m_CubeActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_CubeActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CubeActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CubeActionsCallbackInterface.OnInteract;
                @MoveH.started -= m_Wrapper.m_CubeActionsCallbackInterface.OnMoveH;
                @MoveH.performed -= m_Wrapper.m_CubeActionsCallbackInterface.OnMoveH;
                @MoveH.canceled -= m_Wrapper.m_CubeActionsCallbackInterface.OnMoveH;
                @MoveV.started -= m_Wrapper.m_CubeActionsCallbackInterface.OnMoveV;
                @MoveV.performed -= m_Wrapper.m_CubeActionsCallbackInterface.OnMoveV;
                @MoveV.canceled -= m_Wrapper.m_CubeActionsCallbackInterface.OnMoveV;
            }
            m_Wrapper.m_CubeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @MoveH.started += instance.OnMoveH;
                @MoveH.performed += instance.OnMoveH;
                @MoveH.canceled += instance.OnMoveH;
                @MoveV.started += instance.OnMoveV;
                @MoveV.performed += instance.OnMoveV;
                @MoveV.canceled += instance.OnMoveV;
            }
        }
    }
    public CubeActions @Cube => new CubeActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    public interface ICubeActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnMoveH(InputAction.CallbackContext context);
        void OnMoveV(InputAction.CallbackContext context);
    }
}

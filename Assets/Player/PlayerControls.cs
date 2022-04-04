// GENERATED AUTOMATICALLY FROM 'Assets/Player/PlayerControls.inputactions'

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
            ""name"": ""GroundMovement"",
            ""id"": ""da09f136-f323-4d07-af7d-4cc3364d843d"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""12f4f185-074e-4a30-aade-1b79e3afb3a0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""990f480e-89dd-4d8b-a39b-f61aee6f3735"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""51cfa919-24b9-46e1-8b89-7c1264e06dfb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f0f7d3a0-5462-45dc-8249-e35c24d9d46b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleCursor"",
                    ""type"": ""Button"",
                    ""id"": ""50e6a20f-bdef-4697-8c21-5aa6a54a795c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleUI"",
                    ""type"": ""Button"",
                    ""id"": ""5b8955df-f67d-4275-a7a5-c14e7ff4b437"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""5444ccec-74a0-49e3-8311-aeb2b8637a09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugMenu1"",
                    ""type"": ""Value"",
                    ""id"": ""c3698965-1ccf-4581-b447-61b512c29180"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugMenu2"",
                    ""type"": ""Value"",
                    ""id"": ""e91d5962-d618-4293-a8fc-b74693af3968"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""095fbf54-bd80-4f4a-aff6-81b96cd6125f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""788501af-2d70-4d20-b424-f34830e1e647"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""373661b6-1abc-4400-aa1a-ab17692cfae5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1b83ecd2-7c40-4c5f-a363-13c1d902b0b8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""082e8452-2ff9-4de2-836e-999b3d7582a0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""037d6224-efed-412f-be58-b77dd75e15c4"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d24cd47-04f9-4661-8998-04d9d906d008"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1de841ac-9a78-4070-86b0-4c2aa90357a4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""027ba553-9a99-4023-a881-c2b122b754b2"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22c9f1bd-2606-411a-8ffc-a6533823db63"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=10)"",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84931778-5c69-4e24-bc8a-e0f9a28923ef"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d427556f-1f98-41b5-a1f7-94ee6e7d0c18"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88bb9e25-125d-4107-b74a-64b6ae994411"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f18eac7-ad21-4df0-8ee4-efb2e1731118"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleUI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""860b4e25-dbe4-4b15-83c7-d77e62883897"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d201bc1e-327a-438a-854e-752bdccea1a8"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugMenu1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""621c283c-15ff-43bd-9e1b-3438c8f1ab24"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugMenu2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""StartMenu"",
            ""id"": ""a725c039-28f8-4242-bda5-be17e3eaa488"",
            ""actions"": [
                {
                    ""name"": ""InputKBM"",
                    ""type"": ""Button"",
                    ""id"": ""21efa420-b700-4518-8b15-8c9841eddba9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InputXbox"",
                    ""type"": ""Button"",
                    ""id"": ""b259039a-3a74-4fca-95c3-6e1a1f5a5267"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InputPlaystation"",
                    ""type"": ""Button"",
                    ""id"": ""70f3bf24-2c00-45a7-8640-140e3cecee57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57a2b4ce-1c25-4f0c-b314-086d502fea6e"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKBM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75f6b27b-c09b-43c0-b74e-8714dee4706b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKBM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66be7981-758a-4c23-92e2-262df74c7978"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKBM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26163626-ce88-4e03-a066-59057764d50e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputKBM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b90d461a-c670-40f8-aaf4-3b474f5c2c31"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee92e2d4-b201-4ce6-bde3-791ff2c843dc"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96ee9c8c-c12e-425a-ba29-a8af4956e4b5"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76173b9e-b5b9-4e90-9d4b-9b20b020194d"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26b7a81d-1c6c-4449-a29f-d8da1e724b1d"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2e655aa-695a-4983-bb43-ae2069631223"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6e262a5-8e9e-48dd-8d02-b5aa69cbfc5d"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6103d559-1ff6-4a4e-b284-e960a0a49d85"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9c7c02d-3961-4f5e-83c5-d25b07f12d63"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90a303fc-b2d5-417a-bdcc-2432a9de6b65"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""182e5794-e072-4ae1-93cf-fca4db5e6976"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c962e484-8ceb-4c1a-a006-56f0b639a057"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2574f912-bae0-4fb8-8ee0-9c39e57500e4"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37f936cf-a0b6-4d01-84ff-3a8648061b4c"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ce37221-50fc-42c6-9138-f0a64f188c47"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e472d7f-b68f-45e1-864e-ba9166422a13"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17a6a825-cefd-4262-a95b-d4868219036f"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20d2ae41-e74d-42a9-bb0a-334740292df4"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ea8df2c-6f00-4356-b9eb-ae9b486d03a2"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53e28ce9-0aab-439d-bd88-a35599513f82"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0a90b89-5a9e-4dd8-8f41-efd09a591536"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c15ca67-da3b-435e-810a-25515dd5e700"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0851cc72-e948-4ca6-890a-e44b5cb472b2"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22db249e-fd20-4544-8833-04800c7a325e"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f5ec87d-a0c9-4c11-b0db-ef32a8b41b34"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1dcfcfaf-6316-46da-bfe0-fbb0ae20176d"",
                    ""path"": ""<DualShockGamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0eec006a-3b3c-46b5-8b73-e11332f482e9"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0581c11e-aa3e-4ace-a3be-f37cfd2065b6"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09907e97-82bd-421f-a5fd-673475ef018a"",
                    ""path"": ""<DualShockGamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f85dcd3c-6473-4f24-9332-77765cacac4a"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc05af29-0f8d-4519-af6b-b0467865208a"",
                    ""path"": ""<DualShockGamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60243c65-3f6a-4a65-b541-c5002dd05454"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10be3097-1123-4b96-b167-ba1ce86ba901"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InputPlaystation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""7c8185b4-a4dc-49e9-8dda-963941393d9f"",
            ""actions"": [
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""18d14b7b-252d-4638-93a8-13f2e8a499e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""35679d08-a9f4-4197-b199-2cd9b5ee5426"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d7cd021c-acd5-4c49-b22d-2811254a3cfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""2f543f63-07a1-4c49-8812-cd5fd835bcd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""773a24f8-ccb8-4133-88d4-ad7ac80fe935"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6d9a2ddc-8a1d-4ca9-a9c4-04c0d05d836e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb01a905-f9fa-4289-b32f-cc5c03910a0d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92da13dc-8c3f-461c-b2ec-86edf9742288"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2d7116f-1011-4e41-9c68-ec32e7394368"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11ba2e32-5a6c-4a2c-a75a-32684a63b5f8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22510d0a-a2f7-414c-a031-df277525f148"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88f3d5af-31bb-4f5e-9de6-969c802f4484"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""943e5e6f-f333-4cce-b7ac-7e095532f791"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11f9d1a9-37c7-4bb5-ac5d-d0750e6e4a75"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca381e0e-eb98-4d64-970c-e8c32c30c8fe"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_HorizontalMovement = m_GroundMovement.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_GroundMovement_Jump = m_GroundMovement.FindAction("Jump", throwIfNotFound: true);
        m_GroundMovement_MouseX = m_GroundMovement.FindAction("MouseX", throwIfNotFound: true);
        m_GroundMovement_MouseY = m_GroundMovement.FindAction("MouseY", throwIfNotFound: true);
        m_GroundMovement_ToggleCursor = m_GroundMovement.FindAction("ToggleCursor", throwIfNotFound: true);
        m_GroundMovement_ToggleUI = m_GroundMovement.FindAction("ToggleUI", throwIfNotFound: true);
        m_GroundMovement_Shoot = m_GroundMovement.FindAction("Shoot", throwIfNotFound: true);
        m_GroundMovement_DebugMenu1 = m_GroundMovement.FindAction("DebugMenu1", throwIfNotFound: true);
        m_GroundMovement_DebugMenu2 = m_GroundMovement.FindAction("DebugMenu2", throwIfNotFound: true);
        // StartMenu
        m_StartMenu = asset.FindActionMap("StartMenu", throwIfNotFound: true);
        m_StartMenu_InputKBM = m_StartMenu.FindAction("InputKBM", throwIfNotFound: true);
        m_StartMenu_InputXbox = m_StartMenu.FindAction("InputXbox", throwIfNotFound: true);
        m_StartMenu_InputPlaystation = m_StartMenu.FindAction("InputPlaystation", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_MoveDown = m_Menu.FindAction("MoveDown", throwIfNotFound: true);
        m_Menu_MoveUp = m_Menu.FindAction("MoveUp", throwIfNotFound: true);
        m_Menu_MoveLeft = m_Menu.FindAction("MoveLeft", throwIfNotFound: true);
        m_Menu_MoveRight = m_Menu.FindAction("MoveRight", throwIfNotFound: true);
        m_Menu_Start = m_Menu.FindAction("Start", throwIfNotFound: true);
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

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private IGroundMovementActions m_GroundMovementActionsCallbackInterface;
    private readonly InputAction m_GroundMovement_HorizontalMovement;
    private readonly InputAction m_GroundMovement_Jump;
    private readonly InputAction m_GroundMovement_MouseX;
    private readonly InputAction m_GroundMovement_MouseY;
    private readonly InputAction m_GroundMovement_ToggleCursor;
    private readonly InputAction m_GroundMovement_ToggleUI;
    private readonly InputAction m_GroundMovement_Shoot;
    private readonly InputAction m_GroundMovement_DebugMenu1;
    private readonly InputAction m_GroundMovement_DebugMenu2;
    public struct GroundMovementActions
    {
        private @PlayerControls m_Wrapper;
        public GroundMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_GroundMovement_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_GroundMovement_Jump;
        public InputAction @MouseX => m_Wrapper.m_GroundMovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_GroundMovement_MouseY;
        public InputAction @ToggleCursor => m_Wrapper.m_GroundMovement_ToggleCursor;
        public InputAction @ToggleUI => m_Wrapper.m_GroundMovement_ToggleUI;
        public InputAction @Shoot => m_Wrapper.m_GroundMovement_Shoot;
        public InputAction @DebugMenu1 => m_Wrapper.m_GroundMovement_DebugMenu1;
        public InputAction @DebugMenu2 => m_Wrapper.m_GroundMovement_DebugMenu2;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnJump;
                @MouseX.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @ToggleCursor.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnToggleCursor;
                @ToggleCursor.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnToggleCursor;
                @ToggleCursor.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnToggleCursor;
                @ToggleUI.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnToggleUI;
                @ToggleUI.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnToggleUI;
                @ToggleUI.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnToggleUI;
                @Shoot.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnShoot;
                @DebugMenu1.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDebugMenu1;
                @DebugMenu1.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDebugMenu1;
                @DebugMenu1.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDebugMenu1;
                @DebugMenu2.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDebugMenu2;
                @DebugMenu2.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDebugMenu2;
                @DebugMenu2.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnDebugMenu2;
            }
            m_Wrapper.m_GroundMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @ToggleCursor.started += instance.OnToggleCursor;
                @ToggleCursor.performed += instance.OnToggleCursor;
                @ToggleCursor.canceled += instance.OnToggleCursor;
                @ToggleUI.started += instance.OnToggleUI;
                @ToggleUI.performed += instance.OnToggleUI;
                @ToggleUI.canceled += instance.OnToggleUI;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @DebugMenu1.started += instance.OnDebugMenu1;
                @DebugMenu1.performed += instance.OnDebugMenu1;
                @DebugMenu1.canceled += instance.OnDebugMenu1;
                @DebugMenu2.started += instance.OnDebugMenu2;
                @DebugMenu2.performed += instance.OnDebugMenu2;
                @DebugMenu2.canceled += instance.OnDebugMenu2;
            }
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);

    // StartMenu
    private readonly InputActionMap m_StartMenu;
    private IStartMenuActions m_StartMenuActionsCallbackInterface;
    private readonly InputAction m_StartMenu_InputKBM;
    private readonly InputAction m_StartMenu_InputXbox;
    private readonly InputAction m_StartMenu_InputPlaystation;
    public struct StartMenuActions
    {
        private @PlayerControls m_Wrapper;
        public StartMenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @InputKBM => m_Wrapper.m_StartMenu_InputKBM;
        public InputAction @InputXbox => m_Wrapper.m_StartMenu_InputXbox;
        public InputAction @InputPlaystation => m_Wrapper.m_StartMenu_InputPlaystation;
        public InputActionMap Get() { return m_Wrapper.m_StartMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StartMenuActions set) { return set.Get(); }
        public void SetCallbacks(IStartMenuActions instance)
        {
            if (m_Wrapper.m_StartMenuActionsCallbackInterface != null)
            {
                @InputKBM.started -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputKBM;
                @InputKBM.performed -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputKBM;
                @InputKBM.canceled -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputKBM;
                @InputXbox.started -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputXbox;
                @InputXbox.performed -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputXbox;
                @InputXbox.canceled -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputXbox;
                @InputPlaystation.started -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputPlaystation;
                @InputPlaystation.performed -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputPlaystation;
                @InputPlaystation.canceled -= m_Wrapper.m_StartMenuActionsCallbackInterface.OnInputPlaystation;
            }
            m_Wrapper.m_StartMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @InputKBM.started += instance.OnInputKBM;
                @InputKBM.performed += instance.OnInputKBM;
                @InputKBM.canceled += instance.OnInputKBM;
                @InputXbox.started += instance.OnInputXbox;
                @InputXbox.performed += instance.OnInputXbox;
                @InputXbox.canceled += instance.OnInputXbox;
                @InputPlaystation.started += instance.OnInputPlaystation;
                @InputPlaystation.performed += instance.OnInputPlaystation;
                @InputPlaystation.canceled += instance.OnInputPlaystation;
            }
        }
    }
    public StartMenuActions @StartMenu => new StartMenuActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_MoveDown;
    private readonly InputAction m_Menu_MoveUp;
    private readonly InputAction m_Menu_MoveLeft;
    private readonly InputAction m_Menu_MoveRight;
    private readonly InputAction m_Menu_Start;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveDown => m_Wrapper.m_Menu_MoveDown;
        public InputAction @MoveUp => m_Wrapper.m_Menu_MoveUp;
        public InputAction @MoveLeft => m_Wrapper.m_Menu_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Menu_MoveRight;
        public InputAction @Start => m_Wrapper.m_Menu_Start;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @MoveDown.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveDown;
                @MoveUp.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveUp;
                @MoveLeft.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveRight;
                @Start.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGroundMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnToggleCursor(InputAction.CallbackContext context);
        void OnToggleUI(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDebugMenu1(InputAction.CallbackContext context);
        void OnDebugMenu2(InputAction.CallbackContext context);
    }
    public interface IStartMenuActions
    {
        void OnInputKBM(InputAction.CallbackContext context);
        void OnInputXbox(InputAction.CallbackContext context);
        void OnInputPlaystation(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}

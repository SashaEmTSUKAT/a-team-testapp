using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class InputManager : MonoBehaviour
{
    private enum InputTypeEnum
    {
        UI,
        Analogue
    }

    [SerializeField] private InputTypeEnum _inputType;
    [SerializeField] private VisualInput _visualInput;
    [SerializeField] private Rigidbody _sphere;

    void Awake()
    {
        InitializeInputType(_inputType);
    }

    void InitializeInputType(InputTypeEnum InputType)
    {
        switch(InputType)
        {
            case InputTypeEnum.UI:
            {
                InitializeUI();
                return;
            }
            case InputTypeEnum.Analogue:
            {
                InitializeAnalogue();
                return;
            }
        }
    }

    void InitializeUI()
    {
        _visualInput = Instantiate(_visualInput);
        _visualInput.Button.onClick.AddListener(TurnOnGravity);
    }

    void InitializeAnalogue()
    {
        Debug.Log("I don't know how to use arduino.");
    }

    private void TurnOnGravity()
    {
        _sphere.useGravity = true;
    }

    
}

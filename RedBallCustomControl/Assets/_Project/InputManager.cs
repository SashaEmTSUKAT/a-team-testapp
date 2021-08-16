using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class InputManager : MonoBehaviour
{
    private enum InputType
    {
        UI,
        Analogue
    }

    [SerializeField] private InputType _inputType;
    [SerializeField] private VisualInput _uiInputCanvas;
    [SerializeField] private Rigidbody _sphere;

    void Awake()
    {
        InitializeInputType(_inputType);
    }

    void InitializeInputType(InputType InputType)
    {
        switch(InputType)
        {
            case InputType.UI:
            {
                InitializeUI();
                return;
            }
            case InputType.Analogue:
            {
                InitializeAnalogue();
                return;
            }
        }
    }

    void InitializeUI()
    {
        _uiInputCanvas = Instantiate(_uiInputCanvas);
        _uiInputCanvas.Button.onClick.AddListener(TurnOnGravity);
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

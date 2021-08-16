using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualInput : InputType
{
    [SerializeField] private Button _button;
    public Button Button => _button;
}

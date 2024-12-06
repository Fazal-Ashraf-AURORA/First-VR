using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRInputs : MonoBehaviour
{
    [Header("Right Controller")]
    [SerializeField] private InputActionReference _rightHandTrigger;
    [SerializeField] private InputActionReference _rightHandGrab;

    [Header("Left Controller")]
    [SerializeField] private InputActionReference _leftHandTrigger;
    [SerializeField] private InputActionReference _leftHandGrab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

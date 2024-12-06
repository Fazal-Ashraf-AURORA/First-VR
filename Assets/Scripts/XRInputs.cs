using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRInputs : MonoBehaviour
{
    [Header("Right Controller")]
    [SerializeField] private InputActionReference _rightHandTrigger;
    [SerializeField] private InputActionReference _rightHandGrab;
    [SerializeField] private InputActionReference _rightHandPrimaryButton;
    [SerializeField] private InputActionReference _rightHandSecondaryButton;

    [Header("Left Controller")]
    [SerializeField] private InputActionReference _leftHandTrigger;
    [SerializeField] private InputActionReference _leftHandGrab;
    [SerializeField] private InputActionReference _leftHandPrimaryButton;
    [SerializeField] private InputActionReference _leftHandSecondaryButton;

    // Update is called once per frame
    void Update()
    {
        RightHandController();

        LeftHandController();
    }
    private void RightHandController()
    {
       if(_rightHandTrigger.action.ReadValue<float>() > 0.5f)
       {
       Debug.Log("Right Hand Trigger Button Pressed");
       }

       if(_rightHandGrab.action.ReadValue<float>() > 0.5f)
       {
       Debug.Log("Right Hand Grab Button Pressed");
       }

       if(_rightHandPrimaryButton.action.ReadValue<float>() > 0.5f)
       {
       Debug.Log("Right Hand Primary Button Pressed");
       }

       if(_rightHandSecondaryButton.action.ReadValue<float>() > 0.5f)
       {
       Debug.Log("Right Hand Secondary Button Pressed");
       }
    }

    private void LeftHandController()
    {
        if (_leftHandTrigger.action.ReadValue<float>() > 0.5f)
        {
            Debug.Log("Left Hand Trigger Button Pressed");
        }

        if (_leftHandGrab.action.ReadValue<float>() > 0.5f)
        {
            Debug.Log("Left Hand Grab Button Pressed");
        }

        if (_leftHandPrimaryButton.action.ReadValue<float>() > 0.5f)
        {
            Debug.Log("Left Hand Primary Button Pressed");
        }

        if (_leftHandSecondaryButton.action.ReadValue<float>() > 0.5f)
        {
            Debug.Log("Left Hand Secondary Button Pressed");
        }
    }
}

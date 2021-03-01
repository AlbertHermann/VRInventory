using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectingTest : MonoBehaviour
{
    [SerializeField] XRDirectInteractor interactor;
    bool isPressed = false;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && !isPressed)
        {
            XRControllerState state = new XRControllerState();
            //state.activateInteractionState.active = true;
            state.selectInteractionState.active = true;
            state.selectInteractionState.activatedThisFrame = true;
            //interactor.interactionManager.RegisterInteractable(gameObject.GetComponent<XRGrabInteractable>());
            interactor.xrController.SetControllerState(state);

            //interactor.interactionManager.HoverEnter(interactor, gameObject.GetComponent<XRGrabInteractable>());
            //interactor.interactionManager.SelectEnter(interactor, gameObject.GetComponent<XRGrabInteractable>());
            interactor.interactionManager.ForceSelect(interactor, gameObject.GetComponent<XRGrabInteractable>());
            print("Selected");
        }
    }
}
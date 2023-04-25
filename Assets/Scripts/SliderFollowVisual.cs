using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SliderFollowVisual : MonoBehaviour
{
    public Transform visualTarget;
    public Vector3 localAxis;
    public float followAngleTreshold = 180;

    private bool freeze = false;

    private Vector3 initialLocalPos;

    private Vector3 offset;
    private Transform pokeAttachTransform;

    private XRBaseInteractable interactable;
    private bool isFollowing = false;

    public AudioClip click;

    public FlyJoystick control;


    // Start is called before the first frame update
    void Start()
    {
        initialLocalPos = visualTarget.localPosition;

        interactable = GetComponent<XRBaseInteractable>();
        interactable.hoverEntered.AddListener(Follow);
        interactable.hoverExited.AddListener(Reset);
        interactable.selectEntered.AddListener(Freeze);
    }

    public void Follow(BaseInteractionEventArgs hover)
    {
        if(hover.interactorObject is XRPokeInteractor)
        {
            XRPokeInteractor interactor = (XRPokeInteractor)hover.interactorObject;

            pokeAttachTransform = interactor.attachTransform;
            offset = visualTarget.position - pokeAttachTransform.position;

            float pokeAngle = Vector3.Angle(offset, visualTarget.TransformDirection(localAxis));

            if(pokeAngle < followAngleTreshold)
            {
                isFollowing = true;
                freeze = false;
            }
        }
    }

    public void Reset(BaseInteractionEventArgs hover)
    {
        if(hover.interactorObject is XRPokeInteractor)
        {
            isFollowing = false;
            freeze = false;
        }
    }

    public void Freeze(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRPokeInteractor)
        {
            freeze = true;
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (freeze)
            return;

        if(isFollowing)
        {
            Vector3 localTargetPosition = visualTarget.InverseTransformPoint(pokeAttachTransform.position + offset);
            Vector3 constrainedLocalTargetPosition = Vector3.Project(localTargetPosition, localAxis);

            visualTarget.position = visualTarget.TransformPoint(constrainedLocalTargetPosition);
            /*if (visualTarget.position.z > 0.45) 
                visualTarget.position = new Vector3(visualTarget.position.x, visualTarget.position.y, 0.45F);
            if (visualTarget.position.z < 0) 
                visualTarget.position = new Vector3(visualTarget.position.x, visualTarget.position.z, 0);
            */
            control.speed = visualTarget.localPosition.z * 50;
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
        }
    }
}

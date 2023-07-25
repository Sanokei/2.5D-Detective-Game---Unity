using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Utils;
using Lean.Transition;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] Camera playerCamera;
    [SerializeField] InspectableDictionary<string, PlayableDirector> Movement;
    [SerializeField] float speed = 10f;
    char LorR = 'R';
    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        
        if(translation != 0)
        {
            CharacterManager.Instance.FlipCharacter(translation < 0);
            CharacterManager.Instance.state = CharacterManager.CharacterState.Run;
            playerCamera.transform.localPositionTransition(new Vector3(playerCamera.transform.position.x + translation, playerCamera.transform.position.y, playerCamera.transform.position.z), 0.1f);
        }
    }
}

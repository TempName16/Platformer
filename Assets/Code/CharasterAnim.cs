using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharasterAnim : MonoBehaviour
{
    public Animator animator;
    int isWalkingHash, isRunningHash, isWalkingBHash;
    // Start is called before the first frame update
    void Start()
    {
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isWalkingHash = Animator.StringToHash("isWalkingB");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isWalkingB = animator.GetBool(isWalkingBHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool backPressed = Input.GetKey("s");
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }
        if (!isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }
        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
        if (!isWalkingB && backPressed)
        {
            animator.SetBool("isWalkingB", true);
        }
        if (!isWalkingB && !backPressed)
        {
            animator.SetBool("isWalkingB", false);
        }
    }
}

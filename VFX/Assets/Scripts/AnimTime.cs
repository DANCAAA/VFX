using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTime : MonoBehaviour {
    public float time;
    Animator mAnimator;
    float animationSpeed;
    public float AnimationSpeed {
        get {
            return animationSpeed;
        }
        set {
            animationSpeed = value;
        }
    }

	void Start () {
        mAnimator = GetComponent<Animator>();

    }

    void Update() {
        AnimatorStateInfo state = mAnimator.GetCurrentAnimatorStateInfo(0);
        time = state.normalizedTime * state.length * state.speed;
        Debug.Log(time);
        mAnimator.speed = animationSpeed;
    }
}

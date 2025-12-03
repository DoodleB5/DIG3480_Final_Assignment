using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 20f;
    public float movementSpeed = 10f;
    
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    AudioSource m_AudioSource;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Gets and stores horizontal and vertical inputs
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Forwards and backwards movement
        m_Movement = (transform.forward * vertical) * movementSpeed;
        m_Movement.y = m_Rigidbody.velocity.y;

        bool isWalking = Mathf.Abs(vertical) > 0.01f;
        m_Animator.SetBool("IsWalking", isWalking);

        if(Mathf.Abs(horizontal)>0.01f)
        {
            Quaternion deltaRotation = Quaternion.Euler(0f, horizontal * turnSpeed * Time.deltaTime, 0f);
            m_Rotation = m_Rigidbody.rotation * deltaRotation;
        }
       
        // Determines when to play footsteps sfx
        if (isWalking)
        {
            if (!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }
        }
        else
        {
            m_AudioSource.Stop();
        }
    }

 
    void OnAnimatorMove()
    {
        m_Rigidbody.MovePosition(m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation(m_Rotation);
    }
    
}

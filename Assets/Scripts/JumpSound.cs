using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    public AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Allows audio to play everytime player hits spacebar aka jump
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpSound.Play();
        }
    }
}

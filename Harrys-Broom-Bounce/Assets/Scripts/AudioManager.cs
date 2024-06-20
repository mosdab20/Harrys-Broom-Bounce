using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   [SerializeField] AudioSource musicSource;
   public AudioClip background;

    private void Start(){
        musicSource.clip = background;
        musicSource.Play();
    }


}
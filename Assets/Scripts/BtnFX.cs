using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnFX : MonoBehaviour
{
  public AudioSource myFX;
  public AudioClip clickFX;

  public void ClickSound()
  {
    myFX.PlayOneShot(clickFX);
  }
}

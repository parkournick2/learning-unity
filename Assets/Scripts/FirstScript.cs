using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
  public float position;
  void Start()
  {
    position = PlayerPrefs.GetFloat("POSITION", 1);
    position++;
    PlayerPrefs.SetFloat("POSITION", position);
  }
}

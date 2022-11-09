using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChickenAnimation : MonoBehaviour
{

  [SerializeField] public float duration = 3;
  [SerializeField] public Ease ease = Ease.Linear;
  [SerializeField] public float x = 0;
  [SerializeField] public float y = 0;
  [SerializeField] public float z = 0;

  [SerializeField] public GameObject chickenCam;

  void Start()
  {
    transform.DOMoveZ(z, duration).SetEase(ease);
    transform.DOMoveX(x, duration).SetEase(ease);
    transform.DOMoveY(y, duration).SetEase(ease);
  }

  private void Update()
  {
    Debug.Log($"Tempo: {Time.time}");

    if (Time.time >= duration)
    {
      chickenCam.SetActive(false);
      Debug.Log("Desativando a camera da galinha");
    }
  }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickFruitNinza : MonoBehaviour
{
    private TxtScoreUpdater txtUpdater;

    private void Awake()
    {
        txtUpdater = FindObjectOfType<TxtScoreUpdater>();
    }
    //[SerializeField] private ParticleSystem explosion;

    private void OnMouseDown()
    {
        txtUpdater.score++;
        gameObject.SetActive(false);
        //explosion.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickBadFruitNinza : MonoBehaviour
{
    [SerializeField] private UnityEngine.GameObject txtLose;

    private void OnMouseDown()
    {
        txtLose.SetActive(true);
        Time.timeScale = 0f;
    }
}

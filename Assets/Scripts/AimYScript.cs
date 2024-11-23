using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimYScript : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private float sensitivity;

    #endregion
    
    #region MONOBEHAVIOUR

    private void Update()
    {
        AimY();
    }

    #endregion

    #region HELPERS

    private void AimY()
    {
        var y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        y = Math.Clamp(y, -90f, 90f);
        transform.rotation = Quaternion.Euler(-y, 0f, 0f);
    }

    #endregion
}

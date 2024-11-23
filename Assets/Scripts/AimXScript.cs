using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimXScript : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private float sensitivity;

    #endregion
    
    #region MONOBEHAVIOUR

    private void Update()
    {
        AimX();
    }

    #endregion

    #region HELPERS

    private void AimX()
    {
        var x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, x, 0f);
    }

    #endregion
}

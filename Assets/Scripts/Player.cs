using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    private void Update()
    {
        float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
    }
}

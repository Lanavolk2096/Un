﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenuButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneLoader.instance.LoadScene(1);
    }
}

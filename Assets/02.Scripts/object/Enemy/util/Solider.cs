﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public abstract class Solider : MonoBehaviour
{
    public abstract void Play(float delay, float duration , float power);
    public bool isCompeleted = true;
    

}
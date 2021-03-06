﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


/// <summary>
/// UGUIMODEL组件，用来展示3D人物形象
/// </summary>
[RequireComponent(typeof(RectTransform),typeof(EmptyRaycast))]
public class UGUIModel : UIBehaviour, IDragHandler
{
    /// <summary>
    /// 模型的LayerName
    /// </summary>
    private const string UIModelLayerName = "UI_Model";

    [SerializeField]
    [Tooltip("模型的缩放")]
    private Vector3 scale = Vector3.one;
    [SerializeField]
    [Tooltip("模型的X坐标")]
    private float positionX = 0.0f;
    [SerializeField]
    [Tooltip("模型的Y坐标")]
    private float positionY = 0.0f;
    [SerializeField]
    [Tooltip("模型的X轴偏移量")]
    private float modelOffsetX = 0.0f;
    [SerializeField]
    [Tooltip("模型的Y轴偏移量")]
    private float modelOffsetY = 0.0f;

    [SerializeField]
    [Tooltip("相机距离模型的距离")]
    private float cameraDistance = 3.0f;
    [SerializeField]
    [Tooltip("相机相对模型高度")]
    private float cameraHeightOffset = 0.0f;
    [SerializeField]
    [Tooltip("模型是否可以旋转")]
    private bool enableRotate = true;

    public void OnDrag(PointerEventData eventData)
    {

    }
}

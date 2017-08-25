using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using System;

/// <summary>
/// 检测鼠标输入
/// </summary>
public class EmitInputSystem : IInitializeSystem, IExecuteSystem
{

    readonly InputContext _context;
    private InputEntity _leftMouseEntity;
    private InputEntity _rightMouseEntity;

    public EmitInputSystem(Contexts contexts)
    {
        _context = contexts.input;
       
    }

    /// <summary>
    /// 初始化创建leftMouse和rightMouseDeentity后保存下来
    /// </summary>
    public void Initialize()
    {
        _context.isLeftMouse = true;
        _context.isRightMouse = true;
        _leftMouseEntity = _context.leftMouseEntity;
        _rightMouseEntity = _context.rightMouseEntity;
    }

    /// <summary>
    /// 在leftMouse和rightMosue的Entity上添加或替换Position组件
    /// </summary>
    public void Execute()
    {
        //根据当前的鼠标位置获取世界坐标
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);

        //处理点击
        replacePositionProcess (_leftMouseEntity, 0, mousePosition);
        replacePositionProcess (_rightMouseEntity, 1, mousePosition);
    }
    //根据点击状态和鼠标的位置替换位置组件
    private void replacePositionProcess(InputEntity entity, int buttonNum, Vector2 mousePosition)
    {
        //如果判断到按键按下，替换entity上的mouseDown组件
        if (Input.GetMouseButtonDown (buttonNum))
            entity.ReplaceMouseDown (mousePosition);

        if (Input.GetMouseButton (buttonNum))
            entity.ReplaceMousePosition (mousePosition);

        if (Input.GetMouseButtonUp (buttonNum))
            entity.ReplaceMouseUp (mousePosition);
    }
}

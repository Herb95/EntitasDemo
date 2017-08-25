using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using System;

/// <summary>
/// 鼠标点击
/// 继承IExecuteSystem,添加到系统集中system,会每帧执行Execute方法
/// </summary>
public class LogMouseClickSystem : IExecuteSystem
{
    //game的环境
    readonly GameContext _context;
    public LogMouseClickSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _context.CreateEntity ().AddDebugMessage ("鼠标左键点击");
        }
        if (Input.GetMouseButtonDown (1))
        {
            _context.CreateEntity ().AddDebugMessage ("鼠标右键点击");
        }
    }
}

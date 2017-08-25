using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using System;

/// <summary>
/// 销毁打印的组件
/// 继承ICleanupSystem 
/// </summary>
public class CleanupDebugMessageSystem : ICleanupSystem
{
    //保存game环境
    readonly GameContext _context;
    //保存所拥有的debugmessage组件的Entity
    readonly IGroup<GameEntity> _debugMessages;
    //构造函数，添加game环境和保存拥有debugMessage组件的Group
    public CleanupDebugMessageSystem(Contexts contexts)
    {
        _context = contexts.game;
        _debugMessages = _context.GetGroup (GameMatcher.DebugMessage);
    }
    //Cleanup函数，只要有debugMessage组件的Entity就直接销毁
    public void Cleanup()
    {
        foreach (var e in _debugMessages.GetEntities())
        {
            e.Destroy ();
        }
    }
}

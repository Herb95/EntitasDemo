using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using System;

/// <summary>
/// 继承ReactiveSystem 功能只要cpmponent的值一发生变化，其中的execute就会执行
/// </summary>
public class DebugMessageSystem :ReactiveSystem<GameEntity>
{
    public DebugMessageSystem(Contexts contexts) : base (contexts.game) { }

    /// <summary>
    /// 过滤到的Component 统一执行操作
    /// </summary>
    /// <param name="entities"></param>
    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            Debug.Log (e.debugMessage.message);
        }
    }

    /// <summary>
    /// 最终检查，判断成功才能执行
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    protected override bool Filter(GameEntity entity)
    {
        return entity.hasDebugMessage;
    }

    /// <summary>
    /// 过滤获取指定Component的Entity，这里必须拥有DebugMessageCompoent的entity才能被提取
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        //返回过滤器
        return context.CreateCollector (GameMatcher.DebugMessage);
    }
}

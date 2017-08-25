using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;


// Unique标签 字面:唯一 可以直接在Context访问

/// <summary>
/// 鼠标左键
/// </summary>
[Input, Unique]
public class LeftMouseComponent : IComponent
{

}
/// <summary>
/// 鼠标右键
/// </summary>
[Input, Unique]
public class RightMouseComponent : IComponent
{

}

/// <summary>
/// 鼠标按下
/// </summary>
[Input]
public class MouseDownComponent : IComponent
{
    public Vector2 position;
}
/// <summary>
/// 鼠标位置
/// </summary>
[Input]
public class MousePositionComponent : IComponent
{
    public Vector2 position;
}

/// <summary>
/// 鼠标抬起
/// </summary>
[Input]
public class MouseUpComponent : IComponent
{
    public Vector2 position;
}
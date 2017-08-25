using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using System;

public class HelloWroldSystem : IInitializeSystem
{
    //game环境
    readonly GameContext _context;

    //创建时传入game环境
    public HelloWroldSystem(Contexts contexts)
    {
        _context = contexts.game;
    }
    //初始化方法
    public void Initialize()
    {
        //在game环境中创建一个entity，并在entity上添加一个debugMessageComonent，内容是HelloWrold
        _context.CreateEntity ().AddDebugMessage ("HelloWorld");
    }
}

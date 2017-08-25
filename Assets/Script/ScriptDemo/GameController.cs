using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
public class GameController : MonoBehaviour
{
    //存放系统集的最高节点，方然他本身也是个系统集
    Systems _systems;
    void Start()
    {
        //获取当前的环境组contexts，里面有game环境和input环境
        var contexts = Contexts.sharedInstance;
        //创建系统集，将自定义的系统集添加进去
        _systems = new Feature ("System").Add (new TutorialSystems (contexts));
        //初始化，会执行所有实现IIniteialSystem的Initialize方法
        //这边会创建拥有DebugeMessageComponent的Entity
        _systems.Initialize ();
    }
    private void Update()
    {
        //执行系统集中的所有Execute方法
        _systems.Execute ();
        //执行系统集中的所有Cleanup方法
        _systems.Cleanup ();
    }

}

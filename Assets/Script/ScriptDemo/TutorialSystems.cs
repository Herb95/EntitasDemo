
/// <summary>
/// 添加所有用到的System
/// </summary>
public class TutorialSystems : Feature
{
    /// <summary>
    /// 添加所有用到的System base里面是调试节点的名字
    /// </summary>
    /// <param name="contexts"></param>
    public TutorialSystems(Contexts contexts) : base ("Tutorial Systems")
    {
        Add (new HelloWroldSystem (contexts));
        Add (new DebugMessageSystem (contexts));
        Add (new CleanupDebugMessageSystem (contexts));
        Add (new EmitInputSystem (contexts));
    }
}

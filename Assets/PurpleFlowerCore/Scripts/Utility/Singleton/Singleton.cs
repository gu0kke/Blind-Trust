namespace PurpleFlowerCore
{
    /// <summary>
    /// 单例模式的基类
    /// </summary>
    public abstract class Singleton<T> where T : Singleton<T>, new()
    {
        private static T _instance;

        public static T Instance
        {
            get { return _instance ??= new T(); }
        }
    }

}
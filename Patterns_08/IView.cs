namespace Patterns_08
{
    /// <summary>
    /// Интерфейс представления
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// событие изменения представления
        /// </summary>
        event ViewHandler<IView> Changed;
        /// <summary>
        /// Задание контроллера
        /// </summary>
        /// <param name="cont">контроллер управления</param>
        void SetController(IController cont);
    }
}
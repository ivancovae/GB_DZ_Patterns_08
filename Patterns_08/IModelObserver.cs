namespace Patterns_08
{
    /// <summary>
    /// Интерфейс наблюдателя за моделью
    /// </summary>
    public interface IModelObserver
    {
        /// <summary>
        /// Изменение значения модели
        /// </summary>
        /// <param name="model">модель</param>
        /// <param name="e">параметр аргументов модели</param>
        void ValueChanged(IModel model, ModelEventArgs e);
    }
}
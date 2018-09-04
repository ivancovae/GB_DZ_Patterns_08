namespace Patterns_08
{
    /// <summary>
    /// Интерфейс модели
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// добавление слушателя
        /// </summary>
        /// <param name="imo">слушатель</param>
        void Attach(IModelObserver imo);
        /// <summary>
        /// Добавление нового значения
        /// </summary>
        /// <param name="nValue">значение</param>
        void AddNewValue(string nValue);
    }
}

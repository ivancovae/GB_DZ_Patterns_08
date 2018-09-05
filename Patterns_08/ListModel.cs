using System.Collections.Generic;

namespace Patterns_08
{
    /// <summary>
    /// Модель Списка показа
    /// </summary>
    public class ListModel : IModel
    {
        /// <summary>
        /// Событие, формируемое при изменение модели
        /// </summary>
        public event ModelHandler<ListModel> Changed;

        private List<string> list;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public ListModel() => list = new List<string>();
        /// <summary>
        /// добавить новое значение в модель
        /// </summary>
        /// <param name="nValue"></param>
        public void AddNewValue(string nValue)
        {
            list.Add(nValue);
            Changed.Invoke(this, new ModelEventArgs(nValue));
        }
        /// <summary>
        /// Добавление наблюдателя за изменениями
        /// </summary>
        /// <param name="imo">наблюдатель</param>
        public void Attach(IModelObserver imo) => Changed += new ModelHandler<ListModel>(imo.ValueChanged);
    }
}
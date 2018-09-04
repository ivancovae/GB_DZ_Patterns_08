namespace Patterns_08
{
    /// <summary>
    /// Контроллер задачи Списка показа
    /// </summary>
    public class ListController : IController
    {
        private IView view;
        private IModel model;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="v">представление</param>
        /// <param name="m">модель</param>
        public ListController(IView v, IModel m)
        {
            view = v;
            model = m;
            view.SetController(this);
            model.Attach((IModelObserver)view);
            view.Changed += new ViewHandler<IView>(this.ViewChanged);
        }
        /// <summary>
        /// Изменение представления приводит к изменению модели
        /// </summary>
        /// <param name="v">представление</param>
        /// <param name="e">параметры изменения</param>
        public void ViewChanged(IView v, ViewEventArgs e) => model.AddNewValue(e.value);
        /// <summary>
        /// Добавление значения в модель
        /// </summary>
        /// <param name="value">новое значение</param>
        public void AddValue(string value) => model.AddNewValue(value);
    }
}
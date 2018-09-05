using System;
namespace Patterns_08
{
    /// <summary>
    /// Делегат для оповещения об изменение модели
    /// </summary>
    /// <typeparam name="IModel">шаблон модели</typeparam>
    /// <param name="sender">отправитель</param>
    /// <param name="e">значение</param>
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);
    /// <summary>
    /// Делегат для оповещения об изменение представления
    /// </summary>
    /// <typeparam name="IView">шаблон представления</typeparam>
    /// <param name="sender">отправитель</param>
    /// <param name="e">значение</param>
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
    /// <summary>
    /// Аргументы события для модели
    /// </summary>
    public class ModelEventArgs : EventArgs
    {
        /// <summary>
        /// значение
        /// </summary>
        public string newValue;
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="v">значение</param>
        public ModelEventArgs(string v) => newValue = v;
    }
    /// <summary>
    /// Аргументы события для представления
    /// </summary>
    public class ViewEventArgs : EventArgs
    {
        /// <summary>
        /// значение
        /// </summary>
        public string value;
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="v">значение</param>
        public ViewEventArgs(string v) => value = v;
    }
}

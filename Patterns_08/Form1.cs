using System;
using System.Windows.Forms;

namespace Patterns_08
{
    /// <summary>
    /// Форма представления с прослушиванием модели
    /// </summary>
    public partial class Form1 : Form, IView, IModelObserver
    {
        private IController controller;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// событие изменения представления
        /// </summary>
        public event ViewHandler<IView> Changed;
        /// <summary>
        /// задание контроллера управления
        /// </summary>
        /// <param name="cont"></param>
        public void SetController(IController cont)
        {
            controller = cont;
        }
        /// <summary>
        /// Изменение значения
        /// </summary>
        /// <param name="model">модель</param>
        /// <param name="e">агрументы модели</param>
        public void ValueChanged(IModel model, ModelEventArgs e)
        {
            ListBox.Items.Add(e.newValue);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Changed.Invoke(this, new ViewEventArgs(TextBox.Text));
            //controller.AddValue(TextBox.Text);
        }
    }
}

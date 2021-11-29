namespace Cocomo
{
    /// <summary>
    /// Abstract Class: <br/>
    /// General Abstract Class COCOMO <br/>
    /// Общий абстрактный класс COCOMO
    /// </summary>
    public abstract class AbstractGeneralCocomo
    {
        /// <summary>
        /// Parameter: <br/>
        /// Number of thousands of lines of code <br/>
        /// Количество тысяч строк кода
        /// </summary>
        protected float kLOC = 0;

        /// <summary>
        /// Abstract constructor: <br/>
        /// The abstract constructor of the COCOMO abstract class<br/>
        /// Абстрактный конструктор абстрактного класса COCOMO
        /// </summary>
        /// <param name="kLOC">
        /// Number of thousands of lines of code <br/>
        /// Количество тысяч строк кода
        /// </param>
        /// <param name="isAutoUpdateResult">
        /// Auto-update property <br/>
        /// Свойство автообновления
        /// </param>
        public AbstractGeneralCocomo(float kLOC = 0, bool isAutoUpdateResult = true) => Instance(kLOC, isAutoUpdateResult);

        /// <summary>
        /// Property: <br/>
        /// Auto-update property <br/>
        /// Свойство автообновления
        /// </summary>
        public bool IsAutoUpdateResult { get; set; } = true;

        /// <summary>
        /// Property: <br/>
        /// KLOC parameter property <br/>
        /// Свойство параметра KLOC
        /// </summary>
        public float KLOC
        {
            get => kLOC; set
            {
                kLOC = value >= 0 ? value : 0;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Property: <br/>
        /// Laboriousness variable <br/>
        /// Переменная трудоемкости
        /// </summary>
        public double Laboriousness { get; protected set; }

        /// <summary>
        /// Property: <br/>
        /// Duration variable <br/>
        /// Переменная времени работы
        /// </summary>
        public double Duration { get; protected set; }

        /// <summary>
        /// Property: <br/>
        /// Number of developers variable <br/>
        /// Переменная количества разработчиков
        /// </summary>
        public double Developers { get; protected set; }

        /// <summary>
        /// Abstract method: <br/>
        /// Method for updating results <br/>
        /// Метод обновления результатов
        /// </summary>
        protected abstract void UpdateResult();

        /// <summary>
        /// Virtual method: <br/>
        /// Parameter update method with one result update <br/>
        /// Метод обновления парамеров с одним обновлением результата
        /// </summary>
        /// <param name="kLOC">
        /// Number of thousands of lines of code <br/>
        /// Количество тысяч строк кода
        /// </param>
        /// <param name="isAutoUpdateResult">
        /// Auto-update property <br/>
        /// Свойство автообновления
        /// </param>
        public virtual void Instance(float kLOC = 0, bool isAutoUpdateResult = true)
        {
            this.kLOC = kLOC >= 0 ? kLOC : 0;
            IsAutoUpdateResult = isAutoUpdateResult;
        }
    }
}

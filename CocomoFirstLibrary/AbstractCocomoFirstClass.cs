namespace Cocomo.First
{
    /// <summary>
    /// Abstract Class: <br/>
    /// Abstract Class COCOMO 1 <br/>
    /// Абстрактный класс COCOMO 1
    /// </summary>
    public abstract class AbstractCocomoFirst : AbstractGeneralCocomo
    {
        /// <summary>
        /// Parameter: <br/>
        /// Project team type <br/>
        /// Типа команды проекта
        /// </summary>
        protected TeamType teamType = TeamType.Organic;

        /// <summary>
        /// Abstract constructor: <br/>
        /// The abstract constructor of the COCOMO 1 abstract class<br/>
        /// Абстрактный конструктор абстрактного класса COCOMO 1
        /// </summary>
        /// <param name="kLOC">
        /// Number of thousands of lines of code <br/>
        /// Количество тысяч строк кода
        /// </param>
        /// <param name="teamType">
        /// Project team type <br/>
        /// Типа команды проекта</param>
        /// <param name="isAutoUpdateResult">
        /// Auto-update property <br/>
        /// Свойство автообновления
        /// </param>
        public AbstractCocomoFirst(float kLOC = 0, TeamType teamType = TeamType.Organic, bool isAutoUpdateResult = true) : base(kLOC, isAutoUpdateResult) => this.teamType = teamType;

        /// <summary>
        /// Property: <br/>
        /// Team type parameter property <br/>
        /// Свойство типа команды проекта
        /// </summary>
        public TeamType TeamType
        {
            get => teamType; set
            {
                teamType = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Abstract Property: <br/>
        /// Team type dictionary property <br/>
        /// Свойство словоря типов команд
        /// </summary>
        public abstract TeamTypeDictionary TeamTypes { get; protected set; }

        /// <summary>
        /// Method: <br/>
        /// Parameter update method with one result update <br/>
        /// Метод обновления парамеров с одним обновлением результата
        /// </summary>
        /// <param name="kLOC">
        /// Number of thousands of lines of code <br/>
        /// Количество тысяч строк кода
        /// </param>
        /// <param name="teamType">
        /// Project team type <br/>
        /// Типа команды проекта</param>
        /// <param name="isAutoUpdateResult">
        /// Auto-update property <br/>
        /// Свойство автообновления
        /// </param>
        public virtual void Instance(float kLOC = 0, TeamType teamType = TeamType.Organic, bool isAutoUpdateResult = true)
        {
            base.Instance(kLOC, isAutoUpdateResult);
            this.teamType = teamType;
        }
    }
}
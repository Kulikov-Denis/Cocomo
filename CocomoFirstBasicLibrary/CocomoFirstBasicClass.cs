namespace Cocomo.First.Basic
{
    /// <summary>
    /// Класс базового уровня COCOMO 1
    /// </summary>
    sealed public class CocomoFirstBasic : AbstractCocomoFirst
    {
        /// <summary>
        /// Abstract Property: <br/>
        /// Team type dictionary property <br/>
        /// Свойство словоря типов команд
        /// </summary>
        public override TeamTypeDictionary TeamTypes { get; protected set; } = new(
            оrganic: new(a: 2.4f, b: 1.05f, c: 2.5f, d: 0.38f),
            semidetached: new(a: 3.0f, b: 1.12f, c: 2.5f, d: 0.35f),
            embedded: new(a: 3.6f, b: 1.20f, c: 2.5f, d: 0.32f)
            );

        /// <summary>
        /// Abstract constructor: <br/>
        /// The constructor of the COCOMO 1 Basic<br/>
        /// Конструктор класса COCOMO 1 Basic
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
        public CocomoFirstBasic(float kLOC = 0, TeamType teamType = TeamType.Organic, bool isAutoUpdateResult = true) : base(kLOC, teamType, isAutoUpdateResult) => UpdateResult();

        /// <summary>
        /// Abstract method: <br/>
        /// Method for updating results <br/>
        /// Метод обновления результатов
        /// </summary>
        protected override void UpdateResult()
        {
            var (a, b, d, c) = TeamTypes.TeamTypes[TeamType];

            Laboriousness = a * System.Math.Pow(KLOC, b);
            Duration = d * System.Math.Pow(Laboriousness, c);
            Developers = Laboriousness / Duration;
        }

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
        public override void Instance(float kLOC = 0, TeamType teamType = TeamType.Organic, bool isAutoUpdateResult = true)
        {
            base.Instance(kLOC, teamType, isAutoUpdateResult);
            UpdateResult();
        }
    }
}
namespace Cocomo.First
{
    /// <summary>
    /// Class: <br/>
    /// Team type dictionary class <br/>
    /// Класс словаря типов команд
    /// </summary>
    public class TeamTypeDictionary
    {

        /// <summary>
        /// Property: <br/>
        /// Team type  dictionary property <br/>
        /// Свойство словаря типов команд
        /// </summary>
        public System.Collections.Generic.Dictionary<TeamType, TeamTypeParams> TeamTypes { get; init; }


        /// <summary>
        /// Сonstructor: <br/>
        /// The constructor accepts coefficients by team type <br/>
        /// Конструктор принимающий коэффициенты по типу команд
        /// </summary>
        /// <param name="оrganic">Органический вид</param>
        /// <param name="semidetached">Полуразделенный вид</param>
        /// <param name="embedded">Встроенный вид</param>
        public TeamTypeDictionary(TeamTypeParams оrganic, TeamTypeParams semidetached, TeamTypeParams embedded) => TeamTypes = new System.Collections.Generic.Dictionary<TeamType, TeamTypeParams>
        {
            [TeamType.Organic] = оrganic,
            [TeamType.Semidetached] = semidetached,
            [TeamType.Embedded] = embedded
        };

        /// <summary>
        /// Сonstructor: <br/>
        /// The constructor takes a dictionary <br/>
        /// Конструктор принимает словарь
        /// </summary>
        /// <param name="teamTypes">
        /// Team type dictionary property <br/>
        /// Свойство словаря типов команд
        /// </param>
        public TeamTypeDictionary(System.Collections.Generic.Dictionary<TeamType, TeamTypeParams> teamTypes) => TeamTypes = teamTypes;

        /// <summary>
        /// Property: <br/>
        /// The property of getting coefficients by command type - Organic mode <br/>
        /// Свойство получения коэффициентов по типу команды - Органический вид
        /// </summary>
        public TeamTypeParams Organic => TeamTypes[TeamType.Organic];

        /// <summary>
        /// Property: <br/>
        /// The property of getting coefficients by command type - Semidetached mode <br/>
        /// Свойство получения коэффициентов по типу команды - Полуразделенный вид
        /// </summary>
        public TeamTypeParams Semidetached => TeamTypes[TeamType.Semidetached];

        /// <summary>
        /// Property: <br/>
        /// The property of getting coefficients by command type - Embedded mode <br/>
        /// Свойство получения коэффициентов по типу команды - Встроенный вид
        /// </summary>
        public TeamTypeParams Embedded => TeamTypes[TeamType.Embedded];
    }
}

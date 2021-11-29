namespace Cocomo.First.Average
{
    /// <summary>
    /// Enum: <br/>
    /// Enum of criterions <br/>
    /// Перечень критериев
    /// </summary>
    public enum Criterion
    {
        /// <summary>
        /// Требуемая надежность ПО
        /// </summary>
        RSR,

        /// <summary>
        /// Размер БД приложения
        /// </summary>
        SAD,

        /// <summary>
        /// Сложность продукта
        /// </summary>
        COP,

        /// <summary>
        /// Ограничения быстродействия при выполнении программы
        /// </summary>
        RPC,

        /// <summary>
        /// Ограничения памяти
        /// </summary>
        MCS,

        /// <summary>
        /// Неустойчивость окружения виртуальной машины
        /// </summary>
        VVM,

        /// <summary>
        /// Требуемое время восстановления
        /// </summary>
        RTT,

        /// <summary>
        /// Аналитические способности
        /// </summary>
        ACY,

        /// <summary>
        /// Опыт разработки
        /// </summary>
        AEE,

        /// <summary>
        /// Способности к разработке ПО
        /// </summary>
        SEC,

        /// <summary>
        /// Опыт использования виртуальных машин
        /// </summary>
        VME,

        /// <summary>
        /// Опыт разработки на языках программирования
        /// </summary>
        PLE,

        /// <summary>
        /// Применение методов разработки ПО
        /// </summary>
        ASE,

        /// <summary>
        /// Использование инструментария разработки ПО
        /// </summary>
        UST,

        /// <summary>
        /// Требования соблюдения графика разработки
        /// </summary>
        RDS
    }
}

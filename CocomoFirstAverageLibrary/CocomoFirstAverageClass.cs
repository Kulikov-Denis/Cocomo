using System.Linq;

namespace Cocomo.First.Average
{
    /// <summary>
    /// Класс Промежуточного уровня COCOMO 1
    /// </summary>
    sealed public class CocomoFirstAverage : AbstractCocomoFirst
    {
        /// <summary>
        /// Конструктор для Average CCM First
        /// </summary>
        /// <param name="kLOC"></param>
        /// <param name="team"></param>
        /// <param name="autoUpdate"></param>
        /// <param name="criterions"></param>
        public CocomoFirstAverage(float kLOC = 0, TeamType team = TeamType.Organic, bool autoUpdate = true, СriterionDictionary criterions = null) : base(kLOC, team, autoUpdate)
        {
            Criterions = criterions ?? new();
            UpdateResult();
        }

        /// <summary>
        /// Abstract Property: <br/>
        /// Team type dictionary property <br/>
        /// Свойство словоря типов команд
        /// </summary>
        public override TeamTypeDictionary TeamTypes { get; protected set; } = new(
            оrganic: new(a: 3.2f, b: 1.05f, c: 2.5f, d: 0.38f),
            semidetached: new(a: 3.0f, b: 1.12f, c: 2.5f, d: 0.35f),
            embedded: new(a: 2.8f, b: 1.20f, c: 2.5f, d: 0.32f)
            );

        /// <summary>
        /// Abstract Property: <br/>
        /// Criterion dictionary property <br/>
        /// Свойство словоря критериев
        /// </summary>
        public СriterionDictionary Criterions { get; private set; }

        /// <summary>
        /// Свойство для Требуемая надежность ПО
        /// </summary>
        public Ratings RSR
        {
            get => Criterions.RSR.Value; set
            {
                Criterions.RSR.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Размер БД приложения
        /// </summary>
        public Ratings SAD
        {
            get => Criterions.SAD.Value; set
            {
                Criterions.SAD.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Сложность продукта
        /// </summary>
        public Ratings COP
        {
            get => Criterions.COP.Value; set
            {
                Criterions.COP.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Ограничения быстродействия при выполнении программы
        /// </summary>
        public Ratings RPC
        {
            get => Criterions.RPC.Value; set
            {
                Criterions.RPC.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Ограничения памяти
        /// </summary>
        public Ratings MCS
        {
            get => Criterions.MCS.Value; set
            {
                Criterions.MCS.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Неустойчивость окружения виртуальной машины
        /// </summary>
        public Ratings VVM
        {
            get => Criterions.VVM.Value; set
            {
                Criterions.VVM.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Требуемое время восстановления
        /// </summary>
        public Ratings RTT
        {
            get => Criterions.RTT.Value; set
            {
                Criterions.RTT.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Аналитические способности
        /// </summary>
        public Ratings ACY
        {
            get => Criterions.ACY.Value; set
            {
                Criterions.ACY.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Опыт разработки
        /// </summary>
        public Ratings AEE
        {
            get => Criterions.AEE.Value; set
            {
                Criterions.AEE.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Способности к разработке ПО
        /// </summary>
        public Ratings SEC
        {
            get => Criterions.SEC.Value; set
            {
                Criterions.SEC.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Опыт использования виртуальных машин
        /// </summary>
        public Ratings VME
        {
            get => Criterions.VME.Value; set
            {
                Criterions.VME.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Опыт разработки на языках программирования
        /// </summary>
        public Ratings PLE
        {
            get => Criterions.PLE.Value; set
            {
                Criterions.PLE.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Применение методов разработки ПО
        /// </summary>
        public Ratings ASE
        {
            get => Criterions.ASE.Value; set
            {
                Criterions.ASE.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Использование инструментария разработки ПО
        /// </summary>
        public Ratings UST
        {
            get => Criterions.UST.Value; set
            {
                Criterions.UST.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Свойство для Требования соблюдения графика разработки
        /// </summary>
        public Ratings RDS
        {
            get => Criterions.RDS.Value; set
            {
                Criterions.RDS.Value = value;
                if (IsAutoUpdateResult) UpdateResult();
            }
        }

        /// <summary>
        /// Метод выдачи проиведения коэффициентов
        /// </summary>
        /// <returns></returns>
        private float GetRFT() => Criterions.Rating.Values.Select(сriterion => сriterion.Rating.Rating[сriterion.Value] ?? 1).Aggregate((x, y) => x * y);

        /// <summary>
        /// Метод обновления результатов
        /// </summary>
        protected override void UpdateResult()
        {
            var (a, b, d, c) = TeamTypes.TeamTypes[TeamType];
            float rtf = GetRFT();

            Laboriousness = a * System.Math.Pow(KLOC, b) * rtf;
            Duration = d * System.Math.Pow(Laboriousness, c);
            Developers = Laboriousness / Duration;
        }

        /// <summary>
        /// Метод обновления парамеров с одним обновлением результата
        /// </summary>
        /// <param name="kLOC"></param>
        /// <param name="teamType"></param>
        /// <param name="isAutoUpdateResult"></param>
        public void Instance(float kLOC = 0, TeamType teamType = TeamType.Organic, bool isAutoUpdateResult = true, СriterionDictionary criterions = null)
        {
            base.Instance(kLOC, teamType, isAutoUpdateResult);
            Criterions = criterions ?? new();
            UpdateResult();
        }
    }
}
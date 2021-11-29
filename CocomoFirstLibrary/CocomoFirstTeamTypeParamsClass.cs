namespace Cocomo.First
{
    /// <summary>
    /// Record: <br/>
    /// Type coefficient class <br/>
    /// Класс коэффициентов типа
    /// </summary>
    public record TeamTypeParams
    {
        /// <summary>
        /// Property: <br/>
        /// Coefficient property - A <br/>
        /// Свойство коэффициента - A
        /// </summary>
        public float A { get; init; }

        /// <summary>
        /// Property: <br/>
        /// Coefficient property - B <br/>
        /// Свойство коэффициента - B
        /// </summary>
        public float B { get; init; }

        /// <summary>
        /// Property: <br/>
        /// Coefficient property - C <br/>
        /// Свойство коэффициента - C
        /// </summary>
        public float C { get; init; }

        /// <summary>
        /// Property: <br/>
        /// Coefficient property - D <br/>
        /// Свойство коэффициента - D
        /// </summary>
        public float D { get; init; }

        /// <summary>
        /// Constructor: <br/>
        /// The сonstructor accepts team type coefficients <br/>
        /// Конструктор принимает коэффициенты типа команды
        /// </summary>
        /// <param name="a">коэффициент - A</param>
        /// <param name="b">коэффициент - B</param>
        /// <param name="c">коэффициент - C</param>
        /// <param name="d">коэффициент - D</param>
        public TeamTypeParams(float a, float b, float c, float d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        /// <summary>
        /// Deconstructor: <br/>
        /// The deсonstructor accepts team type coefficients <br/>
        /// Деконструктор принимает коэффициенты типа команды
        /// </summary>
        /// <param name="a">коэффициент - A</param>
        /// <param name="b">коэффициент - B</param>
        /// <param name="c">коэффициент - C</param>
        /// <param name="d">коэффициент - D</param>
        public void Deconstruct(out float a, out float b, out float c, out float d)
        {
            a = A;
            b = B;
            c = C;
            d = D;
        }
    }
}

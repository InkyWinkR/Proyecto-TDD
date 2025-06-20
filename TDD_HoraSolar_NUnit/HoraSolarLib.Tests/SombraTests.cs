using NUnit.Framework;
using HoraSolarLib;

namespace HoraSolarLib.Tests;

[TestFixture]
public class SombraTests
{
    [Test]
    public void LongitudSombra_Altura10Hora9am_Retorna10()
    {
        var calc = new CalculadoraSolar();

        // 09:00 → ángulo solar interpolado = 45°
        double resultado = calc.CalcularLongitudSombra(10, new TimeSpan(9, 0, 0));

        Assert.That(resultado, Is.EqualTo(10).Within(0.001)); // altura = sombra cuando ángulo = 45°
    }

    [Test]
    public void LongitudSombra_Hora12pm_Angulo90_SombraCorta()
    {
        var calc = new CalculadoraSolar();
        double resultado = calc.CalcularLongitudSombra(10, new TimeSpan(12, 0, 0));

        // Usamos Within para tolerancia en comparación de punto flotante
        Assert.That(resultado, Is.EqualTo(0).Within(0.001));
    }

    [Test]
    public void LongitudSombra_Hora6am_LanzaExcepcion()
    {
        var calc = new CalculadoraSolar();

        // Validamos que se lanza la excepción esperada
        Assert.That(() => calc.CalcularLongitudSombra(10, new TimeSpan(6, 0, 0)),
                    Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void ObtenerAnguloSolar_Hora15_Retorna135()
    {
        var calc = new CalculadoraSolar();
        double angulo = calc.ObtenerAnguloSolar(new TimeSpan(15, 0, 0));

        // Comprobamos que el ángulo esté cerca de 135° con margen
        Assert.That(angulo, Is.EqualTo(135).Within(0.1));
    }

}



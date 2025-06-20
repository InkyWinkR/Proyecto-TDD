namespace HoraSolarLib;

public class CalculadoraSolar
{
    public double CalcularLongitudSombra(double altura, TimeSpan hora)
    {
        double angulo = ObtenerAnguloSolar(hora);

        if (angulo <= 0 || angulo >= 180)
            throw new ArgumentException("Ángulo solar inválido para calcular sombra.");

        double radianes = angulo * Math.PI / 180.0;
        return altura / Math.Tan(radianes);
    }

    public double ObtenerAnguloSolar(TimeSpan hora)
    {
        // Convertir hora en minutos desde las 6:00
        TimeSpan inicio = new TimeSpan(6, 0, 0);
        TimeSpan fin = new TimeSpan(18, 0, 0);
        
        // Validación para horarios y rangos inválidos
        if (hora < inicio || hora > fin)
        throw new ArgumentException("Hora fuera del rango solar (06:00–18:00)");

        double minutosDesde6am = (hora - inicio).TotalMinutes;
        double minutosTotales = (fin - inicio).TotalMinutes;

        // Ángulo solar va de 0° a 180° entre 06:00 y 18:00
        return (minutosDesde6am / minutosTotales) * 180.0;
    }
}

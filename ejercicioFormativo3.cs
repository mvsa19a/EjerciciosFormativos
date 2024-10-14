using System;


namespace GestionCalificaciones
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Diccionario para almacenar los estudiantes y sus calificaciones
            Dictionary<string, List<double>> estudiantes = new Dictionary<string, List<double>>();

            // Añadir estudiantes y sus calificaciones
            AgregarEstudiante(ref estudiantes, "Juan", new List<double> { 85, 90, 78 });
            AgregarEstudiante(ref estudiantes, "Ana", new List<double> { 95, 88, 92 });
            AgregarEstudiante(ref estudiantes, "Carlos", new List<double> { 70, 75, 80 });

            // Determinar el mejor y peor estudiante
            string mejorEstudiante, peorEstudiante;
            DeterminarMejorPeorEstudiante(ref estudiantes, out mejorEstudiante, out peorEstudiante);

            // Mostrar resultados
            Console.WriteLine($"El estudiante con el mejor promedio es: {mejorEstudiante}");
            Console.WriteLine($"El estudiante con el peor promedio es: {peorEstudiante}");

            Console.ReadKey();
        }

        // Funcion para agregar un estudiante con sus calificaciones
        public static void AgregarEstudiante(ref Dictionary<string, List<double>> estudiantes, string nombre, List<double> calificaciones)
        {
            estudiantes[nombre] = calificaciones;
            Console.WriteLine($"Estudiante '{nombre}' agregado con calificaciones.");
        }

        // Funcion para calcular el promedio de calificaciones de un estudiante
        public static double CalcularPromedio(List<double> calificaciones)
        {
            double suma = 0;
            foreach (double nota in calificaciones)
            {
                suma += nota;
            }
            return suma / calificaciones.Count;
        }

        // Funcion para determinar el estudiante con el promedio mas alto y el más bajo
        public static void DeterminarMejorPeorEstudiante(ref Dictionary<string, List<double>> estudiantes, out string mejorEstudiante, out string peorEstudiante)
        {
            mejorEstudiante = "";
            peorEstudiante = "";
            double mejorPromedio = double.MinValue;
            double peorPromedio = double.MaxValue;

            foreach (var estudiante in estudiantes)
            {
                double promedio = CalcularPromedio(estudiante.Value);

                if (promedio > mejorPromedio)
                {
                    mejorPromedio = promedio;
                    mejorEstudiante = estudiante.Key;
                }

                if (promedio < peorPromedio)
                {
                    peorPromedio = promedio;
                    peorEstudiante = estudiante.Key;
                }
            }
        }
    }
}

using System;

namespace patrones.Composite
{
	public class Start
	{
		public static void RunPatron()
		{
			var directorioRaiz = new Directorio("files");
			var file = new Archivo("file.txt", 4);
			var file2 = new Archivo("file2.txt", 10);
			directorioRaiz.AgregarHijo(file);
			directorioRaiz.AgregarHijo(file2);

			Console.WriteLine($"Nombre: {directorioRaiz.Nombre} Tamano:{directorioRaiz.ObtenerTamano}");
		}
	}
}

using Categorizer180;
using Microsoft.ML;
using Microsoft.ML.Data;

Console.WriteLine("=============== Incio Proceso: " + DateTime.Now.ToString() + "===============");
var str = "INCIDENCIA BBDD CLIENTE 918019 1#Código Tipología: T1 2#Código Tipo de Petición: ST96 3#Código Entidad/Mediador: G65089 4#Código Peticionario:  5#Mail Peticionario: robotrpa1.es@generali.com       6#Teléfono Peticionario: 7#Cliente (DNI) (Opcional): 8#Póliza (RamoCiaPóliza) (Opcional): 9#Aplicación (Opcional):  10#Agrupación Ramo:  11#Observaciones: INCIDENCIA: 918019  con mediador: 65089 ######";
float maxScore;
//Dato de ejemplo a procesar
var sampleData = new MLModel1.ModelInput()
{
    Input = @str,
};

//Cargar el modelo y realizar la predicción para el dato de ejemplo
var result = MLModel1.Predict(sampleData, Path.GetFullPath("MLModel1.mlnet"));


//Mostrar los rsultados por consola estandar
PrintResults(result, str);

// Resultados ordenados por categoria
//var result2 = MLModel1.PredictAllLabels(sampleData, Path.GetFullPath("MLModel1.mlnet"));
//Console.WriteLine("{" + string.Join(",\n ", result2.Select(m => $"{m.Key}={m.Value*100}")) + "}");
//Console.WriteLine("{" + string.Join(", ", result2) + "}");

Console.WriteLine("=============== Fin Proceso: " + DateTime.Now.ToString() + "===============");
  void PrintResults(MLModel1.ModelOutput result, String str)
{
    Console.WriteLine("Path del Modelo:" + Path.GetFullPath("MLModel1.mlnet"));
    Console.WriteLine(" Ejemplo: " + str[..25]);
    Console.WriteLine(" Categorias: " + result.Score.Length);
    Console.WriteLine(" Predicción: " + result.PredictedLabel);
    maxScore = getMaxScore(result);
    Console.WriteLine($"El máximo valor es {maxScore} y representa el {(maxScore / 1) * 100}% del total.");

}

static float getMaxScore(MLModel1.ModelOutput result)
{
    float maxScore = 0;
    foreach (float score in result.Score)
        if (score > maxScore)
            maxScore = score;
    return maxScore;
}
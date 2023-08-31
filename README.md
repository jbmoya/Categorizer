
# Proyecto Categorizer de Predicción con ML.Net

Este proyecto implementa un modelo de Machine Learning en .NET 6.0 utilizando la librería ML.Net de Microsoft.

## Descripción 

El objetivo es predecir una variable de salida pasando inputs de ejemplo a un modelo entrenado previamente. El modelo implementado es un árbol de decisión FastTree entrenado con un dataset (entreno previo).

La aplicación consume el modelo y permite al usuario pasar nuevos ejemplos en formato String para obtener una predicción.

La finalidad es generar una libreria que pueda ser consumida desde Uipath mediante por ejemplo, un Invoke Code

## Características

- Uso de ML.Net para entrenar e implementar un modelo FastTree
- Carga del modelo entrenado desde un archivo .csv
- Método para realizar predicciones pasando nuevos datos 
- Ejemplos de uso y pruebas

## Dependencias

- .NET 6.0
- ML.Net 2.0.1 
- Microsoft.ML.FastTree 2.0.1 
- Dataset de entrenamiento (incluido)

## Ejecución

Para ejecutar el proyecto:

1. Clona este repositorio
2. Abre la solución en Visual Studio 2022
3. Restaura los paquetes de NuGet
4. Compila la solución
5. Ejecuta la aplicación consola 
6. Prueba pasando nuevos datos de ejemplo

## Contribuciones

Las contribuciones y mejoras son bienvenidas! Por favor abre un issue o pull request en GitHub. 

## Licencia  

Este proyecto tiene licencia MIT.

## Contacto

Autor: Jordi Bargalló
LinkedIn: https://es.linkedin.com/in/bargallo
Correo: bargallo@gmail.com


//programa que permita visualizar los departamentosde nicaragua con
//su calidad poblacional.
//Encuentre: Mayor, menor, sumas y orden de datos
using System.Collections;
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 550856, 414543, 229866, 214137, 475630, 421050, 174744, 1546939, 391803, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
    .Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
    .ToDictionary(x => x.Clave, x => x.Valor);
// Encontrar el mayor y el menor (población)
int maxDep = Poblacion.Max();
int minDep = Poblacion.Min();
string maxDepkey = "", minDepkey = "";
// Encontrar el nombre del departamento que tiene la mayor y menor población
for (var i = 0; i < Poblacion.Length; i++)
{
    if (Poblacion[i] == maxDep)
        maxDepkey = Departamento[i];
    if (Poblacion[i] == minDep)
        minDepkey = Departamento[i];
}
// Mostrar el diccionario sin ordenar
Console.WriteLine($"Datos desordenados:");
foreach (var item in diccionario)
<<<<<<< HEAD
Console.WriteLine ($"{item.Key,-20} ==> {item.Value,10:N0}");
//Ordenarndocon LINQ OrdeBy el diccionario
 //Sumar todas las poblacione con SUM de LINQ 
Console.WriteLine ($" Población General:{diccionario.Values.Sum():N0}");
Console.WriteLine ($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine ($"Departamento con menor Población:{minDepkey}");
//Población promedio
Console.WriteLine($"Población preomedio:{diccionario.Values.Average():N2}");
=======
    Console.WriteLine($"({item.Key,-20}) == {item.Value,10:N0}");
    Console.WriteLine();
// Mostrar resultado
for (var i = 0; i < Poblacion.Length; i++)
    Console.WriteLine($"{Departamento[i],20} => {Poblacion[i],10:N0}");
// Sumar todas las poblaciones con SUM de LINQ
Console.WriteLine($"Población General: {diccionario.Values.Sum():N0}");
Console.WriteLine($"Departamento con mayor población: {maxDepkey}");
Console.WriteLine($"Departamento con menor población: {minDepkey}");

>>>>>>> 9c990dbfb19682be3c13f03b631958dd06f469b3

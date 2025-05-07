using System.Collections;
//defincion e inicialización de los arreglos en paralelo y el diccionario
String[] Departamento = {"Boaco","Carazo","Chinandega","Chontales","Costa Caribe Norte","Costa Caribe Sur","Estelf","Granada","Jinotega","León","Madriz","Managua","Masaya","Matagalpa","Nueva Segovia","Rio San、Juan","Rivas"}; 
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1575819, 391903, 593503, 271581, 135446, 182645};
Dictionary<string, int> diccionario = Departamento
.Zip(Poblacion, (k, v)=> new {Clave = k, Valor = v})
.ToDictionary (x => x.Clave, x => x.Valor);
//Ordenando el diccionario de menor a mayor
var ordenado = diccionario.OrderBy (x => x.Value).ToDictionary (x => x.Key, x => x.Value);
//fijando los nombres de los departamen tos con menor y mayor poblacion
string minDepkey = ordenado. First () .Key;
string maxDepkey= ordenado. Last ().Key;
 //reasignación de los arreglos en paralelo 
Departamento = ordenado.Keys.ToArray ();
Poblacion = ordenado.Values.ToArray ();
//Mostrar el diccionario sin ordenar
Console.WriteLine($"datos Desordenados");
foreach (var item in diccionario)
Console.WriteLine ($"{item.Key,-20} ==> {item.Value,10:N0}");
//Ordenarndocon LINQ OrdeBy el diccionario
 //Sumar todas las poblacione con SUM de LINQ 
Console.WriteLine ($" Población General:{diccionario.Values.Sum():N0}");
Console.WriteLine ($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine ($"Departamento con menor Población:{minDepkey}");
//Población promedio
Console.WriteLine($"Población preomedio:{diccionario.Values.Average():N2}");

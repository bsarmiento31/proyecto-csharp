// See https://aka.ms/new-console-template for more information
// string nombre = "Jose ";
// Console.WriteLine($"Mi nombre es {nombre} desde el main ");
// Saludo(nombre);
// Console.WriteLine($"Despues del saludo");
// InvertirPalabra();
// void InvertirPalabra()
// {
//         Console.WriteLine($"ingrese la palabra a invertir ");
//         string? palabra = Console.ReadLine();
//         if(palabra is not null){
//             var vpalabra = palabra.ToCharArray();
//             string palabraInvertida="";
//             for(ushort i=(ushort)(vpalabra.Length-1);i==0;i--)
//             {
//                 palabraInvertida+=palabra[i];

//             }

//             Console.WriteLine($"Palabra = {palabraInvertida}");

//         }
// }

// TipoDatos();


// void TipoDatos()
// {
//     ushort minUshort = ushort.MinValue;
//     ushort maxUshort = ushort.MaxValue;
//     short minshort = short.MinValue;
//     short maxshort = short.MaxValue;

//     Console.WriteLine($"Rango de ushort: {minUshort} a {maxUshort}");
//     Console.WriteLine($"Rango de ushort: {minshort} a {maxshort}");


// }

// void Saludo(string nombre)
// {
//     string apellido = "Pajaro";
//     Console.WriteLine($"Saludo desde el metodo soy {nombre} {apellido}");
// }

using System.Collections;
using Newtonsoft.Json;

//arreglos();

// Boxing();

// void Boxing(){

//     ArrayList Salarios = new ArrayList();
//     Salarios.Add(1500);
//     Salarios.Add(2500);
//     Salarios.Add(1800);

    

    

// }

// void arreglos(){
    
//     ushort size = 5;
//     var vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
//     var consonantes = new char[]{ 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
//     var digitos = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

//     var alfabeto = vocales.Union(consonantes).ToArray();
//     string res="";

//     for(ushort i=0;i<size;i++)
//     {
//         bool letra= new Random().Next(0,100) <=50? true:false;

//         if(letra){
//             int k= new Random().Next(0,alfabeto.Length-1);
//             bool lower= new Random().Next(0,100) <=50? true:false;
//             res+=lower ? alfabeto[k]:alfabeto[k].ToString().ToUpper();
//         }else{
//             int n= new Random().Next(0,9);
//             res+=digitos[n].ToString();
//         }

//     }

//     Console.WriteLine($"El string aleatorio es {res}");

//     ArrayList caracteres = new ArrayList();

//     caracteres.Add(size);
//     caracteres.Add(vocales);
//     caracteres.Add(consonantes);
//     caracteres.Add(alfabeto);
//     caracteres.Add(digitos);
//     foreach(var item in caracteres){
//         Console.WriteLine($"Valor {item}");
//     }

// }
ejercicio();
noRepetidos();

void noRepetidos(){
   string[] palabras = { "Hola", "Casa", "Hola", "Perro", "Casa", "Hola", "Casa", "Hola", "Gato", "Perro" };
    //No repetidos
    var noRepetidos = palabras.ToHashSet().ToList();

    foreach(var item in noRepetidos){
            Console.WriteLine($"{item}");
        }
}

void ejercicio(){
    string[] palabras = { "Hola", "Casa", "Hola", "Perro", "Casa", "Hola", "Casa", "Hola", "Gato", "Perro" };
    Dictionary <string,int> dic = new Dictionary <string,int>();

    foreach(var palabra in palabras){
        if(dic.Keys.Contains(palabra))
            dic[palabra]+=1;
        else
            dic.Add(palabra,1);
    }
    Console.WriteLine($"Palabra     Conteo ");
    Console.WriteLine($"=======     ====== ");
    foreach(var item in dic){
            Console.WriteLine($"{item.Key} \t\t {item.Value}");
        }

}
LoadJson();
void LoadJson(){

using (StreamReader r = new StreamReader("customers.json"))
    {
        
        string json = r.ReadToEnd();
        List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);
        //var resp1 = customers.Find(it => it.country == "Spain");
        var resp2 = customers.FindAll(it => it.city == "London");
        //var resp3 = customers.FindAll(it => it.companyName.StartsWith("P"));
        //Console.WriteLine($"Tipo de resp es: {resp.GetType()}");

 

        //MostrarEmpresa(resp1);
        ListarEmpresas(resp2);
    }

}

void MostrarEmpresa(Customer item){
     Console.WriteLine($"Empresa: {item.companyName}");
        Console.WriteLine($"Contacto: {item.contactName}");
        Console.WriteLine($"Direccion: {item.address}");
        Console.WriteLine($"País: {item.country}");
        Console.WriteLine($"Ciudad: {item.city}");
        Console.WriteLine($"-----------------------------");
}

void ListarEmpresas(List<Customer> datos){

    foreach(var item in datos){
        Console.WriteLine($"Empresa: {item.companyName}");
        Console.WriteLine($"Contacto: {item.contactName}");
        Console.WriteLine($"Direccion: {item.address}");
        Console.WriteLine($"País: {item.country}");
        Console.WriteLine($"Ciudad: {item.city}");
        Console.WriteLine($"-----------------------------");
    }

}

public class Customer{

    public string id {get;set;}
    public string companyName {get;set;}
    public string contactName {get;set;}
    public string contactTitle {get;set;}
    public string address {get;set;}
    public string city {get;set;}
    public string postalCode {get;set;}
    public string country {get;set;}
    public string phone {get;set;}
    public string fax {get;set;}

}
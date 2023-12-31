using System;

namespace Casa_computacion
{ //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más 
//una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total 
//facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
    class Program              
    {
        static void Main(string[] args)
        { 

       double totalFacturado, comision, sueldoFinal; // DECLARO VARIABLE
        Console.WriteLine("Ingrese un valor para el total facturado:"); //LE ASIGNO UN VALOR CON EL PARTE...ETC
        totalFacturado = double.Parse (Console.ReadLine());
        
        comision = (totalFacturado * 0.05);  // O PUEDO HACER 5 * totalFacturado / 100;  o tambien comision =  totalfacturado - totalfacturado * 0.95 USAMOS PUNTO NO COMA
        sueldoFinal =  (comision + 150000); 
        Console.WriteLine ("El sueldo Final es:" + sueldoFinal);
        
            
        }
    }
}

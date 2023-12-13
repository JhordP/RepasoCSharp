using System;

public class Variables
{
	public Variables()
	{
		//---TIPOS DE DATOS SIMPLES---

		//Byte que toma solo numeros positivos hasta el 255
		byte num_byte = 255;

		//Byte que toma numeros negativos y positivos pero cortados a la mitad (-128 al 127)
		sbyte num_sbyte = -127;

		//Short, para nums no tan grandes
		short num_short = 0;
		//Short pero solo toma positivos
		ushort num_ushort = 0;

		//El entero de siempre
		int num_int = 0;
		//Entero pero solo toma positivos
		uint num_uint = 0;

		//Long, para numerotes mas grande que un int
		long num_long = 0;
		//Lo mismo, solo toma positivos
		ulong num_ulong = 0;

		//Decimales
		float num_float = 1.55f; //Tener en cuenta la f al final
		double num_double = 1.55555555555d; //Tiene el doble de presicion decimal, la d es opcional
		decimal num_decimal = 0m; //Tiene mucho más alcance de decimales. Pesa más.

		//Letras
		char caracter = 'a';
		

		//---TIPOS DE DATOS COMPUESTOS---
		string caracteres = "BBBBB";
		DateTime fecha = DateTime.Now; //Fecha de este momento
		bool cond = false; //True or False
		var valor = ""; //Al colocarle un valor en la literal, c# le asigna un tipo, pero no se puede cambiar el tipo de dato (Solo se utiliza dentro de metodos)
		
		//valor anonimo
		object persona = new
		{
			nombre = "Jhordany",
			apellido = "Polanco"
		};
		//caracteres = persona.nombre; no funciona

		//Los atributos tipo object pierden los tipos de datos, pero si es un var, este asigna los atributos a su valor automaticamente
		var personavar = new
		{
			nombre = "Jhordany",
			apellido = "Polanco"
		};
		caracteres = personavar.apellido; //Este SI funciona ya que los atributos funcionan como variables
		


		//---NULLS---

		//Para que un tipo de dato permita nulls, se debe colocar el signo de ? luego del tipo de dato
		int? num = null; //Permite que un int sea nullable, asi te aseguras que no coloque un valor por defecto.

	}
}

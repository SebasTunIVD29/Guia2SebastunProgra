Algoritmo Ejercicio2
	Definir num1, num2, opc, result Como Real
	Definir msj Como Caracter
	Escribir Sin Saltar "Dijite dos valores numericos: "
	Leer num1
	Leer num2
	
	//Menu de las operaciones
	Escribir "*********************************"
	Escribir "MENU PRINCIPAL"
	Escribir "1- suma"
	Escribir "2- Resta"
	Escribir "3- Multiplicacion"
	Escribir "4- Division"
	Escribir "5- Salir"
	Escribir Sin Saltar "Dijite el numero segun su operacion: "
	Leer opc
	
	//evaluar la Opcion 
	Segun opc Hacer
		1:
			msj="El resultado de la suma es: "
			result=num1+num2
		2:
			msj="El resultado de la Resta es: "
			result=num1-num2
		3:
			msj="El resultado de la multiplicacion es: "
			result=num1*num2
		4:
			msj="El resultado de la Division es: "
			result=num1/num2
		5:
			msj="Saliendo del sistema "
			
		De Otro Modo:
			msj="Seleccionae una opciones valida !!!"
	Fin Segun
	Escribir msj
	Escribir result
FinAlgoritmo

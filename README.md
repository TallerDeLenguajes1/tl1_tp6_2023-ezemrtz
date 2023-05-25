# tl1_tp6_2023-ezemrtz Ezequiel Martinez

## Ejercicio 4
* ¿String es una tipo por valor o un tipo por referencia?

String es un tipo de dato por referencia. Al no tener un tamaño determinado se guarda en el Heap.

* ¿Qué secuencias de escape tiene el tipo string?

\'	Comilla simple.
\"	Comilla doble
\\	Barra diagonal inversa.
\0	Null.
\a	Alerta.
\b	Retroceso.
\f	Avance de página.
\n	Nueva línea.
\r	Retorno de carro.
\t	Tabulación horizontal.
\v	Tabulación vertical.
\u	Secuencia de escape Unicode (UTF-16).
\U	Secuencia de escape Unicode (UTF-32).
\x	Secuencia de escape Unicode similar a "\u" excepto con longitud .variable.

* ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Las cadenas interpoladas se identifican por el carácter especial $ e incluyen expresiones interpoladas entre llaves. La interpolación de cadenas se usa para mejorar la legibilidad y el mantenimiento del código. Con la interpolación de cadenas se obtienen los mismos resultados que con el método String.Format, pero mejora la facilidad de uso y la claridad en línea.

El caracter @ se utiliza para literales de cadenas, es decir lo que esta dentro de la cadena se muestra tal cual en la salida, asi sea si se estan usando comillas dobles o barras invertidas.


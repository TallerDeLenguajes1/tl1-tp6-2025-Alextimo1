¿String es una tipo por valor o un tipo por referencia?
En C#, string es un tipo por referencia porque internamente apunta a un objeto.
Sin embargo, se comporta como si fuera inmutable: cuando lo modificás, en realidad estás creando un nuevo objeto.

¿Qué secuencias de escape tiene el tipo string?
\n → nueva línea

\t → tabulación

\\ → barra invertida

\" → comillas dobles

\' → comillas simples

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
@ permite cadenas multilínea y evita escapar caracteres

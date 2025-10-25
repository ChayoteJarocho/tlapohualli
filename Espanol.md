# Explanation

El Náhuatl es la lengua de los Mexicas, también conocidos como Aztecas.

Tlapohualli significa **número** en Náhuatl.

A diferencia de la mayoría de las sociedades modernas que usan un sistema numérico en base 10, los Aztecas usaban un sistema numérico en base 20. Eligieron esta base porque usaban sus dedos de manos y pies para contar.

Traducir números de base 10 (nuestro sistema) a base 20 (el sistema Azteca) y viceversa es una tarea que require hacer sumas, multiplicaciones y divisiones sobre la marcha. Esta complejidad fue lo que me motivó a escribir este programa.

## Cómo funciona su sistema numérico

Los Aztecas no tenían un lenguaje escrito. Después de la conquista, los sacerdotes españoles fueron quienes escribieron la lengua Azteca, usando (principalmente) reglas prestadas del idioma español, más algunas otras que tuvieron que inventar para representar algunos sonidos que no existen en español.

Los números del 1 al 4 pertenecen a su propio grupo especial:

- 1 = Ce
- 2 = Ome
- 3 = Yei
- 4 = Nahui

El número 5 tiene un nombre único:

- 5 = Macuilli

Los números del 6 al 9 reutilizan los nombres del grupo especial de los números del 1 al 4, pero con un prefijo compartido (chic...), que indica que son los números que _preceden_ al 5:

- 6 = Chicuace
- 7 = Chicome
- 8 = Chicuei
- 9 = Chicnahui

El número 10 también tiene un nombre único:

- 10 = Mahtlahtli

Los números del 11 al 14 reutilizan los números del 1 al 4, al igual que del 6 al 9, pero con la gran diferencia de que estos son precedidos explícitamente por el número 10. Piensa en esto como una suma (10+1, 10+2, 10+3, 10+4):

- 11 = Mahtlahtlin ce
- 12 = Mahtlahtlin ome
- 13 = Mahtlahtlin yei
- 14 = Mahtlahtlin nahui

Nota que la palabra Mahtlatli termina con una **n** cuando se usa como prefijo.

El número 15 es otro número con un nombre único:

- 15 = Caxtollin

Y la misma regla que usamos del 10 al 14 se usa con el 16 al 19 (15+1, 15+2, 15+3, 15+4):

- 16 = Caxtollin ce
- 17 = Caxtollin ome
- 18 = Caxtollin yei
- 19 = Caxtollin nahui

Y aquí es donde encontramos el primer número del sistema numérico base 20:

- 20 = **Cempohualli**

A partir de ahora, las reglas de suma que viste del 1 al 19 se reutilizan, con la pequeña diferencia de que la palabra **huan**, que significa **y**, une el número base (20 en este caso) con el resto:

- 21 = Cempohualli huan ce
- 22 = Cempohualli huan ome
- 23 = Cempohualli huan yei
- 24 = Cempohualli huan nahui
- 25 = Cempohualli huan macuilli
- 26 = Cempohualli huan chicuace
- 27 = Cempohualli huan chicome
- 28 = Cempohualli huan chicuei
- 29 = Cempohualli huan chicnahui

- 30 = Cempohualli huan mahtlahtli
- 31 = Cempohualli huan mahtlahtlin ce
- 32 = Cempohualli huan mahtlahtlin ome
- 33 = Cempohualli huan mahtlahtlin yei
- 34 = Cempohualli huan mahtlahtlin nahui
- 35 = Cempohualli huan caxtollin (20 + 15)
- 36 = Cempohualli huan caxtollin ce
- 37 = Cempohualli huan caxtollin ome
- 38 = Cempohualli huan caxtollin yei
- 39 = Cempohualli huan caxtollin nahui

Cuando llegas a un múltiplo de 20, lo precedes con un número del 1 al 19 para **multiplicarlo**:

- 40 = Ome cempohualli (2 x 20)

Otra forma de entender esto: cuando un número menor precede a uno mayor, los multiplicas. Cuando un número mayor precede a uno menor (o está unido por **huan**), los sumas:

- 41 = Ome cempohualli huan ce (2 x 20 + 1)

  ...

- 50 = Ome cempohualli huan mahtlahtli (2 x 20 + 10)

  ...

- 60 = Yei cempohualli (3 x 20)

  ...

- 100 = Macuilli cempohualli (5 x 20)

  ...

- 200 = Mahtlahtli cempohualli (10 x 20)

  ...

- 300 = Caxtollin cempohualli (15 x 20)

  ...

- 399 = Caxtollin nahui cempohualli huan mahtlahtli nahui (19 x 20 + 10 + 9)

Y entonces, llegas a 400. Como este es un sistema base 20, no puede haber un 20 x 20. En su lugar, 400 tiene su propia palabra única:

- 400 = **Cenzontli**

Aquí comienza la creatividad: necesitas realizar una división, luego usar el divisor, el cociente y el residuo para indicar el número. Formato: `Cociente` `divisor` `huan` `residuo`

- 401 = Ce cenzontli huan ce (1cociente x 400divisor + 1residuo)
- 402 = Ce cenzontli huan ome (1 x 400 + 2)

  ...

- 500 = Ce cenzontli huan macuilli cempohualli (1 x 400 + 5 x 20)

  ...

- 700 = Ce cenzontli huan caxtollin cempohualli (1 x 400 + 15 x 20)

  ...

- 800 = Ome cenzontli (2 x 400)

  ...

- 1,000 = Ome cenzontli huan mahtlahtli cempohualli (2 x 400 + 10 x 20)

  ...

- 2,000 = Macuilli cempohualli (5 x 400)

  ...

400x20 es 8,000. El nombre para ese número es:

- 8,000 = **Xiquipilli**

A partir de ahora, en la mayoría de los casos tendrás que hacer dos divisiones separadas, ya que el primer residuo debe ser explicado también. Formato: `Cociente1` x `divisor1` `huan` `residuo1` `cociente2` x `divisor2` + `residuo2`

- 8,001 = Ce xiquipilli huan ome (1 x 8000 + 1) (Esta es una excepción al formato, porque el residuo puede ser explicado directamente)

  ...

- 9,000 = Ce xiquipilli huan ome cenzontli huan mahtlahtli cempohualli (1 x 8,000 + 1 x 400 + 10 x 20 - El residuo es 9,000/8,000 es 1,000, y ese número debe ser explicado en la segunda división)

  ...

- 10,000 = Ce xiquipilli huan macuilli cempohualli (1 x 8000 + 5 x 400) (El residuo es 2,000)

  ...

Hay un problema: no existe una palabra (conocida) en Náhuatl para describir 20 x 8,000 = 160,000. Sin embargo, hay formas de explicar ese número, porque cada múltiplo de 20 tiene su propio significado:

a) Cempohualli: Representa al número veinte y significa "Cuenta entera", refiriéndose a que se usan todos los dedos de las manos y de los pies.

b) Cenzontli: Representa al número cuatrocientos, y contiene la palabra tzontli (cabello), por lo que significa "cabello entero", porque pensaban que 400 era el número de cabellos que tenemos en la cabeza, o el número de sonidos que puede emitir el cenzontli o cenzontle, el inconfundible pájaro que Nezahualcóyotl menciona en su poema "Mi hermano el hombre". Este poema solía estar impreso en el billete de 100 pesos mexicanos, por lo que es bien conocido por la mayoría de los mexicanos.

c) Xiquipilli: Representa al número ocho mil, y significa bolsa o saco. Se pensaba que 8,000 es la cantidad de semillas (cacao, frijoles, etc.) que caben en un saco.

Para representar el número 160,000, el maestro de mi maestro de Náhuatl, Genaro Medina Ramos, propuso de manera no oficial usar la palabra **Xochitl**. Significa "flor", y se refiere a la gran cantidad de flores que puedes ver en un prado.

Yo decidí también usar esa palabra en el programa, lo que significa que el número más grande que puede traducir es (160000 * 20) - 1 = 3,199,999.

# ExamenGlobalCitizen
Examen ingreso academia

LUCAS LATTUCA

## Apartado H
## ¿C# permite herencia múltiple?
No, solo permite la herencia única
    
## ¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
Se utiliza una clase Abstracta para cuando se moldea una jerarquia de clases. Se utliza la relacion "es un". Por ejemplo al crear una clase abstracta figura y que las clases Cuadrado, circulo, etc hereden de esta.
    
## ¿Qué implica una relación de Generalización entre dos clases?
Esto implica que todas las instancias que componen una clase son a su vez instancias de otra clase. La clase más generalizada es una superclase de la otra, llamada subclase, y se considera como forma especializada.

## ¿Qué implica una relación de Implementación entre una clase y una interfaz?
Implica llevar a cabo o poner en funcionamiento todos los métodos que existan en dicha interfaz

## ¿Qué diferencia hay entre la relación de Composición y la Agregación?
La agregación indica que una clase forma parte de otra pero ambas pueden convivir sin la otra. En cambio en la composición la vida de la clase contenida debe coincidir con la vida de la clase contenedor. 

## Indique V o F según corresponda. Diferencia entre Asociación y Agregación:

* V --  Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
* F --  Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. 
* F --  Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 

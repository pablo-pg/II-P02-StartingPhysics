# II-P02-StartingPhysics

## Ejercicio 1 - Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una  esfera y un cubo.  

**a. Ninguno de los objetos será físico.**  

Al no haber ningún objeto físico, no afecta ni la gravedad ni nada. Se ejecuta el juego y permanecen volando en el aire.  

**b. La esfera tiene físicas, el cubo no.**  

Se ve cómo el cubo se queda flotando en el aire pero la esfera le afecta la gravedad y baja, Si se activa la opción "Is Trigger", atraviesa el plano del suelo; si no, se detiene sobre él.


**c. La esfera y el cubo tienen físicas.**  

Ambos objetos bajan a la vez gracias a la gravedad y, al igual que antes, se detienen al tocar el plano a no ser de que tengan activada la opción "Is Trigger".

**d. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo.**  

El resultado a la vista es el mismo que en la pregunta anterior. Ambos bajan gracias a la gravedad y se apoyan en el plano. Independientemente de la masa, ambos tocan el plano a la vez.

**e. La esfera tiene físicas y el cubo es de tipo IsTrigger.**  

Aquellas figuras con físicas descienden por la gravedad. El cubo, al ser IsTrigger, atraviesa el plano y cae de forma infinita, mientras que la esfera se queda en el plano.

**f. esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas.**  

Ambas figuras descienden por la gravedad. El cubo, al ser IsTrigger, atraviesa el plano y cae de forma infinita, mientras que la esfera se queda en el plano.

**g. esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ.**  

Ambas bajan por la gravedad y se apoyan en el plano. Pese a que la esfera tenga 10 veces la masa del cubo, ambas figuras caen a la vez. La deshabilitación de la rotación no afecta. 


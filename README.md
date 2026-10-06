# movimiento-Interfaces-Inteligentes

## Ejercicio 5

Se ha creado un script *"moveObject.cs"* asociado a tres GameObjects que permite desplazarlos mediante la barra espaciadora, utilizando una variable pública `displacement` de tipo Vector3 diferente para cada objeto.
El valor de la entrada se obtiene mediante `Input.GetKeyDown(KeyCode.Space)` de forma que cuando se pulse la barra espaciadora cada GameObject se mueva a las posiciones configuradas en dicho vector desplazamiento con `transform.Translate(displacement)`. 

Se observa a continuación como todos los objetos se mueven a la posición seleccionada en su vector desplazamiento una vez se pulsa la barra espaciadora.
Desplazamiento cubo (0, 3, 5) de la esfera (-3, 2, 1) y del cilindro (3, 1, 3):

<img width="1186" height="554" alt="Ej5" src="https://github.com/user-attachments/assets/b7a6fff9-7c20-4cee-b5a1-189ffb575770" />

## Ejercicio 6

Se ha asociado el script *"velocityCube.cs"* al cubo para detectar las teclas de dirección mediante `Input.GetKeyDown(KeyCode.)` y obtener sus valores mediante `Input.GetAxis("Vertical")` e `Input.GetAxis("Horizontal")`.
La velocidad se ha declarado como una variable pública para poder modificarla desde el inspector y se muestra en consola el resultado de multiplicarla por el eje correspondiente a la tecla de dirección pulsada.

Resultado de su ejecución con velocidad = 5:

<img width="1450" height="662" alt="Ej6" src="https://github.com/user-attachments/assets/9d8245d7-3738-42c1-9482-2b1de0fd4c1e" />

## Ejercicio 7

Se ha configurado el Input Manager para asociar la tecla `H` a una nueva acción llamada `Disparo`.
Se ha realizado añadiendo lo siguiente en Edit -> Proyect Settings -> Input Manager -> Axes:

<img width="420" height="241" alt="Ej7" src="https://github.com/user-attachments/assets/ea3504df-6921-420e-ba3d-a85706de6891" />

## Ejercicio 8

Se ha creado un script *"moveCube.cs"* para el cubo mediante una variable `Vector3 moveDirection` y una variable `speed`, ambas configurables desde el inspector (públicas).
El movimiento se realiza mediante `transform.Translate()`, permitiendo comprobar cómo afectan al desplazamiento la dirección, la velocidad, la posición inicial y los sistemas de coordenadas local y mundial.

Resultado de ejecución inicial con `dirección (1, 0, 0)` y `velocidad 2`:
<img width="1184" height="596" alt="Ej8" src="https://github.com/user-attachments/assets/e32cb2aa-bde2-4cbd-b492-fbe9bd1e8675" />

1. **Duplicar las coordenadas de moveDirection:**
Al duplicar las coordenadas, `dirección (2, 0, 0)`, el cubo mantiene la misma dirección, pero aumenta el desplazamiento realizado por lo que el movimiento será el doble de rápido:
<img width="1194" height="588" alt="Ej8-a" src="https://github.com/user-attachments/assets/07faf54a-f318-4925-9e82-2e26006341cc" />
  
2. **Duplicar la velocidad:**
Al duplicar `velocidad 4`, el cubo mantiene la misma dirección, pero se desplaza al doble de velocidad por lo que también se moverá el doble de rápido:
<img width="1192" height="578" alt="Ej8-b" src="https://github.com/user-attachments/assets/5be556d0-aaeb-4d64-ac79-d87ab626d0a7" />

3. **Velocidad menor que 1:**
El cubo continúa moviéndose en la misma dirección, pero realiza un desplazamiento menor en cada intervalo de tiempo,  `velocidad 0.5`, por lo que se moverá más lento:
<img width="1188" height="584" alt="Ej8-c" src="https://github.com/user-attachments/assets/7111630a-9eca-4b40-a8c9-f1ce9c770974" />

4. **Posición del cubo con y > 0:**
El cubo comienza el movimiento desde una posición más elevada, `y = 2`, sin afectar a la dirección indicada por moveDirection:
<img width="1182" height="570" alt="Ej8-d" src="https://github.com/user-attachments/assets/9fe33a74-2807-44ce-97ad-9afdad61916a" />

5. **Movimiento local y mundial:**
Con `Space.Self` el movimiento depende de los ejes locales del cubo, mientras que con `Space.World` depende de los ejes globales de la escena. Se puede ver la diferencia entre ambos rotando ligeramente el cubo (rotation y = 50):
Con movimiento local (Space.Self):
<img width="1178" height="576" alt="Ej8-e1" src="https://github.com/user-attachments/assets/873ea1f0-0387-4ee0-83f0-e60c43bfda38" />

Con movimiento global (Space.World):
<img width="1180" height="590" alt="Ej8-e2" src="https://github.com/user-attachments/assets/321a7d27-3d8e-4d29-b377-5cdfcce9111f" />

## Ejercicio 9

Se ha adaptado el movimiento para controlar el cubo mediante las flechas del teclado y la esfera mediante las teclas `W`, `A`, `S` y `D` utilizando `Input.GetKey(KeyCode.)` para reconocer la tecla. Para ello el cubo tiene asociado *"moveCubeWithKeys.cs"* y la esfera *"moveSphereWithKeys.cs"*.
Además, se mantiene una velocidad configurable mediante la variable `speed`.

A continuación se muestran los resultados de su ejecución:

<img width="1186" height="584" alt="Ej9" src="https://github.com/user-attachments/assets/f3f20429-b67a-4806-a46b-e6df3ea5a914" />

## Ejercicio 10

Se ha adaptado el movimiento del ejercicio anterior para que el desplazamiento sea proporcional al tiempo transcurrido entre frames. Para ello se utiliza `Time.deltaTime`, evitando que la velocidad del movimiento dependa de la cantidad de frames por segundo del ordenador.

## Ejercicio 11

Se ha modificado el movimiento del cubo para que avance hacia la posición de la esfera sin modificar su altura en el script *"moveCubeToSphere.cs"*.
Se calcula el vector que une ambos objetos, se establece su componente `y` a cero y se normaliza mediante `.normalized` para que la velocidad no dependa de la distancia entre ellos convirtiendo el vector en uno de magnitud 1.

En su ejecución se observa como el cubo se mueve hacia la posición de la esfera:

<img width="1188" height="586" alt="Ej11 (1)" src="https://github.com/user-attachments/assets/a8e490f5-a1df-47e4-a4c7-c1b373345163" />


## Ejercicio 12

Se ha adaptado el movimiento del ejercicio anterior para que el cubo gire continuamente hacia la esfera mediante `Transform.LookAt()`, haciendo que su eje Z positivo apunte hacia ella. Se encuentra en el script *"cubeLookAtSphere.cs"*
Además, la esfera se puede desplazar mediante las teclas `W`, `A`, `S` y `D`, permitiendo comprobar cómo el cubo modifica su orientación y movimiento en función de la nueva posición de la esfera pero sin modificar su altura:

<img width="1188" height="588" alt="Ej12" src="https://github.com/user-attachments/assets/fe3b81fa-1786-4f28-8cfe-cbc15cb93739" />

## Ejercicio 13

Se ha utilizado el eje `Horizontal` para controlar la rotación del cubo sobre el eje Y y `transform.forward` para obtener su dirección hacia delante, correspondiente a su eje Z positivo.
De esta forma, el cubo avanza continuamente en la dirección hacia la que está orientado, utilizando `Debug.DrawRay()` para visualizar dicha dirección durante la ejecución:

<img width="1080" height="584" alt="Ej13" src="https://github.com/user-attachments/assets/56eb932f-3a37-4938-9bbc-f8e3942d7a1d" />

*Candela García Cruz*

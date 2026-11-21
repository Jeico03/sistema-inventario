# Sistema de Inventario — Laboratorio 5.10: Producto e Inventario

CodeArt Academy · Fundamentos de Programación con C# · Semana 5 · Día 2 — Constructores y Encapsulamiento

**Estudiante:** Jeico Arias

## Descripción

Aplicación de consola en C# que administra un inventario de productos. Evoluciona la clase `Producto` del Laboratorio 5.6, ahora con constructor, propiedades protegidas y validaciones, y agrega la clase `Inventario` para registrar, buscar y listar productos desde un menú de consola.

## Alcance

**Incluye:** clase `Producto` con constructor y validaciones; clase `Inventario` con colección privada; registro, búsqueda y listado; menú de consola; cálculo del valor por producto; pruebas; UML básico y documentación en GitHub.

**No incluye:** bases de datos, interfaces gráficas, herencia, persistencia ni patrones de diseño avanzados.

## Funcionalidades

- Registrar productos mediante un constructor con código, nombre, precio y cantidad inicial.
- Impedir códigos duplicados y productos nulos.
- Listar todos los productos del inventario.
- Buscar un producto por código.
- Actualizar el precio de un producto (no se aceptan valores negativos).
- Agregar existencias (solo cantidades mayores que cero).
- Consultar el valor total de un producto (`Precio × Cantidad`).

## Reglas de negocio

| ID | Regla |
|---|---|
| RN-01 | Código obligatorio y único dentro del inventario |
| RN-02 | Nombre obligatorio |
| RN-03 | Precio mayor o igual a cero |
| RN-04 | Cantidad inicial mayor o igual a cero |
| RN-05 | Incrementos de existencia estrictamente positivos |
| RN-06 | Valor total del producto = Precio × Cantidad |
| RN-07 | No registrar productos nulos |
| RN-08 | Colección de productos protegida frente a modificación externa directa |

## Cómo ejecutarlo

Requiere el SDK de .NET 8.

```bash
cd SistemaInventario.Consola
dotnet run
```

## Menú de consola

```
===== SISTEMA DE INVENTARIO =====
1. Registrar producto
2. Listar productos
3. Buscar producto por código
4. Actualizar precio
5. Agregar existencias
6. Consultar valor total
0. Salir
```

El menú se repite hasta seleccionar la opción `0`.

## Casos de prueba

| Caso | Escenario | Resultado esperado | Resultado |
|---|---|---|---|
| CP-01 | Registrar producto válido | Producto agregado | Pendiente |
| CP-02 | Registrar código duplicado | Registro rechazado | Pendiente |
| CP-03 | Precio negativo al crear | Valor rechazado | Pendiente |
| CP-04 | Cantidad inicial negativa | Valor rechazado | Pendiente |
| CP-05 | Buscar código existente | Producto mostrado | Pendiente |
| CP-06 | Buscar código inexistente | Informar que no existe | Pendiente |
| CP-07 | Actualizar precio válido | Precio actualizado | Pendiente |
| CP-08 | Actualizar precio negativo | Actualización rechazada | Pendiente |
| CP-09 | Agregar cinco unidades | Existencia aumenta en cinco | Pendiente |
| CP-10 | Agregar cero unidades | Operación rechazada | Pendiente |
| CP-11 | Listar tres productos | Se muestran los tres | Pendiente |
| CP-12 | Precio RD$500; cantidad 4 | Valor total RD$2,000 | Pendiente |

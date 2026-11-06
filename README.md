# Sistema de Inventario — Laboratorio 5.6: Clase Producto

CodeArt Academy · Fundamentos de Programación con C# · Semana 5 · Día 1 — Clases y Objetos

**Estudiante:** Jeico Arias

## Descripción

Aplicación de consola en C# que representa productos de un inventario mediante objetos. La clase `Producto` guarda las características de un artículo, muestra su información y calcula el valor monetario de las unidades disponibles.

## Alcance

**Incluye:** aplicación de consola, clase `Producto`, propiedades automáticas, dos métodos, tres objetos y pruebas básicas.

**No incluye:** bases de datos, interfaces gráficas, herencia, constructores personalizados, validaciones avanzadas ni gestión integral del inventario. El encapsulamiento se estudia en el Día 2.

## Modelo de la clase

```
Producto
+ Codigo: string
+ Nombre: string
+ Precio: decimal
+ Cantidad: int
+ MostrarInformacion(): void
+ CalcularValorTotal(): decimal
```

`CalcularValorTotal()` devuelve `Precio × Cantidad`.

## Estructura

```
SistemaInventario/
├── README.md
└── SistemaInventario.Consola/
    ├── Producto.cs
    ├── Program.cs
    └── SistemaInventario.Consola.csproj
```

## Cómo ejecutarlo

Requiere el SDK de .NET 8.

```bash
cd SistemaInventario.Consola
dotnet run
```

## Datos de prueba

Los datos cumplen las reglas de negocio (precio y cantidad mayores o iguales a cero).

| Código | Nombre | Precio | Cantidad | Valor total |
|---|---|---|---|---|
| P001 | Laptop | RD$100.00 | 5 | RD$500.00 |
| P002 | Mouse | RD$250.00 | 0 | RD$0.00 |
| P003 | Teclado | RD$50.00 | 10 | RD$500.00 |

Al final, el precio del Teclado cambia a RD$75.00 (valor total RD$750.00) y los otros dos productos no se modifican.

## Casos de prueba

| Caso | Escenario | Resultado esperado | Resultado |
|---|---|---|---|
| CP-01 | Crear un objeto `Producto` | Instancia creada correctamente | Cumple |
| CP-02 | Asignar P001 y Laptop | Mostrar ambos valores | Cumple |
| CP-03 | Precio RD$100 y cantidad 5 | Valor total RD$500 | Cumple |
| CP-04 | Precio RD$250 y cantidad 0 | Valor total RD$0 | Cumple |
| CP-05 | Crear tres productos distintos | Cada objeto conserva sus datos | Cumple |
| CP-06 | Ejecutar `MostrarInformacion()` | Mostrar las cuatro propiedades | Cumple |
| CP-07 | Ejecutar `CalcularValorTotal()` | Devolver el cálculo correcto | Cumple |
| CP-08 | Modificar el precio de un producto | No afectar los demás objetos | Cumple |

## Repositorio

<https://github.com/Jeico03/sistema-inventario>
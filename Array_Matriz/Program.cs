using System;
using System.Collections.Generic;

public class Producto
{
    public int Id { get; set; }           // Identificador único
    public string Nombre { get; set; }    // Nombre del producto
    public string Unidad { get; set; }    // Unidad de medida
    public decimal[] Precios { get; set; } // Tres precios del producto

    public Producto(int id, string nombre, string unidad, decimal[] precios)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;

        if (precios.Length != 3)
        {
            throw new ArgumentException("Debe proporcionar exactamente tres precios.");
        }
        Precios = precios;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Nombre: {Nombre}, Unidad: {Unidad}, Precios: [{string.Join(", ", Precios)}]";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Lista para almacenar los productos
        List<Producto> productos = new List<Producto>();

        // Crear y agregar productos
        productos.Add(new Producto(1, "Chocolate", "kg", new decimal[] { 10.5m, 12.0m, 15.0m }));
        productos.Add(new Producto(2, "Leche", "litro", new decimal[] { 1.2m, 1.5m, 2.0m }));

        // Mostrar todos los productos
        Console.WriteLine("Lista de Productos : \n");
        foreach (var producto in productos)
        {
            Console.WriteLine(producto);
        }

        // Buscar un producto por ID
        Console.WriteLine("\nBuscar Producto con ID 1:");
        var productoBuscado = productos.Find(p => p.Id == 1);
        Console.WriteLine(productoBuscado != null ? productoBuscado.ToString() : "Producto no encontrado.");

        // Eliminar un producto por ID
        Console.WriteLine("\nEliminar Producto con ID 1:");
        productos.RemoveAll(p => p.Id == 1);

        // Mostrar productos actualizados
        Console.WriteLine("\nLista actualizada de Productos:");
        foreach (var producto in productos)
        {
            Console.WriteLine(producto);
        }
    }
}
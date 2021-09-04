# MakingSense_2021
Making Sense Academy 2021

## RentaCar
***
Nos contactan para realizar un software que le permita a una agencia de alquiler de autos gestionar los alquileres de los autos. Nuestro cliente, Roberto, nos cuenta que su negocio dispone de un amplio catálogo de autos, de las siguientes marcas: Fiat, Ford, Chevrolet, Peugeot, Renault y Volkswagen. Cada tipo de autos de su inventario se diferencian por el modelo, la cantidad de puertas, el color y si es manual o automático.

Crear una clase con nombre Car, en un archivo Car.cs, que contenga las propiedades de un auto según la problemática anteriormente mencionada.

Realizar un CRUD (Crear, Leer, Actualizar y Borrar) de autos (los siguientes métodos deben ser creados dentro de una clase llamada CarCRUD.cs):
Crear un método con el nombre Create que tenga un parámetro con nombre car del tipo Car. El método debe almacenar, al final de un archivo con nombre Cars.json, los valores del parámetro car en formato json y retornar el auto creado.
```
public Car Create(Car car)
{
   // Code here
}

```
Crear un método con el nombre Get que tenga como parámetro el Id del auto que se desea leer. El método debe buscar en el archivo Cars.json el auto que contenga un Id igual al Id pasado por parámetro y retornarlo.
```
public Car Get(int id) 
{
   // Code here
}

```

Crear un método con el nombre Update que tenga como parámetro el auto que se desea actualizar. El método debe buscar en el archivo Cars.json el auto que contenga un Id igual al Id del auto pasado por parámetro y actualizar todos sus valores con los valores del auto pasado por parámetro y retornarlo.
```
public Car Update(Car car)
{
   // Code here
}

```

Crear un método con el nombre Delete que tenga como parámetro el Id del auto que se desea eliminar. El método debe buscar en el archivo Cars.json el auto que contenga un Id igual al Id pasado por parámetro y eliminarlo del archivo.
```
public void Delete(int id)
{
   // Code here
}

```

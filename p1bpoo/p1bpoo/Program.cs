
using System;
using p1bpoo.Interfaces;
using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());





Chofer piloto1 = new Chofer("Alejandra", 42, "A");
Chofer piloto2 = new Chofer("Juan", 30, "B");
Chofer piloto3 = new Chofer("Pedro", 61, "C");
Chofer piloto4 = new Chofer("Maria", 30, "M\n");


Console.WriteLine("-PILOTO1");
piloto1.MostrarInformacion();
Console.WriteLine("-PILOTO2");
piloto2.MostrarInformacion();
Console.WriteLine("-PILOTO3");
piloto3.MostrarInformacion();
Console.WriteLine("-PILOTO4");
piloto4.MostrarInformacion();


//Asigancion de Pilotos 
//Vehiculo sedan = new Vehiculo(2026, "Blanco", "Sedan");
//Console.WriteLine(sedan.Encender());
//Console.WriteLine(sedan.AsignarPiloto(piloto4)); 
//sedan.acelerar(10);

//string respuesta = sedan.AsignarPiloto(piloto1);
//Console.WriteLine(respuesta);

Console.WriteLine("******************************");


Console.WriteLine("-Asignacion de pilotos a vehiculos (Moto)");
Moto mimoto = new Moto (2025, "Negro", "BMW");
Console.WriteLine(mimoto.AsignarPiloto(piloto4));
Console.WriteLine("Piloto para Automovil asignado exitosamente");
mimoto.InformacionVehiculo();

Console.WriteLine(mimoto.AsignarPiloto(piloto4));
piloto4.MostrarInformacion();
piloto4.MostrarValidacion();

mimoto.Encender();
mimoto.acelerar(90);
mimoto.HacerCaballito();
mimoto.Frenar(35);
mimoto.acelerar(109);
mimoto.Frenar(30);
mimoto.Frenar(26);
mimoto.HacerCaballito();
mimoto.Apagar();



Console.WriteLine("******************************");

Console.WriteLine("-Asignacion de pilotos a vehiculos (TRAILER)");
Trailer mitrailer = new Trailer (2026, "Negro", "Honda");
Console.WriteLine(mitrailer.AsignarPiloto(piloto1));
Console.WriteLine("Piloto para trailer asignado exitosamente");
mitrailer.VerChasis();
Console.WriteLine(mitrailer.AsignarPiloto(piloto1));
piloto1.MostrarInformacion();
piloto1.MostrarValidacion();

mitrailer.Encender();
mitrailer.acelerar(80);
mitrailer.Frenar(40);
mitrailer.acelerar(120);
mitrailer.Frenar(60);
mitrailer.Apagar();

Console.WriteLine("******************************");

Console.WriteLine("-Asignacion de pilotos a vehiculos (AUTOMOVIL)");
Automovil miAuto = new Automovil(2025, "Negro", "Toyota");
Console.WriteLine(miAuto.AsignarPiloto(piloto4));
Console.WriteLine("Piloto para Automovil asignado exitosamente");
miAuto.NivelGasolina();
piloto4.MostrarInformacion();
piloto4.MostrarValidacion();
Console.WriteLine(" ");
Console.WriteLine(miAuto.AsignarPiloto(piloto2));
piloto2.MostrarInformacion();
piloto2.MostrarValidacion();

miAuto.Encender();
miAuto.acelerar(110);
miAuto.Frenar(42);
miAuto.acelerar(190);
miAuto.Frenar(78);
miAuto.Apagar();

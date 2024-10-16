// See https://aka.ms/new-console-template for more information
using EjercicioClase;

SuperHeroe hero = new SuperHeroe();
hero.Nombre = "Superman";
hero.IdentidadSecreta = "Clark Kent";
hero.Ciudad = "Metropolis";
hero.PuedeVolar = true;
hero.poder.Nombre = "Super Fuerza";
hero.poder.Descripcion = "Capacidad de levantar objetos muy pesados";
hero.poder.Nivel = 9;

SuperHeroe hero1 = new SuperHeroe();
hero1.Nombre = "Batman";
hero1.IdentidadSecreta = "Bruce Wayne";
hero1.Ciudad = "Ciudad Gotica";
hero1.PuedeVolar = false;
hero1.poder.Nombre = "Intelecto";
hero1.poder.Descripcion = "Es millonario";
hero1.poder.Nivel = 5;

SuperHeroe hero2 = new SuperHeroe();
hero2.Nombre = "Spiderman";
hero2.IdentidadSecreta = "Peter Parker";
hero2.Ciudad = "Queens";
hero2.PuedeVolar = false;
hero2.poder.Nombre = "Poderes aracnidos";
hero2.poder.Descripcion = "Poderes relacionados con las habilidades aracnidas";
hero2.poder.Nivel = 8;

hero.imprimir();
hero1.imprimir();
hero2.imprimir();
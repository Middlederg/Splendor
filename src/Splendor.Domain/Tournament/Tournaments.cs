using System;
using System.Collections.Generic;

namespace Splendor.Domain
{
    public static class Tournaments
    {

        public static List<Tournament> obtenerListaTorneos(bool esTemp)
        {
            List<Tournament> l = new List<Tournament>();

            //Division 4
            l.Add(new Tournament(1, "Liga amateur de " + Constantes.OpcionesGenerales.LugarOrigen.Municipio, "", Constantes.OpcionesGenerales.LugarOrigen, 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 01, 10), 3, 4, 16, new int[] { 50, 20 }, esTemp));
            l.Add(new Tournament(2, "Liga Rúnica", "", "Rentería", 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 03, 24), 3, 3, 15, new int[] { -3, -4, -5 }, esTemp));
            l.Add(new Tournament(3, "Liga Aficionados al Splendor", "", Datos.obtenerLocalidad("Santoña"), 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 04, 08), 3, 4, 12, new int[] { -4, -12 }, esTemp));
            l.Add(new Tournament(4, "Liga Enfrentados", "", Datos.obtenerLocalidad("Haro"), 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 03, 24), 5, 2, 20, new int[] { 45, 30 }, esTemp));
            l.Add(new Tournament(5, "Umbras Paradox", "", Datos.obtenerLocalidad("Huarte"), 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 08, 13), 3, 3, 12, new int[] { -4 }, esTemp));
            l.Add(new Tournament(6, "Jornadas Acnil Burgos", "", Datos.obtenerLocalidad("Burgos"), 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 07, 10), 2, 4, 12, new int[] { -8 }, esTemp));
            l.Add(new Tournament(7, "Queremos jugar", " ", Datos.obtenerLocalidad("Dos Hermanas"), 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 03, 06), 3, 4, 16, new int[] { -4, -16 }, esTemp));
            l.Add(new Tournament(8, "Jornadas Omicrón", " ", Datos.obtenerLocalidad("Orduña"), 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 08, 28), 4, 4, 20, new int[] { -9 }, esTemp));

            //Division 3
            l.Add(new Tournament(1, "Liga semiprofesional de " + Constantes.OpcionesGenerales.LugarOrigen.Provincia, "", Constantes.OpcionesGenerales.LugarOrigen, 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 01, 10), 4, 4, 32, new int[] { 50, 20 }, esTemp));
            l.Add(new Tournament(2, "Campeonato local de " + Constantes.OpcionesGenerales.LugarOrigen.Provincia, "", Constantes.OpcionesGenerales.LugarOrigen, 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 02, 16), 5, 3, 30, new int[] { 50, 20 }, esTemp));
            l.Add(new Tournament(3, "Liga Noble", "", Datos.obtenerLocalidad("Valladolid"), 4, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 03, 24), 3, 4, 16, new int[] { 45, -4, -5 }, esTemp));
            l.Add(new Tournament(4, "Liga Aficionados al Splendor", "", Datos.obtenerLocalidad("Santoña"), 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 04, 08), 3, 4, 12, new int[] { -4, -12 }, esTemp));
            l.Add(new Tournament(5, "Campeonato Zacatrús", "", Datos.obtenerLocalidad("Madrid"), 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 09, 25), 4, 4, 16, new int[] { 120, 80, 20 }, esTemp));
            l.Add(new Tournament(6, "Torneo Mensa", "Torneo Mensa de juegos inteligentes", Datos.obtenerLocalidad("Lleida"), 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 05, 22), 4, 3, 24, new int[] { 70, -6, -16 }, esTemp));
            l.Add(new Tournament(7, "Liga Evolución", " ", Datos.obtenerLocalidad("Guadalajara"), 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 02, 11), 7, 3, 60, new int[] { 160, 50, 35 }, esTemp));
            l.Add(new Tournament(8, "Torneo Tarta o Muerte", "", Datos.obtenerLocalidad("Mérida"), 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 11, 29), 8, 2, 60, new int[] { 350, 190 }, esTemp));
            l.Add(new Tournament(9, "Liga Joker", "", Datos.obtenerLocalidad("Bilbao"), 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 06, 05), 3, 4, 16, new int[] { -6, -24, -15, -62, -3, -17 }, esTemp));
            l.Add(new Tournament(10, "Premio itinerante ", "", Datos.localidadAleatoriaESP(), 3, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 06, 22), 5, 4, 28, new int[] { 190, 45 }, esTemp));

            //Division 2
            l.Add(new Tournament(1, "Campeonato Nacional", "", Datos.obtenerLocalidad("Zaragoza"), 2, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 06, 10), 6, 3, 66, new int[] { 1450, 740, 360 }, esTemp));
            l.Add(new Tournament(2, "Extreme Cup", "", Datos.obtenerLocalidad("Amorebieta"), 2, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 05, 15), 10, 4, 80, new int[] { 550, 300, 120 }, esTemp));
            l.Add(new Tournament(3, "Liga Devir", " ", Datos.obtenerLocalidad("Madrid"), 2, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 08, 28), 6, 4, 60, new int[] { 420, 320, 220 }, esTemp));
            l.Add(new Tournament(4, "Liga Esplèndid", "", Datos.obtenerLocalidad("Barcelona"), 2, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 11, 5), 7, 2, 50, new int[] { 670, 210 }, esTemp));
            l.Add(new Tournament(5, "Copa HomoLúdicus", "", Datos.obtenerLocalidad("Madrid"), 2, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 03, 15), 5, 3, 36, new int[] { 230, 100, 50 }, esTemp));
            l.Add(new Tournament(6, "Liga Magnífica", "", Datos.obtenerLocalidad("Sevilla"), 2, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 09, 02), 12, 2, 120, new int[] { 800, 400, 100 }, esTemp));
            l.Add(new Tournament(7, "Festival Nacional de juegos de mesa", "", Datos.obtenerLocalidad("Córdoba"), 2, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 10, 08), 7, 4, 48, new int[] { 700, 200, 145 }, esTemp));
            l.Add(new Tournament(8, "Liga andaluza itinerante", "", Datos.obtenerLocalidad("Granada"), 2, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 06, 10), 7, 4, 52, new int[] { 790, 240, 120 }, esTemp));

            //Division 1
            l.Add(new Tournament(1, "Boardgame Olimpiade", " ", Datos.obtenerLocalidad("Essen"), 1, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 10, 22), 14, 4, 320, new int[] { 8500, 3200, 1250, 290, 290, 150, 150, 150, 150, 150 }, esTemp));
            l.Add(new Tournament(2, "Torneo Eterno Mundial", "", Datos.obtenerLocalidad("Moscú"), 1, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 05, 29), 24, 2, 180, new int[] { 9120, 2310 }, esTemp));
            l.Add(new Tournament(3, "Triliga de campeones", "", Datos.obtenerLocalidad("Viena"), 1, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 07, 19), 13, 3, 240, new int[] { 7550, 3220, 2140 }, esTemp));
            l.Add(new Tournament(4, "Gran premio europeo", "", Datos.obtenerLocalidad("París"), 1, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 02, 11), 10, 4, 80, new int[] { 6500, 1220, 1000 }, esTemp));
            l.Add(new Tournament(5, "Copa británica", "", Datos.obtenerLocalidad("Londres"), 1, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 12, 12), 9, 4, 60, new int[] { 7850, 2500, 1500 }, esTemp));

            l.Add(new Tournament(6, "Prueba", "", Datos.obtenerLocalidad("Londres"), 1, new DateTime(Constantes.OpcionesGenerales.FechaInicioJuego.Year, 12, 12), 2, 4, 384, new int[] { 7850, 2500, 1500 }, esTemp));

            return l;
        }
    }


}

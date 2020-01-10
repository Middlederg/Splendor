using Splendor.Domain;
using System;
using System.Collections.Generic;

public class Season
{
    public Division Division { get; set; }
    public DateTime Fecha { get; set; }
    public List<Tournament> Torneos { get; set; }
    public List<Person> Personas { get; set; }
    public List<Sponsor> Sponsors { get; set; }
    public List<Gift> Tienda { get; set; }

    public Season()
    {
        Division = Division.Aficionados;

    }

  
}
using System.Collections.Generic;
using System.Data.Entity;
using MundoMascotaRosario.Common;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.DAL
{
    public class MMRInitializer : DropCreateDatabaseIfModelChanges<MMRContext>
    {
        protected override void Seed(MMRContext context)
        {

            var provincias = new List<Provincia>
            {
                new Provincia {Descripcion = "Buenos Aires"},
                new Provincia {Descripcion = "Catamarca"},
                new Provincia {Descripcion = "Chaco"},
                new Provincia {Descripcion = "Chubut"},
                new Provincia {Descripcion = "Ciudad de Buenos Aires"},
                new Provincia {Descripcion = "Corrientes"},
                new Provincia {Descripcion = "Córdoba"},
                new Provincia {Descripcion = "Entre Ríos"},
                new Provincia {Descripcion = "Formosa"},
                new Provincia {Descripcion = "Jujuy"},
                new Provincia {Descripcion = "La Pampa"},
                new Provincia {Descripcion = "La Rioja"},
                new Provincia {Descripcion = "Mendoza"},
                new Provincia {Descripcion = "Misiones"},
                new Provincia {Descripcion = "Neuquén"},
                new Provincia {Descripcion = "Río Negro"},
                new Provincia {Descripcion = "Salta"},
                new Provincia {Descripcion = "San Juan"},
                new Provincia {Descripcion = "San Luis"},
                new Provincia {Descripcion = "Santa Cruz"},
                new Provincia {Descripcion = "Santa Fe"},
                new Provincia {Descripcion = "Santiago del Estero"},
                new Provincia {Descripcion = "Tierra del Fuego, Antártida e Islas del Atlántico Sur"},
                new Provincia {Descripcion = "Tucumán"}
            };
            provincias.ForEach(p => context.Provincias.Add(p));

            var provinciaId = provincias[0].ProvinciaId;
            var ciudades = new List<Ciudad>
            {
                new Ciudad {Descripcion = "Acassuso", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Adrogué", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Aguas Verdes", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Aldo Bonzi", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "América ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Arrecifes", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Avellaneda ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ayacucho", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Azcuénaga", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Azul ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Bahía Blanca", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Balcarce", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Balneario Sauce Grande", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Banderaló", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Banfield", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Baradero", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Batán", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Béccar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Bella Vista", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Belén de Escobar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Benavídez", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Benito Juárez", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Berisso ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Bolívar Province", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Bosques ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Boulogne Sur Mer (San Isidro)", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Bragado", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Brandsen", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Camet", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Campana Province", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Capilla del Señor", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Cariló", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Carlos Casares", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Carlos Keen", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Carmen de Areco", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Carmen de Patagones", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Caseros", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Castelli", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Cañuelas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Chacabuco", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Chapadmalal", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Chascomús", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Chillar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Chivilcoy", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ciudad Evita", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ciudad Jardín Lomas del Palomar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ciudad Madero", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ciudadela", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Claromecó", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Colonia Hinojo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Colón ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Coronel Charlone", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Coronel Pringles", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Coronel Suárez", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Costa Azul", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Costa del Este", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Curarú", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Daireaux", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "De la Garma", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Dolores Province", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Domselaar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Don Bosco ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Don Torcuato", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "El Palomar ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ensenada ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ezeiza", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Florencio Varela ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Florida ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Florida Oeste ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Fortín Olavarría", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Fátima ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Garin", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Belgrano", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Daniel Cerri", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Guido", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Madariaga", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Pacheco", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Pinto", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Pirán", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Villegas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Glew", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Grand Bourg ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Gregorio de Laferrere", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Guaminí", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Haedo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Hinojo ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Hurlingham", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Indio Rico", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ingeniero Budge", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ingeniero Maschwitz", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ingeniero Pablo Nogués", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ingeniero White", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Isidro Casanova", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ituzaingó ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "José C. Paz", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "José Ingenieros", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "José León Suárez", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "José María Jáuregui", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "José Mármol", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Junín", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Justo Villegas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "La Plata", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "La Tablada", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Lanús", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Laprida ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Las Armas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Las Flores", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Lezama ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Lima", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Lincoln", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Lobos", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Loma Negra", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Lomas de Zamora", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Los Polvorines", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Los Toldos", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Lucila del Mar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Luis Guillón", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Luján", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Magdalena ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Mar de Ajó", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Mar del Plata", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Mar del Sur", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Mar del Tuyú", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Marcos Paz", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Martínez ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Mayor Buratovich", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Mercedes ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Merlo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Miramar Province", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Monte Grande", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Monte Hermoso", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Moquehuá", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Moreno ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Morón", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Munro ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Máximo Paz", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Médanos", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Navarro", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Necochea", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Obligado ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Olavarría", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Olivos", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Paso del Rey", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pehuajó", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pehuen Co", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pellegrini", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pergamino", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pigüé", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pila", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pilar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pinamar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Piñeyro", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Puan", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Punta Alta", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Punta Mogotes", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Quequén", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Quilmes", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Rafael Castillo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ramallo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Ramos Mejía", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Rauch", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Rawson ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Remedios de Escalada", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Roosevelt", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Saldungaray", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Salliqueló", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Salto ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Antonio de Areco", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Antonio de Padua", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Bernardo del Tuyú", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Clemente del Tuyú", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Fernando ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Isidro ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San José (Suárez)", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Justo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Miguel del Monte", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Miguel", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Nicolás de los Arroyos", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Pedro ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Vicente", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Santa Clara del Mar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Santa Teresita", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Sarandí", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Sevigné", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Sierra Chica ", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Sierra de la Ventana", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Sierra de los Padres", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Sierras Bayas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Tandil", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Tapiales", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Temperley", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Tigre", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Timote", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Tornquist", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Tortuguitas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Trenque Lauquen", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Tres Arroyos", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Tristán Suárez", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Turdera", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Uribelarrea", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Martelli", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Valeria del Mar", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Veinte de Junio", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Verónica", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Vicente López", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Victoria", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Adelina", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Ballester", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Domínico", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Epecuén", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Gesell", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Luzuriaga", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Maza", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Rosa", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Sarmiento", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Villa Ventana", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Wilde", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Zelaya", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Zárate", ProvinciaId = provinciaId}
            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            provinciaId = provincias[1].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad {Descripcion = "Andalgalá", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Antofagasta de la Sierra", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Belén", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "El Rodeo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Londres", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Recreo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "San Fernando del Valle de Catamarca", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Santa María", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Saujil", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Tinogasta", ProvinciaId = provinciaId},
            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            provinciaId = provincias[2].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad {Descripcion = "Barranqueras", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Barrio San Pedro Pescador", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Basail", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Charata", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Colonia Benítez", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Colonia Popular", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Concepción del Bermejo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Corzuela", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Fontana", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General José de San Martín", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "General Pinedo", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Isla del Cerrito", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Juan José Castelli", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "La Eduvigis", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "La Sabana", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Laguna Blanca", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Lapachito", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Las Breñas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Las Palmas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Machagai", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Makallé", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Margarita Belén", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Napalpí", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Pampa Almirón", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Presidencia de la Plaza", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Presidencia Roque Sáenz Peña", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Puerto Antequeras", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Puerto Eva Perón", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Puerto Lavalle", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Puerto Tirol", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Puerto Vilelas", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Quitilipi", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Resistencia", ProvinciaId = provinciaId},
                new Ciudad {Descripcion = "Taco Pozo", ProvinciaId = provinciaId}
            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Chubut

            provinciaId = provincias[3].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Camarones",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cañadón Lagarto",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cañadón Perdido",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cerro Dragon",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cholila",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Telsen",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Comodoro Rivadavia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Dolavon",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Hoyo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Maitén",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Trébol",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Esquel",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gaiman",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Garayalde",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gastre",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Greater Comodoro Rivadavia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Holdich",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "José de San Martín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Hoya",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Los Altares",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pampa del Castillo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pampa Salamanca",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Paso del Sapo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Playa Magagna",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Madryn",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Pirámides",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rada Tilly",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rawson",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Río Pico",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Sarmiento",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Trelew",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Trevelin",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Uzcudun",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Valle Hermoso",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Veintiocho de Julio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Dique Ameghino",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Lago Rivadavia",  ProvinciaId = provinciaId }
            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudad De Bs As
            provinciaId = provincias[4].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Ciudad de Buenos Aires",  ProvinciaId = provinciaId }
            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Corrientes

            provinciaId = provincias[5].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Alvear",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bella Vista",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Caá Catí",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Carlos Pellegrini",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Concepción",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Corrientes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Curuzú Cuatiá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Empedrado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Esquina",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gobernador Juan E. Martínez",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gobernador Virasoro",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Goya",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Itatí",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ituzaingó",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Itá Ibaté",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Cruz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Mercedes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Monte Caseros",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Nueve de Julio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Parada Pucheta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Paso de la Patria",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Paso de los Libres",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ramada Paso",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Luis del Palmar",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa Lucía",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santo Tomé",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Sauce",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Olivari",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Yapeyú",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Córdoba

            provinciaId = provincias[6].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Alta Gracia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ascochinga",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bell Ville",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bengolea",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Berrotarán",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bialet Massé",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Calchín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Calchín Oeste",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Capilla del Monte",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cavanagh",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cerro Colorado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Chancaní",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Videla",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Corral de Bustos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cosquín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cruz del Eje",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Córdoba",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Cadillo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Durazno",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Fortín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Embalse",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Estación Juárez Celman",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Etruria",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Materfer",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Freyre",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Cabrera",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Deheza",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Icho Cruz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Impira",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Jesús María",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Jovita",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Calera",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Carlota",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Cumbre",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Falda",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Granja",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Paz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Laboulaye",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Laguna Larga",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Palmas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Rabonas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Varillas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Vertientes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Leones",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Los Cocos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Luyaba",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Mi Granja",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Mina Clavero",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Miramar",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Nono",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pampayasta Sud",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Panaholma",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pilar",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Porteña",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Río Ceballos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Río Cuarto",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Río Tercero",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Salsipuedes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Carlos Minas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Francisco",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Javier",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Marcos Sierras",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa Rosa de Calamuchita",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Segunda Usina",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tanti",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tío Pujio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ucacha",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Unquillo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Valle Hermoso",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Ascasubi",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Candelaria Norte",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Carlos Paz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Cura Brochero",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa del Dique",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa del Rosario",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Dolores",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa General Belgrano",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Giardino",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Huidobro",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa María",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Entre Ríos

            provinciaId = provincias[7].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Basavilbaso",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ceibas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colón",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Hocker",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Concepción del Uruguay",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Concordia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Crespo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Estancia Grande",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Federación",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Feliciano",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Galarza",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gualeguay",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gualeguaychú",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Maciá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "María Grande",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Nogoyá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Paraná",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Primero de Mayo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pueblo Cazes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pueblo Liebig",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Benito",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Salvador",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Seguí",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Urdinarrain",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Viale",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Victoria",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Alcaraz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Dominguez",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Urquiza",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Formosa

            provinciaId = provincias[8].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Clorinda",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Colorado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Formosa",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Fortín Sargento Primero Leyes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Lucio V. Mansilla",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ingeniero Juárez",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pirané",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Siete Palmas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa del Carmen",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Jujuy

            provinciaId = provincias[9].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Abdón Castro Tolay",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Carmen",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Humahuaca",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Iturbe",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Quiaca",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Libertador General San Martín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Maimará",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Palpalá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Perico",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Purmamarca",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Pedro de Jujuy",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Salvador de Jujuy",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tilcara",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tumbaya",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Volcán",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Yavi",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de La Pampa

            provinciaId = provincias[10].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "25 de Mayo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Anguil",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bernasconi",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Catriló",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Barón",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Doblas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Eduardo Castex",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Pico",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Guatraché",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Hucal",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Intendente Alvear",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Lihuel Calel",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Lonquimay",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Miguel Cané",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Quemú Quemú",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rancul",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa Rosa",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Telén",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Trenel",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Victorica",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Winifreda",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de La Rioja

            provinciaId = provincias[11].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Chamical",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Chilecito",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Cadillo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Famatina",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Gredita",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Puntilla",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Rioja",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Los Sarmientos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Malligasta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Olta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pinchas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santo Domingo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Sanagasta",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Mendoza

            provinciaId = provincias[12].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Agua Escondida",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bowen",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Carrodilla",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Coquimbito",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Alvear",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Gutiérrez",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Godoy Cruz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Guaymallén",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Paz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Heras",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Leñas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Maipú",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Malargüe",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Mendoza",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Paramillos de Uspallata",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Potrerillos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Real del Padre",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rodeo del Medio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Martín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Rafael",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tunuyán",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Misiones

            provinciaId = provincias[13].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "25 de Mayo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "9 de Julio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Alba Posse",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Almafuerte",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Apóstoles",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Aristóbulo del Valle",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Arroyo del Medio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Azara",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bernardo de Irigoyen",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bonpland",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Campo Grande",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Campo Ramón",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Campo Viera",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Candelaria",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Capioví",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Caraguatay",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Caá Yarí",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cerro Azul",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cerro Corá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Alberdi",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Aurora",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Delicia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Polana",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Victoria",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Comandante Andresito",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Concepción de la Sierra",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Corpus",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Dos Arroyos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Dos de Mayo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Alcázar",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Soberbio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Eldorado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Fachinal",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Florentino Ameghino",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Garuhapé",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Garupá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Alvear",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Urquiza",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gobernador López",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gobernador Roca",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Guaraní",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Hipólito Yrigoyen",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Itacaruaré",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Jardín América",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Leandro N. Alem",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Loreto",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Los Helechos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Mojón Grande",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Montecarlo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Oberá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Olegario Víctor Andrade",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Panambí",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Posadas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Esperanza",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Iguazú",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Leoni",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Libertad",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Mineral",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Piray",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Rico",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ruiz de Montoya",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Antonio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Ignacio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Javier",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San José",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Martín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Pedro",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Vicente",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa Ana",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa María",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santiago de Liniers",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santo Pipó",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tobuna",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tres Capones",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Wanda",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Neuquén

            provinciaId = provincias[14].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Aluminé",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Añelo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Caviahue",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Chos Malal",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cutral Co",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Cholar",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Huecú",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Junín de los Andes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Coloradas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Lajas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Los Miches",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Neuquén",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Piedra del Águila",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Plottier",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Quila Quina",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ramón M. Castro",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Martín de los Andes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa El Chocón",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa La Angostura",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Pehuenia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Traful",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Zapala",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Rio Negro

            provinciaId = provincias[15].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Allen",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Barda del Medio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Catriel",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Chimpay",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Choele Choel",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cipolletti",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Clemente Onelli",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Suiza",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Bolsón",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "General Roca",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ingeniero Huergo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ingeniero Jacobacci",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Grutas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pilcaniyeu",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pomona",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rio Colorado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Antonio Oeste",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Carlos de Bariloche",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Valcheta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Viedma",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Regina",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Salta

            provinciaId = provincias[16].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Angastaco",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Antilla",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cachi",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cafayate",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Campo Carreras",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Campo Durán",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Campo Quijano",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Campo Tapial",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Carril",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Iruya",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Joaquín V. González",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Caldera",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Viña",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Molinos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pichanal",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pueblo Viejo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rosario de la Frontera",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rosario de Lerma",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Salta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Antonio de los Cobres",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Carlos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San José de Metán",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Ramón de la Nueva Orán",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa Victoria Oeste",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Seclantás",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tartagal",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tastil",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tolar Grande",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa San Lorenzo",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de San Juan

            provinciaId = provincias[17].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Aberastain",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Caucete",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Chimbas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Desamparados",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Iglesia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Rinconada",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Chacritas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Marayes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Media Agua",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Nueve de Julio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rawson",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rivadavia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rodeo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San José de Jáchal",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Juan",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa Lucía",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tudcum",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Aberastain",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa del Salvador",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa General San Martín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa San Agustín",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Sefair Talacasto",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de San Luis

            provinciaId = provincias[18].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Candelaria",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Cadillo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Volcán",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Fraga",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Punta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Toma",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Merlo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Papagayos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Potrero de los Funes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Quines, San Luis",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Luis",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Larca",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Mercedes",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Santa Cruz

            provinciaId = provincias[19].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Caleta Olivia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Comandante Luis Piedrabuena",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Calafate",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Heras",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Los Antiguos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Perito Moreno",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pico Truncado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Deseado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto San Julian",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Puerto Santa Cruz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rio Gallegos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Río Turbio",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Santa Fe

            provinciaId = provincias[20].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Alejandra",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Arequito",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Arroyo Leyes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Arroyo Seco",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ataliva",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Bouquet",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Calchaquí",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Capitán Bermúdez",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Carcarañá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Carlos Pellegrini",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Carmen del Sauce",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Casilda",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Cañada de Gómez",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Centeno",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ceres",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Chañar Ladeado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Clarke",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colonia Belgrano",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Díaz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Empalme Villa Constitución",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Esperanza",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Estación Clucellas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Firmat",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Funes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Gobernador Crespo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Granadero Baigorria",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Juan Bernabé Molina",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Laguna Paiva",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Landeta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Las Parejas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Logroño",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Maggiolo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Malabrigo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Marcelino Escalada",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "María Juana",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Melincué",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Moisés Ville",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Morante",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Nelson",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rafaela",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Reconquista",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rosario",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Carlos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Cristóbal",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Gregorio",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Javier",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San José de la Esquina",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Justo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Lorenzo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Vicente",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa Fe de la Vera Cruz",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santa Rosa de Calchines",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santo Tomé",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Sastre",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Serodino",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Suardi",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Sunchales",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Susana",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tostado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Totoras",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Venado Tuerto",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Vera",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Minetti",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Mugueta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villada",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Zavalla",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Santiago del Estero

            provinciaId = provincias[21].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Añatuya",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Campo Gallo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Frías",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Banda",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Monte Quemado",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Santiago del Estero",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Suncho Corral",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tacañitas",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Termas de Rio Hondo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tintina",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa La Punta",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Weisburd",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));

            //Ciudades de Tierra Del Fuego, Antártida e Islas del Antlántico Sur
            provinciaId = provincias[22].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Río Grande",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tolhuin",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ushuaia",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));


            //Ciudades de Tucumán
            provinciaId = provincias[23].ProvinciaId;
            ciudades = new List<Ciudad>
            {
                new Ciudad { Descripcion =  "Aguilares",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Alderetes",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Amaicha del Valle",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Colombres",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Concepción",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Delfín Gallo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Bracho",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Chañar",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Manantial",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "El Mollar",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Famaillá",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Ingenio San Pablo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Banda del Río Salí",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Cocha",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "La Florida",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Lastenia",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Los Ralos",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Lules",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Manuel García Fernández",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Monteros",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Pacará",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Rumi Punco",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Andres",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Javier",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Miguel de Tucumán",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "San Pedro de Colalao",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Simoca",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tafí del Valle",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Tafí Viejo",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Villa Nougués",  ProvinciaId = provinciaId },
                new Ciudad { Descripcion =  "Yerba Buena",  ProvinciaId = provinciaId }

            };
            ciudades.ForEach(c => context.Ciudades.Add(c));


            var tarjetas = new List<Tarjeta>
            {
                new Tarjeta
                {
                    TipoDeTarjeta = TipoTarjeta.Cabal,
                    NumeroTarjeta = "1616161616161616",
                    AnoExpiracion = AnoExpiracion.AnoProx1,
                    MesExpiracion = MesExpiracion.Enero,
                    CodigoSeguridad = Hash.CreateHash("123"),
                    Estado = EstadoTarjeta.Habilitada,
                    DniTitular = "34991412",
                    NombreTitular = "JUAN PETTINARI"
                },
                new Tarjeta
                {
                    TipoDeTarjeta = TipoTarjeta.Mastercard,
                    NumeroTarjeta = "1234567890123456",
                    MesExpiracion = MesExpiracion.Diciembre,
                    AnoExpiracion = AnoExpiracion.AnoProx5,
                    CodigoSeguridad = Hash.CreateHash("321"),
                    Estado = EstadoTarjeta.Rechazada,
                    DniTitular = "0303456",
                    NombreTitular = "IGNACIO BECERRA"
                }
            };
            tarjetas.ForEach(t => context.Tarjetas.Add(t));


            var productos = new List<Producto>
            {
                new Producto
                {
                    Animal = "Perro",
                    Descripcion = "Alimento Premium 15kg",
                    Marca = "Protemix",
                    PrecioDecimal = 368,
                    Imagen = "~/Content/Img/Productos/protemix_pasgma.jpg",
                    Stock = 4
                },
                new Producto
                {
                    Animal = "Perro",
                    Descripcion = "Correa Extensible 2m Hasta 35kg",
                    Marca = "Flexi City",
                    PrecioDecimal = 623,
                    Stock = 2,
                    Imagen = "~/Content/Img/Productos/Correa_1.jpg"
                },
                new Producto
                {
                    Animal = "Perro",
                    Descripcion = "Correa Extensible 5m hasta 50kg",
                    Marca = "Flexi Classic",
                    PrecioDecimal = 850,
                    Stock = 0,
                    Imagen = "~/Content/Img/Productos/Correa_2.jpg"
                },
                new Producto
                {
                    Animal = "Perro",
                    Descripcion = "Arnes Premium Acolchado Negro",
                    Marca = "Trixie",
                    Imagen = "~/Content/Img/Productos/Trixie_Arnes.jpg",
                    PrecioDecimal = 360,
                    Stock = 0

                },
                new Producto
                {
                    Animal = "Perro",
                    Descripcion = "Alimento Premium Adulto 1.5Kg",
                    Marca = "VitalCan",
                    Imagen = "~/Content/Img/Productos/vitalcan_premium.jpg",
                    PrecioDecimal = 80,
                    Stock = 6
                },
                new Producto
                {
                    Animal = "Perro",
                    Descripcion = "Alimento Balanced Adulto Large Breed 3kg",
                    Marca = "VitalCan",
                    PrecioDecimal = 180,
                    Imagen = "~/Content/Img/Productos/vitalcan_balanced.jpg",
                    Stock = 1
                },
                new Producto
                {
                    Animal = "Perro",
                    Descripcion = "Adulto Large Breed 3kg",
                    PrecioDecimal = 259,
                    Marca = "Eukanuba",
                    Stock = 4,
                    Imagen = "~/Content/Img/Productos/Eukanuba_Adulto.png",
                },
                new Producto
                {
                    Animal = "Perro",
                    Marca = "Pedigree",
                    Descripcion = "Alimento Adulto Carne, Pollo y Cereales 2,7kg",
                    PrecioDecimal = 94,
                    Stock = 2,
                    Imagen = "~/Content/Img/Productos/pedigree_adulto.jpg"
                },
                new Producto
                {
                    Animal = "Perro",
                    Descripcion = "Alimento Perro Provet Alta Performance 20 kg",
                    Marca = "Provet",
                    Stock = 3,
                    PrecioDecimal = 665,
                    Imagen = "~/Content/Img/Productos/Provet_Alta_Performance.jpg"
                },
                new Producto
                {
                    Animal = "Gato",
                    Descripcion = "Bocadito Gato GoloMiau Sabor Atun",
                    Marca = "GoloMiau",
                    Stock = 3,
                    PrecioDecimal = 40,
                    Imagen = "~/Content/Img/Productos/golomiau.png"
                },
            };
            productos.ForEach(p => context.Productos.Add(p));

            context.SaveChanges();
        }
    }
}
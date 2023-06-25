using ApiAuto.Data;
using ApiAuto.Modelos;
using ApiAuto.Modelos.DtoPerson;
using Azure;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAuto.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PersonasController : Controller
    {
        private readonly VentasAutoContext _db;
        private readonly ILogger<PersonasController> _logger;

        public PersonasController(ILogger<PersonasController> logger, VentasAutoContext db)
        { 
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<PersonaDto>>> GetPersona()
        {
            _logger.LogInformation("Obtener las personas");
                var PersonaList = await _db.Personas.ToListAsync();
            return Ok(PersonaList);
        }

        [HttpGet("{id:int}", Name = "GetPersona" )]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PersonaDto>> GetPersona(int id) 
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Persona por medio del Id {id}");
                return BadRequest();
            }
            var persona = await _db.Personas.FirstOrDefaultAsync(s => s.IdPersona == id);

            if (persona == null)
            {
                return NotFound();
            }
            return Ok(persona);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PersonaDto>> AddPersona([FromBody] CreatePersonaDto createPersonaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Persona modeloPers = new()
            { 
                Nombre = createPersonaDto.Nombre,
                Apellidos = createPersonaDto.Apellido,
                Cedula = createPersonaDto.Cedula,
                Telefono = createPersonaDto.Telefono,
                Correo = createPersonaDto.Correo, 
                UsserName = createPersonaDto.UsserName,
                Password = createPersonaDto.Password,
                Tipo = createPersonaDto.Tipo
            };
            await _db.Personas.AddAsync(modeloPers);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetPersona" , new { id = modeloPers.IdPersona}, modeloPers);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> DeletePerson(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var Person = await _db.Personas.FirstOrDefaultAsync(s => s.IdPersona == id);
            if (Person == null)
            {
                return NotFound();
            }
        
            _db.Personas.Remove(Person);
            await _db.SaveChangesAsync(true);
            return NoContent();
        }


        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ActualizarUsuario(int id, [FromBody] UpdatePersonaDto updatePersonaDto)
        {
            if (updatePersonaDto == null || id != updatePersonaDto.IdPerson)
            {
                return BadRequest();
            }

            Persona modelPerson = new()
            {
                Nombre = updatePersonaDto.Nombre,
                Apellidos = updatePersonaDto.Apellido,
                Cedula = updatePersonaDto.Cedula,
                IdPersona = updatePersonaDto.IdPerson,
                Correo = updatePersonaDto.Correo,
                Telefono = updatePersonaDto.Telefono, 
                UsserName = updatePersonaDto.UsserName,
                Password = updatePersonaDto.Password
            };
            
            _db.Personas.Update(modelPerson);
            await _db.SaveChangesAsync();
            return NoContent();           
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ActualizacioPersonaTemp(int id, JsonPatchDocument<UpdatePersonaDto> pacthDto)
        {
            if (pacthDto == null || id == 0)
            {
                return BadRequest();
            }
            var persona = await _db.Personas.AsNoTracking().FirstOrDefaultAsync(s => s.IdPersona == id);

            UpdatePersonaDto personaDto = new()
            {
                IdPerson = persona.IdPersona,
                Correo = persona.Correo,
                Telefono = persona.Telefono,
                Password = persona.Password
            };

            if (persona == null) return BadRequest();

            pacthDto.ApplyTo(personaDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Persona modeloPerson = new Persona()
            {
                Correo = persona.Correo,
                Telefono = persona.Telefono
            };
            _db.Personas.Update(modeloPerson);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}

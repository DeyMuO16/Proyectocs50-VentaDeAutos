using ApiAuto.Data;
using ApiAuto.Modelos;
using ApiAuto.Modelos.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAuto.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class AutosController : Controller
    {
        private readonly VentasAutoContext _db;
        private readonly ILogger<AutosController> _logger;

        public AutosController(ILogger<AutosController> logger, VentasAutoContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<AutoDto>>> GetAutos()
        {
            _logger.LogInformation("Obtener los Autos");
            var AutosList = await _db.Autos.ToListAsync();
            return Ok(AutosList);
        }

        [HttpGet("{id:int}", Name = "GetAuto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AutoDto>> GetAuto(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Auto por medio del Id {id}");
                return BadRequest();
            }
            var student = await _db.Autos.FirstOrDefaultAsync(s => s.IdAuto == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AutoDto>> AddAuto([FromBody] CreateAutoDto createAutoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Auto modelo = new()
            {
                Marca = createAutoDto.Marca,
                Motor = createAutoDto.Motor,
                puertas = createAutoDto.puertas,
                AñoFabricación = createAutoDto.AñoFabricación,
                kilometrage = createAutoDto.kilometrage,
                chaces = createAutoDto.chaces,
                capacidadPasajeros = createAutoDto.capacidadPasajeros,
                Precio = createAutoDto.Precio
            };

            await _db.Autos.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetAuto", new { id = modelo.IdAuto }, modelo);

        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> DeleteAuto(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var Auto = await _db.Autos.FirstOrDefaultAsync(s => s.IdAuto == id);
            if (Auto == null)
            {
                return NotFound();
            }

            _db.Autos.Remove(Auto);
            await _db.SaveChangesAsync(true);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> updateAuto(int id, [FromBody] UpdateAutoDto updateAutoDto)
        {
            if (updateAutoDto == null || id != updateAutoDto.IdAuto)
            {
                return BadRequest();
            }

            Auto modelo = new()
            {
                IdAuto = updateAutoDto.IdAuto,
                Marca = updateAutoDto.Marca,
                Motor = updateAutoDto.Motor,
                puertas = updateAutoDto.puertas,
                AñoFabricación = updateAutoDto.AñoFabricación,
                kilometrage = updateAutoDto.kilometrage,
                chaces = updateAutoDto.chaces,
                capacidadPasajeros = updateAutoDto.capacidadPasajeros,
                Precio = updateAutoDto.Precio,

            };
            _db.Autos.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> UpdatePartialAuto(int id, JsonPatchDocument<UpdateAutoDto> pacthDto)
        {
            if (pacthDto == null || id == 0)
            {
                return BadRequest();
            }

            var auto = await _db.Autos.AsNoTracking().FirstOrDefaultAsync(s => s.IdAuto == id);
            UpdateAutoDto AutoDto = new()
            {
                IdAuto = auto.IdAuto,
                Precio = auto.Precio,
            };

            if (auto == null) return BadRequest();

            pacthDto.ApplyTo(AutoDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Auto modelo = new()
            {
                IdAuto = AutoDto.IdAuto,
                Precio = AutoDto.Precio
            };

            _db.Autos.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();

        }


    }
}

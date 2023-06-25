using ApiAuto.Data;
using ApiAuto.Modelos;
using ApiAuto.Modelos.CompraDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAuto.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ComprasController : Controller
    {
        private readonly VentasAutoContext _db;
        private readonly ILogger<ComprasController> _logger;

        public ComprasController(ILogger<ComprasController> logger, VentasAutoContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CompraDto>>> GetCompra()
        {
            _logger.LogInformation("Obtener registro de compras");
            var CompraList = await _db.Compras.ToListAsync();
            return Ok(CompraList);
        }

        [HttpGet("{id:int}", Name = "GetCompra")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<CompraDto>> GetCompra(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Persona por medio del Id {id}");
                return BadRequest();
            }
            var compra = await _db.Compras.FirstOrDefaultAsync(s => s.IdCompra == id);

            if (compra == null)
            {
                return NotFound();
            }
            return Ok(compra);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<CompraDto>> AddCompra([FromBody] CreateCompreDto createCompreDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Compra modelCompra = new()
            {
                codigoFact = createCompreDto.codigoFact,
                Total = createCompreDto.Total,
                Concepto = createCompreDto.Concepto,
                Date = createCompreDto.Date,
                IdAuto = createCompreDto.IdAuto,
                IdPersona = createCompreDto.Comprador
            };
            await _db.Compras.AddAsync(modelCompra);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetCompra", new { id = modelCompra.IdCompra }, modelCompra);
        }



    }
}

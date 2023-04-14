using CapaIntegracion.ServicioMarca;
using System.Web.Http;


public class MarcaController : ApiController
{
    ServicioMarcaSoapClient servicio = new ServicioMarcaSoapClient();

    [HttpGet]
    [Route("api/producto/ActualizarMarca/{marca}/{remitente}/{Origen}")]
    public IHttpActionResult ActualizarMarca(Marca marca, string remitente, int Origen)
    {

        return Ok(servicio.ActualizarMarca(marca, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/AgregarMarca/{marca}/{remitente}/{Origen}")]
    public IHttpActionResult AgregarMarca(Marca marca, string remitente, int Origen)
    {

        return Ok(servicio.AgregarMarca(marca, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/ELiminarMarca/{id}/{remitente}/{Origen}")]
    public IHttpActionResult ELiminarMarca(int id, string remitente, int Origen)
    {

        return Ok(servicio.EliminarMarca(id, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/ObtenerMarca/{remitente}/{Origen}")]
    public IHttpActionResult ObtenerMarca(string remitente, int Origen)
    {

        return Ok(servicio.ObtenerMarca(remitente,Origen));
    }

}
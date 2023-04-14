using CapaIntegracion.ServicioCategoria;
using System.Web.Http;


public class CategoriaController : ApiController
{
    ServicioCategoriaSoapClient servicio = new ServicioCategoriaSoapClient();

    [HttpGet]
    [Route("api/producto/ActualizarCategoria/{categoria}/{remitente}/{Origen}")]
    public IHttpActionResult ActualizarCategoria(Categoria categoria, string remitente, int Origen)
    {

        return Ok(servicio.ActualizarCategoria(categoria, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/AgregarCategoria/{categoria}/{remitente}/{Origen}")]
    public IHttpActionResult AgregarCategoria(Categoria categoria, string remitente, int Origen)
    {

        return Ok(servicio.AgregarCategoria(categoria, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/EliminarCategoria/{id}/{remitente}/{Origen}")]
    public IHttpActionResult EliminarCategoria(int id, string remitente, int Origen)
    {

        return Ok(servicio.EliminarCategoria(id, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/ObtenerCategoria/{remitente}/{Origen}")]
    public IHttpActionResult ObtenerCategoria( string remitente, int Origen)
    {

        return Ok(servicio.ObtenerCategoria(remitente, Origen));
    }

}
using CapaIntegracion.ServicioGenerales;
using System.Web.Http;


public class GeneralesController : ApiController
{
    ServicioGeneralesSoapClient servicio = new ServicioGeneralesSoapClient();

    [HttpGet]
    [Route("api/producto/ImagenExiste/{nombre}/{remitente}/{Origen}")]
    public IHttpActionResult ImagenExiste(string nombre, string remitente, int Origen)
    {

        return Ok(servicio.ImagenExiste(nombre, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/SubirImagen/{orden}/{archivoB}/{nombre}/{remitente}/{Origen}")]
    public IHttpActionResult SubirImagen(int orden, byte[] archivoB, string nombre, string remitente, int Origen)
    {

        return Ok(servicio.SubirImagen(orden, archivoB, nombre,remitente,Origen));
    }

}
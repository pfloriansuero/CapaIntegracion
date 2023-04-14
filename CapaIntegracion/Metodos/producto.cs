using CapaIntegracion.ServicioProducto;
using System.Web.Http;


public class ProductoController : ApiController
{
    ServicioProductoSoapClient servicio = new ServicioProductoSoapClient();

    [HttpGet]
    [Route("api/producto/CrearProducto/{producto}/{remitente}/{Origen}")]
    public IHttpActionResult CrearProducto(Producto producto, string remitente, int Origen)
    {

        return Ok(servicio.CrearProducto(producto,remitente,Origen));
    }

    [HttpGet]
    [Route("api/producto/ImagenesProducto/{id}/{remitente}/{Origen}")]
    public IHttpActionResult ImagenesProducto(int id, string remitente, int Origen)
    {

        return Ok(servicio.ImagenesProducto(id,remitente,Origen));
    }

    [HttpGet]
    [Route("api/producto/ProductoExiste/{nombre}/{remitente}/{Origen}")]
    public IHttpActionResult ProductoExiste(string nombre, string remitente, int Origen)
    {

        return Ok(servicio.ProductoExiste(nombre, remitente,Origen));
    }

    [HttpGet]
    [Route("api/producto/ComandoProducto/{num1}/{remitente}/{Origen}")]
    public IHttpActionResult ComandoProducto(int num1, string remitente, int Origen)
    {

        return Ok(servicio.ComandoProductos(num1,remitente,Origen));
    }

    [HttpGet]
    [Route("api/producto/ActualizarProducto/{producto}/{remitente}/{Origen}")]
    public IHttpActionResult ActualizarProducto(Producto producto, string remitente, int Origen)
    {

        return Ok(servicio.ActualizarProducto(producto,remitente,Origen));
    }

    [HttpGet]
    [Route("api/producto/EliminarProductos/{id}/{remitente}/{Origen}")]
    public IHttpActionResult EliminarProductos(int id, string remitente, int Origen)
    {

        return Ok(servicio.EliminarProducto(id,remitente,Origen));
    }

    [HttpGet]//bien
    [Route("api/producto/EliminarImagenP/{nombreImagen}/{remitente}/{Origen}")]
    public IHttpActionResult EliminarImagenP(string nombreImagen, string remitente, int Origen)
    {

        return Ok(servicio.EliminarImagenP(nombreImagen,remitente,Origen));
    }

    [HttpGet]//bien
    [Route("api/producto/ObtenerImagenesProducto/{id}/{remitente}/{Origen}")]
    public IHttpActionResult ObtenerImagenesProducto(int id, string remitente, int Origen)
    {

        return Ok(servicio.ObtenerImagenesProducto(id,remitente,Origen));
    }

    [HttpGet]//bien
    [Route("api/producto/AgregarImagenProducto/{imagenes}/{remitente}/{Origen}")]
    public IHttpActionResult ImagenesProducto(Imagenes imagenes, string remitente, int Origen)
    {

        return Ok(servicio.AgregarImagenProducto(imagenes, remitente, Origen));
    }
}
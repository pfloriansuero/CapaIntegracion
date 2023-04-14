using CapaIntegracion.ServiceUsuario;
using System.Web.Http;


public class UsuarioController : ApiController
{
    ServicioUsuarioSoapClient servicio = new ServicioUsuarioSoapClient();

    [HttpGet]
    [Route("api/producto/ActualizarUsuario/{user}/{correoAnterior}/{usuarioAnterior}/{remitente}/{Origen}")]
    public IHttpActionResult ActualizarUsuario(Usuario user, string correoAnterior, string usuarioAnterior, string remitente, int Origen)
    {

        return Ok(servicio.ActualizarUsuario(user, correoAnterior, usuarioAnterior, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/EliminarUsuario/{id}/{remitente}/{Origen}")]
    public IHttpActionResult EliminarUsuario(int id, string remitente, int Origen)
    {

        return Ok(servicio.EliminarUsuario(id, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/EliminarUsuarioFireBase/{email}/{contraseña}/{remitente}/{Origen}")]
    public IHttpActionResult EliminarUsuarioFireBase(string email, string contraseña, string remitente, int Origen)
    {

        return Ok(servicio.EliminarUsuarioFirebase(email, contraseña, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/IngresarUsuario/{user}/{remitente}/{Origen}")]
    public IHttpActionResult IngresarUsuario(Usuario user, string remitente, int Origen)
    {

        return Ok(servicio.IngresarUsuario(user, remitente, Origen));
    }

    [HttpGet]
    [Route("api/producto/IniciarSesionFirebase/{email}/{contraseña}/{remitente}/{Origen}")]
    public IHttpActionResult IniciarSesionFirebase(string email, string contraseña, string remitente, int Origen)
    {

        return Ok(servicio.IniciarSesionFirebase(email, contraseña, remitente, Origen));
    }



    [HttpGet]
    [Route("api/producto/ObtenerUsuario/{usuario}/{remitente}/{Origen}")]
    public IHttpActionResult ObtenerUsuario(string usuario, string remitente, int Origen)
    {

        return Ok(servicio.ObtenerUsuario(usuario, remitente, Origen));
    }

}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlCasos.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ControlCasosEntities : DbContext
    {
        public ControlCasosEntities()
            : base("name=ControlCasosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Nullable<byte>> sp_ValidarUsuario(string usuario, string contrasena)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("Contrasena", contrasena) :
                new ObjectParameter("Contrasena", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<byte>>("sp_ValidarUsuario", usuarioParameter, contrasenaParameter);
        }
    
        public virtual ObjectResult<sp_Cliente_Consultar_Result> sp_Cliente_Consultar(string nombreCliente)
        {
            var nombreClienteParameter = nombreCliente != null ?
                new ObjectParameter("NombreCliente", nombreCliente) :
                new ObjectParameter("NombreCliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Cliente_Consultar_Result>("sp_Cliente_Consultar", nombreClienteParameter);
        }
    
        public virtual int sp_Cliente_Insertar(string cliente)
        {
            var clienteParameter = cliente != null ?
                new ObjectParameter("Cliente", cliente) :
                new ObjectParameter("Cliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Cliente_Insertar", clienteParameter);
        }
    
        public virtual ObjectResult<sp_Marca_Consultar_Result> sp_Marca_Consultar(string marca)
        {
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Marca_Consultar_Result>("sp_Marca_Consultar", marcaParameter);
        }
    
        public virtual int sp_Marca_Insertar(string marca)
        {
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Marca_Insertar", marcaParameter);
        }
    
        public virtual ObjectResult<sp_TipoProducto_Consultar_Result> sp_TipoProducto_Consultar(string tipoProducto)
        {
            var tipoProductoParameter = tipoProducto != null ?
                new ObjectParameter("TipoProducto", tipoProducto) :
                new ObjectParameter("TipoProducto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TipoProducto_Consultar_Result>("sp_TipoProducto_Consultar", tipoProductoParameter);
        }
    
        public virtual int sp_TipoProducto_Insertar(string tipoProducto)
        {
            var tipoProductoParameter = tipoProducto != null ?
                new ObjectParameter("TipoProducto", tipoProducto) :
                new ObjectParameter("TipoProducto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_TipoProducto_Insertar", tipoProductoParameter);
        }
    
        public virtual ObjectResult<sp_Color_Consultar_Result> sp_Color_Consultar(string color, string guia)
        {
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var guiaParameter = guia != null ?
                new ObjectParameter("Guia", guia) :
                new ObjectParameter("Guia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Color_Consultar_Result>("sp_Color_Consultar", colorParameter, guiaParameter);
        }
    
        public virtual int sp_Color_Insertar(string color, string guia)
        {
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var guiaParameter = guia != null ?
                new ObjectParameter("Guia", guia) :
                new ObjectParameter("Guia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Color_Insertar", colorParameter, guiaParameter);
        }
    
        public virtual ObjectResult<sp_Doctor_Consultar_Result> sp_Doctor_Consultar(string nombreDoctor)
        {
            var nombreDoctorParameter = nombreDoctor != null ?
                new ObjectParameter("NombreDoctor", nombreDoctor) :
                new ObjectParameter("NombreDoctor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Doctor_Consultar_Result>("sp_Doctor_Consultar", nombreDoctorParameter);
        }
    
        public virtual int sp_Doctor_Insertar(string cedula, string nombre, string apellido1, string apellido2, string correo, string telefono, Nullable<int> idCliente)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellido1Parameter = apellido1 != null ?
                new ObjectParameter("Apellido1", apellido1) :
                new ObjectParameter("Apellido1", typeof(string));
    
            var apellido2Parameter = apellido2 != null ?
                new ObjectParameter("Apellido2", apellido2) :
                new ObjectParameter("Apellido2", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Doctor_Insertar", cedulaParameter, nombreParameter, apellido1Parameter, apellido2Parameter, correoParameter, telefonoParameter, idClienteParameter);
        }
    
        public virtual ObjectResult<sp_ClienteID_Consultar_Result> sp_ClienteID_Consultar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ClienteID_Consultar_Result>("sp_ClienteID_Consultar", idParameter);
        }
    
        public virtual ObjectResult<sp_ColorID_Consultar_Result> sp_ColorID_Consultar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ColorID_Consultar_Result>("sp_ColorID_Consultar", idParameter);
        }
    
        public virtual ObjectResult<sp_DoctorID_Consultar_Result> sp_DoctorID_Consultar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DoctorID_Consultar_Result>("sp_DoctorID_Consultar", idParameter);
        }
    
        public virtual ObjectResult<sp_MarcaID_Consultar_Result> sp_MarcaID_Consultar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MarcaID_Consultar_Result>("sp_MarcaID_Consultar", idParameter);
        }
    
        public virtual ObjectResult<sp_TipoProductoID_Consultar_Result> sp_TipoProductoID_Consultar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TipoProductoID_Consultar_Result>("sp_TipoProductoID_Consultar", idParameter);
        }
    
        public virtual int sp_Cliente_Editar(Nullable<int> idCliente, string cliente, Nullable<bool> estado)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var clienteParameter = cliente != null ?
                new ObjectParameter("cliente", cliente) :
                new ObjectParameter("cliente", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Cliente_Editar", idClienteParameter, clienteParameter, estadoParameter);
        }
    
        public virtual int sp_Cliente_Eliminar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Cliente_Eliminar", idParameter);
        }
    
        public virtual int sp_Color_Editar(Nullable<int> id, string color, string guia)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var guiaParameter = guia != null ?
                new ObjectParameter("Guia", guia) :
                new ObjectParameter("Guia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Color_Editar", idParameter, colorParameter, guiaParameter);
        }
    
        public virtual int sp_Color_Eliminar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Color_Eliminar", idParameter);
        }
    
        public virtual int sp_Doctor_Editar(Nullable<int> id, string cedula, string nombre, string apellido1, string apellido2, string correo, string telefono, Nullable<bool> estado, Nullable<int> idCliente)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellido1Parameter = apellido1 != null ?
                new ObjectParameter("Apellido1", apellido1) :
                new ObjectParameter("Apellido1", typeof(string));
    
            var apellido2Parameter = apellido2 != null ?
                new ObjectParameter("Apellido2", apellido2) :
                new ObjectParameter("Apellido2", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Doctor_Editar", idParameter, cedulaParameter, nombreParameter, apellido1Parameter, apellido2Parameter, correoParameter, telefonoParameter, estadoParameter, idClienteParameter);
        }
    
        public virtual int sp_Doctor_Eliminar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Doctor_Eliminar", idParameter);
        }
    
        public virtual int sp_Marca_Editar(Nullable<int> id, string marca)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Marca_Editar", idParameter, marcaParameter);
        }
    
        public virtual int sp_Marca_Eliminar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Marca_Eliminar", idParameter);
        }
    
        public virtual int sp_TipoProducto_Editar(Nullable<int> id, string tipoProducto)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var tipoProductoParameter = tipoProducto != null ?
                new ObjectParameter("TipoProducto", tipoProducto) :
                new ObjectParameter("TipoProducto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_TipoProducto_Editar", idParameter, tipoProductoParameter);
        }
    
        public virtual int sp_TipoProducto_Eliminar(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_TipoProducto_Eliminar", idParameter);
        }
    }
}

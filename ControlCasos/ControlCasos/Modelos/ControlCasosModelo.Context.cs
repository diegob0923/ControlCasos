﻿//------------------------------------------------------------------------------
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
    }
}

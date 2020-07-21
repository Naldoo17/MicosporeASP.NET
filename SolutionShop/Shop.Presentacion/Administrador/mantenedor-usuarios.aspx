<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="mantenedor-usuarios.aspx.cs" Inherits="Shop.Presentacion.Administrador.mantenedor_usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .mydropdownlist {
            color: #fff;
            font-size: 20px;
            /*padding: 5px 10px;*/
            border-radius: 5px;
            background-color: #CC2EFA;
            font-weight: bold;
        }

        .fondo {
            background-color: white;
        }
    </style>
    <script type="text/javascript">


        function formatCliente(cliente) {
            cliente.value = cliente.value.replace(/[.-]/g, '')
                .replace(/^(\d{1,2})(\d{3})(\d{3})(\w{1})$/, '$1.$2.$3-$4')
        }

        // Solo permite ingresar numeros.

        function soloNumeros(e) {

            var key = window.Event ? e.which : e.keyCode

            return (key >= 48 && key <= 57)

        }


        function checkRut(rut) {
            // Despejar Puntos
            var valor = rut.value.replace('.', '');
            // Despejar Guión
            valor = valor.replace('-', '');

            // Aislar Cuerpo y Dígito Verificador
            cuerpo = valor.slice(0, -1);
            dv = valor.slice(-1).toUpperCase();

            // Formatear RUN
            rut.value = cuerpo + '-' + dv

            // Si no cumple con el mínimo ej. (n.nnn.nnn)
            if (cuerpo.length < 7) { rut.setCustomValidity("RUT Incompleto"); return false; }

            // Calcular Dígito Verificador
            suma = 0;
            multiplo = 2;

            // Para cada dígito del Cuerpo
            for (i = 1; i <= cuerpo.length; i++) {

                // Obtener su Producto con el Múltiplo Correspondiente
                index = multiplo * valor.charAt(cuerpo.length - i);

                // Sumar al Contador General
                suma = suma + index;

                // Consolidar Múltiplo dentro del rango [2,7]
                if (multiplo < 7) { multiplo = multiplo + 1; } else { multiplo = 2; }

            }

            // Calcular Dígito Verificador en base al Módulo 11
            dvEsperado = 11 - (suma % 11);

            // Casos Especiales (0 y K)
            dv = (dv == 'K') ? 10 : dv;
            dv = (dv == 0) ? 11 : dv;

            // Validar que el Cuerpo coincide con su Dígito Verificador
            if (dvEsperado != dv) { rut.setCustomValidity("RUT Inválido"); return false; }

            // Si todo sale bien, eliminar errores (decretar que es válido)
            rut.setCustomValidity('');
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mantenedor">


        <h1>Mantenedor Clientes</h1>
        <div class="row ">
            <div class="col-lg-12 rounded">

                <div>
                    <asp:Label ID="Label1" runat="server" Text="Rut"></asp:Label>
                    <asp:TextBox ID="txtRut" MaxLength="12" oninput="checkRut(this)" CssClass="texto" required="true" placeholder="Ingrese rut cliente" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txtNombre" MaxLength="50" CssClass=" texto" required="true" placeholder="Ingrese nombre cliente" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label ID="Label3" runat="server" Text=" Apellido Paterno"></asp:Label>
                    <asp:TextBox ID="txtAppaterno" MaxLength="50" CssClass=" texto" required="true" placeholder="Ingrese apellido paterno cliente" runat="server"></asp:TextBox>
                </div>
                <br />


                <div>
                    <asp:Label ID="Label4" runat="server" Text=" Apellido Materno"></asp:Label>
                    <asp:TextBox ID="txtApmaterno" MaxLength="50" CssClass=" texto" required="true" placeholder="Ingrese apellido materno cliente" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label ID="Label10" runat="server" Text=" Constraseña"></asp:Label>
                    <asp:TextBox ID="txtContrasena" MaxLength="50" CssClass=" texto" required="true" placeholder="Ingrese contraseña" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Contraseñas no coinciden" ControlToCompare="txtContrasenaConfirm" ControlToValidate="txtContrasena" ForeColor="Red"></asp:CompareValidator>
                </div>
                <div>
                    <asp:Label ID="Label11" runat="server" Text=" Repita Contraseña"></asp:Label>
                    <asp:TextBox ID="txtContrasenaConfirm" MaxLength="50" CssClass=" texto" required="true" placeholder="Ingrese contraseñan nuevamente" TextMode="Password" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label ID="Label5" runat="server" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="txtDireccion" MaxLength="50" CssClass=" texto" required="true" placeholder="Ingrese direccion cliente" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label ID="Label6" runat="server" Text="Comuna"></asp:Label>
                    <asp:DropDownList ID="ddlComuna" runat="server" CssClass="texto"></asp:DropDownList>
                </div>
                <br />

                <div>
                    <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtEmail" TextMode="Email" MaxLength="50" CssClass=" texto" required="true" placeholder="Ingrese correo cliente" runat="server"></asp:TextBox>
                </div>
                <br />


                <div>
                    <asp:Label ID="Label8" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="txtTelefono" onKeyPress="return soloNumeros(event)" MaxLength="10" CssClass=" texto" required="true" placeholder="Ingrese telefono cliente" runat="server"></asp:TextBox>
                </div>
                <br />

                <div>
                    <asp:Label ID="Label9" runat="server" Text="Tipo Cliente"></asp:Label>
                    <asp:DropDownList ID="ddlTipoCliente" runat="server" CssClass=" texto"></asp:DropDownList>
                </div>
                <br />

                <div>
                    <asp:Button ID="btnCrearUsuario" CssClass="botton-register " runat="server" Text="Crear Cliente/Usuario" OnClick="btnCrearUsuario_Click" />
                    &nbsp;
                    <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="red"></asp:Label>
                </div>

                <br />
                <br />
            </div>
            <div class="col-lg-2"></div>
            <div class="col-lg-5"></div>

        </div>

    </div>





</asp:Content>

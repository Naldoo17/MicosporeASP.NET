<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="mantenedor-tipoInfo.aspx.cs" Inherits="Shop.Presentacion.Administrador.mantenedor_tipoInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .tipoInfo {
            background-color: white;
            height: auto;
            width: auto;
        }

        .mydropdownlist {
            color: #fff;
            font-size: 20px;
            padding: 5px 10px;
            border-radius: 5px;
            background-color: #CC2EFA;
            font-weight: bold;
        }
    </style>

    <script type="text/javascript">
        function SelectAllCheckboxes(spanChk) {
            var xState = spanChk.checked;
            var theBox = spanChk;
            var elm = theBox.form.elements;
            for (i = 0; i < elm.length; i++)
                if (elm[i].type == "radio" && elm[i].id != theBox.id) {
                    elm[i].checked = false;
                }
        }
    </script>

    <div class="container mantenedor">
        <div class="row ">

            <div class="col-md-6 tipoInfo py-5 ">
                <h3>Mantenedor tipo información </h3>
                <div>
                    <asp:HiddenField ID="hdId" runat="server" />
                    <asp:Label runat="server" ID="lblasda">Nombre tipo información</asp:Label>
                    <asp:TextBox ID="txtNombreTipoInfo" MaxLength="100" CssClass=" texto" placeholder="Ingrese nombre tipo información"  runat="server"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Button ID="btnAgregar" runat="server" CssClass="botton-register " Text="Guardar" OnClick="btnAgregar_Click" />
                     <asp:Button ID="btnEditar" runat="server" CssClass="botton-register " Text="Editar" OnClick="btnEditar_Click" />
                    <asp:Button ID="btnActualizar" runat="server" CssClass="botton-register " Text="Actualizar" OnClick="btnActualizar_Click" />
                    <asp:Button ID="btnEliminar" runat="server" CssClass="botton-register " Text="Eliminar" OnClick="btnEliminar_Click"  />
                    <asp:Label runat="server" ID="lblmensaje" ForeColor="Red"></asp:Label>
                    <br />
                </div>

            </div>

            <div class="col-md-6 tipoInfo  py-5 "">

                <%--<asp:GridView ID="GvTipoInfo" runat="server"></asp:GridView>--%>
                <%--OnSelectedIndexChanging="gv_alumnos_SelectedIndexChanging" OnSelectedIndexChanged="gv_alumnos_SelectedIndexChanged" OnPageIndexChanging="gv_alumnos_PageIndexChanging"--%>
                <asp:GridView ID="GvTipoInfo" runat="server" CssClass="table table-bordered bs-table" DataKeyNames="Id,Nombre" AutoGenerateColumns="False" AllowPaging="true" Width="500">
                    <Columns>
                        <asp:TemplateField HeaderText="Sel" ItemStyle-CssClass="ItemStyleGrilla">
                            <ItemStyle HorizontalAlign="Center" CssClass="ItemStyleGrilla" />
                            <ItemTemplate>
                                <input type="radio" name="MIO" runat="server" class="NombreCampo" id="RadioButton1"
                                    value="RadioButton1" onclick="SelectAllCheckboxes(this)" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField HeaderText="Id" DataField="IdAlumnos" Visible="false">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>

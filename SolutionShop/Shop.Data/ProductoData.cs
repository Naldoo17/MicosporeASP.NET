using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
namespace Shop.Data
{
    public class ProductoData
    {
        public static bool CrearProductoData(ProductoDTO producto)
        {
            try
            {

                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {

                    db.SP_MANTENEDOR_PRODUCTO(producto.IdProducto, producto.TipoProducto, producto.NombreProducto, producto.Descripcion, producto.Stock, (int)producto.Precio, "img/" + producto.Img, producto.Estado, 1); ;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public static bool EliminarProducto(ProductoDTO producto)
        {
            try
            {

                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {

                    db.SP_MANTENEDOR_PRODUCTO(producto.IdProducto, producto.TipoProducto, producto.NombreProducto, producto.Descripcion, producto.Stock, (int)producto.Precio, "img/" + producto.Img, producto.Estado, 3); ;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public static bool ActualizarProducto(ProductoDTO producto, int accion)
        {
            try
            {
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {

                    db.SP_MANTENEDOR_PRODUCTO(producto.IdProducto, producto.TipoProducto, producto.NombreProducto, producto.Descripcion, producto.Stock, (int)producto.Precio, "img/" + producto.Img, producto.Estado, accion); ;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        //public static bool EliminarProducto(ProductoDTO producto)
        //{
        //    try
        //    {
        //        using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
        //        {

        //            db.SP_MANTENEDOR_PRODUCTO(producto.IdProducto, producto.TipoProducto, producto.NombreProducto, producto.Descripcion, producto.Stock, (int)producto.Precio, producto.Img, 2); ;
        //            db.SaveChanges();
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }
        //}


        public static List<ProductoDTO> ObtenerProductosAllData()
        {
            try
            {

                


                List<ProductoDTO> listaProductos = new List<ProductoDTO>();
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {


                    foreach (var aux in db.PRODUCTO)
                    {
                        ProductoDTO prod = new ProductoDTO();
                        prod.IdProducto = aux.ID_PRODUCTO;
                        prod.NombreProducto = aux.NOMBRE;
                        prod.Descripcion = aux.DESCRIPCION;
                        prod.TipoProducto = (int)aux.TIPO_PRODUCTO;
                        prod.Stock = (int)aux.STOCK;
                        prod.Precio = (int)aux.PRECIO;
                        prod.Img = aux.img_producto;
                        prod.Estado = (int)aux.ACTIVO;
//.                       aux.prueba
                        listaProductos.Add(prod);
                    }
                }

                return listaProductos;

            }
            catch (Exception ex)
            {

                return null;
            }
        }


        public static List<ProductoDTO> ObtenerProductosAllFiltroTipoProdData(int tipoProducto)
        {
            try
            {

                List<ProductoDTO> listaProductos = new List<ProductoDTO>();
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {
                    //var lista = db.SP_SELECT_ALL_PRODUCTS().ToList();
                    var listaFiltro = (from c in db.PRODUCTO
                                       where c.TIPO_PRODUCTO == tipoProducto
                                       select c).ToList();
                    foreach (var aux in listaFiltro)
                    {
                        ProductoDTO prod = new ProductoDTO();
                        prod.IdProducto = aux.ID_PRODUCTO;
                        prod.NombreProducto = aux.NOMBRE;
                        prod.Descripcion = aux.DESCRIPCION;
                        prod.TipoProducto = (int)aux.TIPO_PRODUCTO;
                        prod.Stock = (int)aux.STOCK;
                        prod.Precio = (int)aux.PRECIO;
                        prod.Img = aux.img_producto;
                        prod.Estado = (int)aux.ACTIVO;

                        listaProductos.Add(prod);
                    }
                }

                return listaProductos;

            }
            catch (Exception ex)
            {

                return null;
            }
        }




        public static ProductoDTO ObtenerProductoFiltroID(int idProd)
        {
            try
            {
                ProductoDTO prod = new ProductoDTO();
                //List<ProductoDTO> listaProductos = new List<ProductoDTO>();
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {


                    foreach (var aux in db.PRODUCTO.Where(p => p.ID_PRODUCTO == idProd).ToList())
                    {
                        prod.IdProducto = aux.ID_PRODUCTO;
                        prod.NombreProducto = aux.NOMBRE;
                        prod.Precio = (double)aux.PRECIO;
                        prod.Stock = (int)aux.STOCK;
                        prod.Img = prod.Img;
                        prod.TipoProducto = (int)aux.TIPO_PRODUCTO;
                        prod.Descripcion = aux.DESCRIPCION;
                        prod.Estado = (int)aux.ACTIVO;


                    }
                    //var lista = db.SP_SELECT_ALL_PRODUCTS_FILTER_ID(idProd).ToList();
                    //var listaFiltro = (from c in lista                                       
                    //                   select c).ToList();

                    //foreach (var aux in listaFiltro)
                    //{

                    //    prod.IdProducto = aux.ID_PRODUCTO;
                    //    prod.NombreProducto = aux.NOMBRE;
                    //    prod.Descripcion = aux.DESCRIPCION;
                    //    prod.TipoProducto = (int)aux.TIPO_PRODUCTO;
                    //    prod.Stock = (int)aux.STOCK;
                    //    prod.Precio = (int)aux.PRECIO;
                    //    prod.Img = aux.img_producto;

                    //}
                }

                return prod;

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static List<ProductoDTO> ObtenerListaProductosJoinTipoData()
        {
            //var lista = ObtenerProductosAllNegocio();
            //var listaTipoProd = TipoProductoData.ObtenerTipoProductosAllData();
            List<ProductoDTO> listaProd = new List<ProductoDTO>();

            using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
            {
                listaProd = (from c in db.PRODUCTO
                                           join t in db.TIPO_PRODUCTO
                                           on c.TIPO_PRODUCTO equals t.ID_TIPO_PRODUCTO
                             select new ProductoDTO
                             {
                                 IdProducto = c.ID_PRODUCTO,
                                 NombreProducto = c.NOMBRE,
                                 Descripcion = c.DESCRIPCION,
                                 Stock = (int)c.STOCK,
                                 Img = c.img_producto,
                                 Precio = (double)c.PRECIO,
                                 Estado = (int)c.ACTIVO,
                                 NombreTipoProd = t.NOMBRE,
                                 TipoProducto =(int) c.TIPO_PRODUCTO,
                                 nombreEstado=c.ACTIVO==1 ? "Activo" : "Inactivo"
                             }).ToList();
            }

            return listaProd;

        }

        public static string RetonaEstadoActivo(int estado)
        {
            string retorno = "";
            switch (estado)
            {
                case 0:
                    retorno = "Inactivo";
                    break;
                case 1:
                    retorno = "Inactivo";
                    break;
            }
            return retorno;

        }
    }
}


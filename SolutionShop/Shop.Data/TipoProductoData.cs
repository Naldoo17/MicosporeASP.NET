using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;

namespace Shop.Data
{
    public class TipoProductoData
    {

        public static bool MantenedorTipoProductoData(TipoProductoDTO tipo, int accion)
        {
            try
            {
                bool valida = false;
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {
                    db.SP_MANTENEDOR_TIPO_PRODUCTO(tipo.idTipoProducto, tipo.nombreProducto, tipo.descripcion, "img/" + tipo.img, tipo.activo, accion);
                    valida = true;
                    db.SaveChanges();
                }

                return valida;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public static List<TipoProductoDTO> ObtenerTipoProductosActivosAllData()
        {
            try
            {
                List<TipoProductoDTO> listaTipoProd = new List<TipoProductoDTO>();
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {
                    //var lista = db.SP_SELECT_ALL_TIPO_PROD1().ToList();


                    foreach (var aux in db.TIPO_PRODUCTO)
                    {
                        if (aux.ACTIVO == 1)
                        {
                            TipoProductoDTO tipoProd = new TipoProductoDTO();
                            tipoProd.idTipoProducto = (int)aux.ID_TIPO_PRODUCTO;
                            tipoProd.nombreProducto = aux.NOMBRE.ToString();
                            tipoProd.img = aux.IMG;
                            tipoProd.activo = (int)aux.ACTIVO;
                            tipoProd.descripcion = aux.DESCRIPCION;
                            tipoProd.nombreEstado = aux.ACTIVO == 1 ? "Activo" : "Inactivo";
                            listaTipoProd.Add(tipoProd);
                        }
                    }
                }

                return listaTipoProd;
            }
            catch (Exception ex)
            {
                return null;
            }
        }






        public static List<TipoProductoDTO> ObtenerTipoProductosAllData()
        {
            try
            {
                List<TipoProductoDTO> listaTipoProd = new List<TipoProductoDTO>();
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {

                    foreach (var aux in db.TIPO_PRODUCTO)
                    {
                        TipoProductoDTO tipoProd = new TipoProductoDTO();
                        tipoProd.idTipoProducto = (int)aux.ID_TIPO_PRODUCTO;
                        tipoProd.nombreProducto = aux.NOMBRE.ToString();
                        tipoProd.img = aux.IMG;
                        tipoProd.descripcion = aux.DESCRIPCION;
                        tipoProd.activo = (int)aux.ACTIVO;
                        tipoProd.nombreEstado = aux.ACTIVO == 1 ? "Activo" : "Inactivo";
                        listaTipoProd.Add(tipoProd);
                    }
                }

                return listaTipoProd;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static TipoProductoDTO ObtenerTipoProductosFiltroID(int idTipoProd)
        {
            try
            {
                TipoProductoDTO tipoProducto = new TipoProductoDTO();
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {



                    foreach (var aux in db.TIPO_PRODUCTO)
                    {
                        if (aux.ID_TIPO_PRODUCTO == idTipoProd)
                        {
                            tipoProducto.idTipoProducto = (int)aux.ID_TIPO_PRODUCTO;
                            tipoProducto.nombreProducto = aux.NOMBRE.ToString();
                            tipoProducto.img = aux.IMG;
                            tipoProducto.descripcion = aux.DESCRIPCION;
                            tipoProducto.activo = (int)aux.ACTIVO;
                            break;
                        }


                    }
                }

                return tipoProducto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}

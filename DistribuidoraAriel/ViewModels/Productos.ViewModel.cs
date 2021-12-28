using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraAriel.ViewModels
{
    //** Hereda de BaseViewModel
    public class ProductosViewModel : BaseViewModel
    {
        //Elementos que enlaza con la Vista
        private string _NombreArticulo;
        private int _CantidadArticulo;
        private double _PrecioCompraArticulo;
        private double _PrecioVentaArticulo;
        private double _TotalCompraArticulo;

        public string Nombre
        {
            get { return _NombreArticulo; }
            set { _NombreArticulo = value;
                OnPropertyChanged();
            }
        }
        public int Cantidad
        {
            get { return _CantidadArticulo; }
            set
            {
                _CantidadArticulo = value;
                Total();
                OnPropertyChanged();
            }
        }
        public double PrecioCompra
        {
            get { return _PrecioCompraArticulo; }
            set
            {
                _PrecioCompraArticulo = value;
                Total();
                OnPropertyChanged();
            }
        }
        public double PrecioVenta
        {
            get { return _PrecioVentaArticulo; }
            set
            {
                _PrecioVentaArticulo = value;
                OnPropertyChanged();
            }
        }
        public double TotalCompra
        {
            get { return _TotalCompraArticulo; }
            set
            {
                _TotalCompraArticulo = value;
                OnPropertyChanged();
            }
        }

        public ProductosViewModel()
        {
            
        }
        public void Total()
        {
            var f = Cantidad * PrecioCompra;
            TotalCompra = f;
        }

    }
}

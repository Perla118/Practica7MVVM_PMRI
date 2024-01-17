using Practica7MVVM_PMRI.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Practica7MVVM_PMRI.Datos;
using Practica7MVVM_PMRI.Vista;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica7MVVM_PMRI.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mcategorias> _listaCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void MostrarCategorias()
        {
            //Para agarrar todos los datos
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(MostrarCategorias);
        #endregion
    }
}


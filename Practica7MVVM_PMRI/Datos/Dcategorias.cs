using Practica7MVVM_PMRI.Modelo;
using Practica7MVVM_PMRI.VistaModelo;
using Practica7MVVM_PMRI.Vista;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Practica7MVVM_PMRI.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>() {
                new Mcategorias()
                {
                    descripcion = "Cena",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/DbcF797/cena-de-navidad.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                     descripcion = "Hotel",
                     numeroItem=4512,
                     imagen="https://i.ibb.co/ZTTFwVj/hacer-la-cama.png",
                     backgroundColor="#EAEDF6",
                     textColor="#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Fiesta",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/rGdP5yn/papel-picado.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                     descripcion = "Flores",
                     numeroItem=4512,
                     imagen="https://i.ibb.co/rH2SCZX/flor.png",
                     backgroundColor="#EAEDF6",
                     textColor="#000000"
                },
            };
        }
    }
}
